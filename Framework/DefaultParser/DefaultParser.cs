using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser;
using System.Xml;
using System.IO;

namespace DefaultParser
{
    public class DefaultParser : IConversationParser
    {
        #region Members

        private Dictionary<int, Guid> _identificators;
        private Dictionary<Guid, List<Guid>> _children;
        private Dictionary<Guid, List<Guid>> _parents;
        private List<Guid> _existingIds;

        #endregion

        #region Constructors

        public DefaultParser()
        {
            this._identificators = new Dictionary<int, Guid>();
            this._children = new Dictionary<Guid, List<Guid>>();
            this._parents = new Dictionary<Guid, List<Guid>>();
            this._existingIds = new List<Guid>();
        }

        #endregion

        #region Methods

        private Guid GetNewId()
        {
            Guid id = Guid.NewGuid();

            while (this._existingIds.Contains(id))
            {
                id = Guid.NewGuid();
            }

            this._existingIds.Add(id);

            return id;
        }

        #region IConversationParser implementation

        public bool ExpectedFormat(string parsedFile)
        {
            bool expectedFormat = true;



            return expectedFormat;
        }

        public List<ParsedReply> ParseConversation(string parsedFile, List<Guid> existingIDs)
        {
            this._existingIds.AddRange( existingIDs );
            List<ParsedReply> parsedConversation = new List<ParsedReply>();

            XmlDocument document = new XmlDocument();
            XmlNodeList nodeList;

            FileStream fs = new FileStream(parsedFile, FileMode.Open, FileAccess.Read);
            document.Load(fs);

            nodeList = document.GetElementsByTagName("Turn");

            string author = "";
            string genidAttribute, refAttribute, timeAttribute, text = "";
            int id;
            bool newId;
            Guid internalId = Guid.Empty;
            Guid parentId = Guid.Empty;
            DateTime time = DateTime.Now;
            ParsedReply parsedReply = null;
            List<Guid> parents, children;

            for (int i = 0; i < nodeList.Count; i++)
            {
                XmlNode turn = nodeList[i];

                // Author
                author = turn.Attributes["nickname"].Value;

                // Text, ID, Parent ID, Timestamp
                XmlNode utterance = turn.FirstChild;
                genidAttribute = utterance.Attributes["genid"].Value;
                refAttribute = utterance.Attributes["ref"].Value;
                timeAttribute = utterance.Attributes["time"].Value;

                // Text
                text = utterance.InnerText;

                // Time
                time = DateTime.ParseExact(timeAttribute, "HH:mm:ss", null);

                // Id
                id = int.Parse(genidAttribute);
                newId = (_identificators.ContainsKey(id) == false);
                internalId = (newId) ? GetNewId() : _identificators[id];

                if (newId)
                {
                    _identificators.Add(id, internalId);
                }

                // Ref
                id = 0;
                int.TryParse(refAttribute, out id);

                parentId = (id == 0) ? Guid.Empty : _identificators[id];
                /* Should not add as parent ids are from the past and have been added already
                if (parentId != Guid.Empty)
                {
                    _identificators.Add(id, parentId);
                }*/

                // Update Children and Parents
                if (parentId != Guid.Empty)
                {
                    parents = (_parents.ContainsKey(internalId)) ? _parents[internalId] : new List<Guid>();


                    parents.Add(parentId);
                    _parents[internalId] = parents;

                    children = (_children.ContainsKey(parentId)) ? _children[parentId] : new List<Guid>();

                    children.Add(internalId);
                    _children[parentId] = children;
                }

                // Populate data partially
                parsedReply = new ParsedReply(author, text, time, internalId);
                parsedConversation.Add(parsedReply);
            }

            // Link children and parents
            foreach (ParsedReply reply in parsedConversation)
            {
                children = (_children.ContainsKey(reply.Id)) ? _children[reply.Id] : new List<Guid>();
                parents = (_parents.ContainsKey(reply.Id)) ? _parents[reply.Id] : new List<Guid>();

                foreach (Guid child in children)
                {
                    reply.AddChild(child);
                }

                foreach (Guid parent in parents)
                {
                    reply.AddParent(parent);
                }

                reply.SealData();
            }

            return parsedConversation;
        }

        #endregion

        #endregion
    }
}
