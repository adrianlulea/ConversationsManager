using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Framework.Util;

namespace Framework.Data.Conversations
{
    /// <summary>
    /// DataManger class.
    /// </summary>
    public class DataManager
    {
        #region Members

        /// <summary>
        /// Internal data representation.
        /// </summary>
        private InternalDatabase _internalData;

        /// <summary>
        /// External data representation.
        /// </summary>
        private ExternalDatabase _externalData;

        /// <summary>
        /// Path to save data.
        /// </summary>
        private string _savePath;

        /// <summary>
        /// Back-up suffix.
        /// </summary>
        private const string _backupSuffix = "_bak";

        #endregion

        #region Properties

        /// <summary>
        /// Get Replies.
        /// </summary>
        public List<InternalReply> Replies
        {
            get { return _internalData.Replies; }
        }

        /// <summary>
        /// Get used Ids
        /// </summary>
        public List<Guid> UsedIds
        {
            get
            {
                if (_internalData != null)
                {
                    return _internalData.UsedIds;
                }
                else
                {
                    return new List<Guid>();
                }
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor; pass data save path.
        /// </summary>
        /// <param name="path">Save path.</param>
        /// <param name="newDatabase">Creating a new database.</param>
        public DataManager(string path, bool newDatabase)
        {
            bool testRead = (newDatabase == false);
            TestPath(path, testRead, true);
            _savePath = path;

            if (newDatabase)
            {
                _internalData = new InternalDatabase();
                _externalData = new ExternalDatabase(_internalData);
                SaveData();
            }
            else
            {
                ExternalFormat format = PreferencesManager.GetFormat(path);
                _externalData = DataManager.Deserialize(path, format);
                _internalData = new InternalDatabase(_externalData);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Test path if valid and throw exceptions accordingly.
        /// </summary>
        /// <param name="path">Path to test for existence.</param>
        /// <param name="testRead">Flag if exists for reading.</param>
        /// <param name="testWrite">Flag if write perimissions exist.</param>
        /// <exception cref="InvalidPathException">Invalid path.</exception>
        private void TestPath(string path, bool testRead, bool testWrite)
        {
            if (path == null || path == "")
            {
                throw new InvalidPathException();
            }

            if (testRead && File.Exists(path) == false)
            {
                throw new InvalidPathException();
            }

            if (testWrite)
            {
                bool existingFile = true;

                if (File.Exists(path) == false)
                {
                    existingFile = false;
                }

                try
                {
                    // Create back-up
                    if (existingFile)
                    {
                        File.Copy(path, path + _backupSuffix, true);
                    }

                    // Overwrite path
                    FileStream stream = File.Create(path);
                    stream.Close();

                    // Restore and remove back-up copy
                    if (existingFile)
                    {
                        File.Copy(path + _backupSuffix, path, true);
                        File.Delete(path + _backupSuffix);
                    }
                }
                catch(IOException e)
                {
                    //TODO test for memory/HDD leaks
                    Console.WriteLine(e.StackTrace);
                    throw new InvalidPathException();
                }
            }
        }

        /// <summary>
        /// Import data from the given path.
        /// </summary>
        /// <param name="path">Path to import from.</param>
        public void ImportData(string path)
        {
            ExternalFormat format = PreferencesManager.GetFormat(path);
            _externalData = DataManager.Deserialize(path, format);
            _internalData = new InternalDatabase(_externalData);
        }

        /// <summary>
        /// Import data from the set path.
        /// </summary>
        public void ImportData()
        {
            ImportData(_savePath);
        }

        /// <summary>
        /// Export data to the given path.
        /// </summary>
        /// <param name="path">Path to export to.</param>
        public void ExportData(string path)
        {
            ExternalFormat format = PreferencesManager.GetFormat(path);
            _externalData = new ExternalDatabase(_internalData);
            DataManager.Serialize(_externalData, path, format);
        }

        /// <summary>
        /// Export data to the set path.
        /// </summary>
        public void ExportData()
        {
            ExportData(_savePath);
        }

        /// <summary>
        /// Save data to set path.
        /// </summary>
        public void SaveData()
        {
            // Update the external data
            _externalData = new ExternalDatabase(_internalData);

            // Export data
            ExportData();
        }

        #region Data modification

        /// <summary>
        /// Add reply by data.
        /// </summary>
        /// <param name="data">Reply data.</param>
        /// <returns>Guid generated for given reply.</returns>
        public Guid AddReply(InternalReplyData data)
        {
            return _internalData.AddReply(data);
        }

        /// <summary>
        /// Remove reply by id.
        /// </summary>
        /// <param name="id">Id.</param>
        public void RemoveReply(Guid id)
        {
            _internalData.RemoveReply(id);
        }

        /// <summary>
        /// Get reply by id.
        /// </summary>
        /// <param name="id">Reply's id.</param>
        /// <returns>Internal reply data if key is valid, null if key is invalid.</returns>
        /// <exception cref="InvalidReplyIDException">Invalid reply id.</exception>
        public InternalReplyData GetReplyData(Guid id)
        {
            return _internalData.GetReplyData(id);
        }

        /// <summary>
        /// Update reply field.
        /// </summary>
        /// <param name="id">Reply's id.</param>
        /// <param name="field">Reply's field.</param>
        /// <param name="value">Field's new value.</param>
        /// <exception cref="InvalidReplyIDException">Invalid reply id.</exception>
        /// <exception cref="InvalidFieldException">Passed invalid field.</exception>
        public void UpdateField(Guid id, ReplyField field, object value)
        {
            _internalData.UpdateField(id, field, value);
        }

        /// <summary>
        /// Add link between two ids. Data is added to Reply with ID=id and then its link changed accordingly.
        /// </summary>
        /// <param name="id">Reply to which the link is being added to.</param>
        /// <param name="linkType">The type of the link.</param>
        /// <param name="link">The link's parameter.</param>
        /// <exception cref="InvalidReplyIDException">Invalid reply id.</exception>
        /// <exception cref="InvalidFieldException">Passed invalid field.</exception>
        /// <example>Passing (id1, child, id2) means that id2 is id1's child and id1 is id2's parent.</example>
        public void AddLink(Guid id, ReplyField linkType, Guid link)
        {
            _internalData.AddLink(id, linkType, link);
        }

        /// <summary>
        /// Remove link between two ids.
        /// </summary>
        /// <param name="id">Reply from which the link is being removed from.</param>
        /// <param name="linkType">The type of the link.</param>
        /// <param name="link">The link's parameter.</param>
        /// <exception cref="InvalidReplyIDException">Invalid reply id.</exception>
        /// <exception cref="InvalidFieldException">Passed invalid field.</exception>
        /// <example>Remove linkType (parent/child) with ID=link from ID=id reply.</example>
        public void RemoveLink(Guid id, ReplyField linkType, Guid link)
        {
            _internalData.RemoveLink(id, linkType, link);
        }

        /// <summary>
        /// Get parents by reply id.
        /// </summary>
        /// <param name="id">Reply's id.</param>
        /// <exception cref="InvalidReplyIDException">Invalid reply id.</exception>
        /// <returns>List of parents. Throws exceptions accordingly.</returns>
        public List<Guid> GetParents(Guid id)
        {
            return _internalData.GetParents(id);
        }

        /// <summary>
        /// Get children by reply id.
        /// </summary>
        /// <param name="id">Reply's id.</param>
        /// <exception cref="InvalidReplyIDException">Invalid reply id.</exception>
        /// <returns>List of children. Throws exceptions accordingly.</returns>
        public List<Guid> GetChildren(Guid id)
        {
            return _internalData.GetChildren(id);
        }

        /// <summary>
        /// Get field by reply id and field name.
        /// </summary>
        /// <param name="id">Reply's id.</param>
        /// <param name="field">Reply's field enumeration.</param>
        /// <exception cref="InvalidReplyIDException">Invalid reply id.</exception>
        /// <exception cref="InvalidFieldException">Passed invalid field.</exception>
        /// <returns>Field data. Throws exceptions accordingly.</returns>
        public object GetField(Guid id, ReplyField field)
        {
            return _internalData.GetField(id, field);
        }

        /// <summary>
        /// Get count for reply depending on id and field type.
        /// </summary>
        /// <param name="id">Reply id.</param>
        /// <param name="field">Reply field.</param>
        /// <exception cref="InvalidReplyIDException">Invalid reply id.</exception>
        /// <exception cref="InvalidFieldException">Passed invalid field.</exception>
        /// <returns>Number of items based on field type. Throws exceptions accordingly.</returns>
        public int GetCount(Guid id, ReplyField field)
        {
            return _internalData.GetCount(id, field);
        }

        #endregion

        #region Data import and export

        /// <summary>
        /// Serialize database by database to the given path.
        /// </summary>
        /// <param name="database">External database to serialize.</param>
        /// <param name="path">Path to serialize the database to.</param>
        /// <param name="format">Serializing format.</param>
        /// <exception cref="DataSerializationException">Exception occured on serializing data.</exception>
        public static void Serialize(ExternalDatabase database, string path, ExternalFormat format)
        {
            try
            {
                switch (format)
                {
                    case ExternalFormat.BinaryFormat:
                        {
                            Stream stream = File.Open(path, FileMode.Create);
                            BinaryFormatter bFormatter = new BinaryFormatter();
                            bFormatter.Serialize(stream, database);
                            stream.Close();
                            break;
                        }
                    case ExternalFormat.XMLFormat:
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(ExternalDatabase));
                            FileStream writer = new FileStream(path, FileMode.Create);
                            if (writer.CanWrite)
                            {
                                serializer.Serialize(writer, database);
                                writer.Close();
                            }
                            break;
                        }
                    default:
                        {
                            throw new InvalidExternalFormatException();
                        }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.StackTrace);
                throw new DataSerializationException();
            }
        }

        /// <summary>
        /// Deserialize database from given path.
        /// </summary>
        /// <param name="path">Path from which to deserialize data.</param>
        /// <param name="format">Deserializing format.</param>
        /// <returns>Deserialized data.</returns>
        /// <exception cref="DataDeserializationException">Exception occured on deserializing data.</exception>
        /// <exception cref="InvalidPathException">Exception occured on the given path.</exception>
        public static ExternalDatabase Deserialize(string path, ExternalFormat format)
        {
            ExternalDatabase database;

            try
            {
                if (File.Exists(path))
                {
                    switch (format)
                    {
                        case ExternalFormat.BinaryFormat:
                            {
                                Stream stream = File.Open(path, FileMode.Open);
                                BinaryFormatter bFormatter = new BinaryFormatter();
                                database = (ExternalDatabase)bFormatter.Deserialize(stream);
                                stream.Close();
                                break;
                            }
                        case ExternalFormat.XMLFormat:
                            {
                                XmlSerializer serializer = new XmlSerializer(typeof(ExternalDatabase));
                                FileStream reader = new FileStream(path, FileMode.Open);
                                database = (ExternalDatabase)serializer.Deserialize(reader);
                                reader.Close();
                                break;
                            }
                        default:
                            {
                                throw new InvalidExternalFormatException();
                            }
                    }

                    return database;
                }

                else
                {
                    throw new InvalidPathException();
                }
            }
            catch
            {
                throw new DataDeserializationException();
            }
        }

        #endregion

        #region GUI

        /// <summary>
        /// Populate ListViewItem with reply information.
        /// </summary>
        /// <param name="id">Reply's ID.</param>
        /// <exception cref="InvalidReplyIDException">Invalid reply id.</exception>
        /// <returns>populated ListViewItem.</returns>
        public ListViewItem PopulateItem(Guid id)
        {
            InternalReplyData data = GetReplyData(id);
            ListViewItem item = new ListViewItem(data.Timestamp.ToString());

            item.SubItems.Add(data.Author);
            item.SubItems.Add(data.Text.Replace('\n', ' '));
            item.SubItems.Add(data.ChildCount.ToString());
            item.SubItems.Add(data.ParentCount.ToString());
            item.Tag = id;

            return item;
        }

        #endregion

        #endregion
    }
}
