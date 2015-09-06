using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Framework.Util;
using Framework.GUI.Forms.Conversations;

namespace Framework.Data.Conversations
{
    /// <summary>
    /// PreferencesManager class.
    /// </summary>
    public class PreferencesManager
    {
        #region Members

        /// <summary>
        /// Default location for preferences file.
        /// </summary>
        public const string PATH = "\\preferences.xml";

        /// <summary>
        /// Prefereces data.
        /// </summary>
        private PreferencesData _data;

        /// <summary>
        /// Default path location.
        /// </summary>
        private string _defaultPath;

        #endregion

        #region Properties

        /// <summary>
        /// Get preferences.
        /// </summary>
        public PreferencesData Data
        {
            get { return _data; }
        }

        /// <summary>
        /// Get ExternalFormat.
        /// </summary>
        public ExternalFormat Format
        {
            get { return (_data.BinaryFormat) ? ExternalFormat.BinaryFormat : ExternalFormat.XMLFormat; }
        }

        /// <summary>
        /// Get extension for current format.
        /// </summary>
        public string Extension
        {
            get { return PreferencesManager.GetExtension(this.Format); }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default PreferencesManager constructor.
        /// </summary>
        public PreferencesManager()
        {
            _data = new PreferencesData();
            _defaultPath = Directory.GetCurrentDirectory() + PATH;

            if (File.Exists(_defaultPath))
            {
                Load();
            }
            else
            {
                Save();
            }
        }

        /// <summary>
        /// PreferencesManager constructor by path
        /// </summary>
        /// <param name="path">Path to save preferences.xml file.</param>
        public PreferencesManager(string path)
        {
            _defaultPath = path;
            Load(_defaultPath);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Load preferences from path.
        /// </summary>
        /// <param name="path">Path to load the preferences from.</param>
        /// <exception cref="DataDeserializationException">Data could not be deserialized from given path.</exception>
        /// <returns>PreferencesData</returns>
        private static PreferencesData LoadPreferences(string path)
        {
            PreferencesData data;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PreferencesData));
                FileStream reader = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);

                data = (PreferencesData)serializer.Deserialize(reader);
                reader.Close();

                return data;
            }

            catch
            {
                throw new DataDeserializationException();
            }
        }

        /// <summary>
        /// Save preferences to given path.
        /// </summary>
        /// <param name="data">PreferencesData to save.</param>
        /// <param name="path">Location to save the PreferencesData to.</param>
        /// <exception cref="DataSerializationException">Data could not be serialized to the given path.</exception>
        private static void SavePreferences(PreferencesData data, string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PreferencesData));
                FileStream writer = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);

                if (writer.CanWrite)
                {
                    serializer.Serialize(writer, data);
                }

                writer.Close();
            }

            catch
            {
                throw new DataSerializationException();
            }
        }

        /// <summary>
        /// Get format from given path.
        /// </summary>
        /// <param name="path">Path.</param>
        /// <exception cref="InvalidPathException">Given path does not have an extension at the end.</exception>
        /// <returns>ExternalFormat</returns>
        public static ExternalFormat GetFormat(string path)
        {
            if (path.IndexOf(".dat") != -1)
            {
                return ExternalFormat.BinaryFormat;
            }

            if (path.IndexOf(".xml") != -1)
            {
                return ExternalFormat.XMLFormat;
            }

            throw new InvalidPathException();
        }

        /// <summary>
        /// Get format as text from given ExternalFormat.
        /// </summary>
        /// <param name="format">ExternalFormat.</param>
        /// <exception cref="InvalidExternalFormatException">ExternalFormat is invalid.</exception>
        /// <returns>Format as text</returns>
        public static string GetExtension(ExternalFormat format)
        {
            switch (format)
            {
                case ExternalFormat.BinaryFormat:
                    {
                        return ".dat";
                    }
                case ExternalFormat.XMLFormat:
                    {
                        return ".xml";
                    }
                default:
                    {
                        throw new InvalidExternalFormatException();
                    }
            }
        }

        /// <summary>
        /// Save preferences to given path.
        /// </summary>
        /// <param name="path">Path to save the preferences to.</param>
        /// <exception cref="DataSerializationException">Data could not be serialized to the given path.</exception>
        public void Save(string path)
        {
           ConversationsManager.PreferencesData = _data;
            PreferencesManager.SavePreferences(this.Data, path);
        }

        /// <summary>
        /// Load preferences from given path.
        /// </summary>
        /// <param name="path">Path to load preferences from.</param>
        /// <exception cref="DataDeserializationException">Data could not be deserialized from given path.</exception>
        public void Load(string path)
        {
            _data = PreferencesManager.LoadPreferences(path);
            ConversationsManager.PreferencesData = _data;
        }

        /// <summary>
        /// Save preferences to default path.
        /// </summary>
        /// <exception cref="DataSerializationException">Data could not be serialized to the given path.</exception>
        public void Save()
        {
            Save(_defaultPath);
        }

        /// <summary>
        /// Load preferences from default path.
        /// </summary>
        /// <exception cref="DataDeserializationException">Data could not be deserialized from given path.</exception>
        public void Load()
        {
            Load(_defaultPath);
        }

        #endregion
    }
}
