using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Util;
using Parser;

namespace Framework.Data.Conversations
{
    /// <summary>
    /// InternalDatabase class.
    /// </summary>
    public class InternalDatabase
    {
        #region Members

        /// <summary>
        /// All replies stored as a dictionary.
        /// </summary>
        private Dictionary<Guid, InternalReply> _hashedReplies;

        /// <summary>
        /// Data changed flag.
        /// </summary>
        private bool _dataChanged;

        #region Sorted lists

        /// <summary>
        /// Replies sorted according to their timestamps as a list of IDs.
        /// </summary>
        private List<Guid> _byTimestamp;

        #endregion

        /// <summary>
        /// All replies stored as a list.
        /// </summary>
        private List<InternalReply> _replies;

        private List<Guid> _usedIds;

        #endregion

        #region Properties

        /// <summary>
        /// Get list of replies ordered by timestamp.
        /// </summary>
        public List<Guid> RepliesByTimestamp
        {
            get
            {
                if (_dataChanged)
                {
                    // Rebuild list of replies by timestamp
                    RebuildSortedLists();

                    // Reset flag
                    _dataChanged = false;
                }

                return _byTimestamp;
            }
        }

        /// <summary>
        /// Get list of replies.
        /// </summary>
        public List<InternalReply> Replies
        {
            get
            {
                if (_dataChanged)
                {
                    // Rebuild list of replies
                    _replies = _hashedReplies.Values.ToList();

                    // Reset flag
                    _dataChanged = false;
                }

                return _replies;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Guid> UsedIds
        {
            get { return _usedIds; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public InternalDatabase()
        {
            _hashedReplies = new Dictionary<Guid, InternalReply>();
            _byTimestamp = new List<Guid>();
            _dataChanged = true;
            _usedIds = new List<Guid>();
        }

        /// <summary>
        /// Default constructor by external database.
        /// </summary>
        /// <param name="externalDatabase">External representation of database.</param>
        public InternalDatabase(ExternalDatabase externalDatabase)
        {
            _hashedReplies = new Dictionary<Guid, InternalReply>();
            _byTimestamp = new List<Guid>();
            _usedIds = new List<Guid>();
            foreach (ExternalReply externalReply in externalDatabase.Replies)
            {
                InternalReply internalReply = externalReply.InternalRepresentation;

                _hashedReplies.Add(internalReply.Id, internalReply);

                if (_usedIds.Contains(internalReply.Id) == false)
                {
                    _usedIds.Add(internalReply.Id);
                }

                foreach (Guid id in internalReply.Children)
                {
                    if (_usedIds.Contains(id) == false)
                    {
                        _usedIds.Add(id);
                    }
                }

                foreach (Guid id in internalReply.Parents)
                {
                    if (_usedIds.Contains(id) == false)
                    {
                        _usedIds.Add(id);
                    }
                }
            }
            _dataChanged = true;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Generate new key for adding to dictionary.
        /// </summary>
        /// <returns>Generated key.</returns>
        private Guid GenerateGuid()
        {
            Guid key = Guid.NewGuid();

            while (_hashedReplies.ContainsKey(key))
            {
                key = Guid.NewGuid();
            }

            return key;
        }

        /// <summary>
        /// Rebuild sorted lists.
        /// </summary>
        private void RebuildSortedLists()
        {
            throw new Exception("Not implemented yet.");
        }

        /// <summary>
        /// Remove all associations of given id.
        /// </summary>
        /// <param name="id">Id.</param>
        private void CleanAssociations(Guid id)
        {
            // Loop replies
            foreach (InternalReply reply in _hashedReplies.Values)
            {
                // remove parents and children
                reply.RemoveParent(id);
                reply.RemoveChild(id);
            }
        }

        /// <summary>
        /// Get reply by id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Internal representation of reply.</returns>
        /// <exception cref="InvalidReplyIDException">Invalid reply id.</exception>
        private InternalReply GetReply(Guid id)
        {
            InternalReply reply = _hashedReplies[id];

            if (reply == null)
            {
                throw new InvalidReplyIDException();
            }

            return reply;
        }

        /// <summary>
        /// Add reply by data.
        /// </summary>
        /// <param name="data">Reply data.</param>
        /// <returns>Guid generated for given reply.</returns>
        public Guid AddReply(InternalReplyData data)
        {
            // Generate Guid
            Guid id = GenerateGuid();

            // Create reply
            InternalReply reply = new InternalReply(id, data);

            // Add reply to hash and set data changed flag
            _dataChanged = true;
            _hashedReplies.Add(id, reply);

            _usedIds.Add(id);

            // Return reply's id
            return id;
        }

        /// <summary>
        /// Remove reply by id.
        /// </summary>
        /// <param name="id">Id.</param>
        public void RemoveReply(Guid id)
        {
            _dataChanged = true;

            if (_hashedReplies.ContainsKey(id))
            {
                _hashedReplies.Remove(id);
            }

            // Clean all parents and children references.
            CleanAssociations(id);

            _usedIds.Remove(id);
        }

        /// <summary>
        /// Get reply by id.
        /// </summary>
        /// <param name="id">Reply's id.</param>
        /// <returns>Internal reply data if key is valid, null if key is invalid.</returns>
        /// <exception cref="InvalidReplyIDException">Invalid reply id.</exception>
        public InternalReplyData GetReplyData(Guid id)
        {
            InternalReply reply = GetReply(id);

            return reply.Data;
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
            InternalReply reply = GetReply(id);

            switch (field)
            {
                case ReplyField.Timestamp:
                    {
                        reply.Timestamp = (DateTime)value;
                        break;
                    }
                case ReplyField.Author:
                    {
                        reply.Author = (string)value;
                        break;
                    }
                case ReplyField.Text:
                    {
                        reply.Text = (string)value;
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }

            _dataChanged = true;
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
            InternalReply reply = GetReply(id);
            InternalReply linkedReply = GetReply(link);

            switch (linkType)
            {
                case ReplyField.Child:
                    {
                        reply.AddChild(link);
                        linkedReply.AddParent(id);
                        break;
                    }
                case ReplyField.Parent:
                    {
                        reply.AddParent(link);
                        linkedReply.AddChild(id);
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }

            _dataChanged = true;
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
            InternalReply reply = GetReply(id);
            InternalReply linkedReply = GetReply(link);

            switch (linkType)
            {
                case ReplyField.Child:
                    {
                        reply.RemoveChild(link);
                        linkedReply.RemoveParent(id);
                        break;
                    }
                case ReplyField.Parent:
                    {
                        reply.RemoveParent(link);
                        linkedReply.RemoveChild(id);
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }

            _dataChanged = true;
        }

        /// <summary>
        /// Get parents by reply id.
        /// </summary>
        /// <param name="id">Reply's id.</param>
        /// <exception cref="InvalidReplyIDException">Invalid reply id.</exception>
        /// <returns>List of parents. Throws exceptions accordingly.</returns>
        public List<Guid> GetParents(Guid id)
        {
            InternalReply reply = GetReply(id);

            return reply.Parents;
        }

        /// <summary>
        /// Get children by reply id.
        /// </summary>
        /// <param name="id">Reply's id.</param>
        /// <exception cref="InvalidReplyIDException">Invalid reply id.</exception>
        /// <returns>List of children. Throws exceptions accordingly.</returns>
        public List<Guid> GetChildren(Guid id)
        {
            InternalReply reply = GetReply(id);

            return reply.Children;
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
            InternalReply reply = GetReply(id);

            switch (field)
            {
                case ReplyField.Timestamp:
                    {
                        return reply.Timestamp;
                    }
                case ReplyField.Author:
                    {
                        return reply.Author;
                    }
                case ReplyField.Text:
                    {
                        return reply.Text;
                    }
                case ReplyField.Child:
                    {
                        return reply.Children;
                    }
                case ReplyField.Parent:
                    {
                        return reply.Parents;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
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
            InternalReply reply = GetReply(id);

            switch (field)
            {
                case ReplyField.Child:
                    {
                        return reply.ChildCount;
                    }
                case ReplyField.Parent:
                    {
                        return reply.ParentCount;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="parsedReplies"></param>
        public void ImportDataFromListOfParsedReplies(List<ParsedReply> parsedReplies)
        {
           foreach (ParsedReply parsedReply in parsedReplies)
           {
              try
              {
                 InternalReplyData internalReplyData = new InternalReplyData(parsedReply.Timestamp,
                                                                             parsedReply.Author,
                                                                             parsedReply.Text);

                 foreach (Guid child in parsedReply.Children)
                 {
                    internalReplyData.AddChild(child);
                 }

                 foreach (Guid parent in parsedReply.Parents)
                 {
                    internalReplyData.AddParent(parent);
                 }

                 InternalReply internalReply = new InternalReply(parsedReply.Id, internalReplyData);

                 _hashedReplies.Add(parsedReply.Id, internalReply);

                 _usedIds.Add(parsedReply.Id);
                 _usedIds.AddRange(parsedReply.Children);
                 _usedIds.AddRange(parsedReply.Parents);

              }
              catch (Exception)
              {
                 Console.Out.WriteLine("Ignoring reply " + parsedReply);
              }
           }

           _dataChanged = true;
        }

        #endregion
    }
}
