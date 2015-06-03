using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser;

namespace DefaultParser
{
    public class OtherParser : IConversationParser
    {
        #region IConversationParser implementation

        public bool ExpectedFormat(string parsedFile)
        {
            bool expectedFormat = true;



            return expectedFormat;
        }

        public List<ParsedReply> ParseConversation(string parsedFile, List<Guid> existingIDs)
        {
            List<ParsedReply> parsedConversation = new List<ParsedReply>();

            ParsedReply testReply = new ParsedReply("author2", "text2", DateTime.Now, Guid.Empty);
            testReply.AddChild(Guid.Empty);
            testReply.AddChild(Guid.Empty);
            testReply.AddChild(Guid.Empty);

            testReply.AddParent(Guid.Empty);
            testReply.AddParent(Guid.Empty);
            testReply.AddParent(Guid.Empty);

            testReply.SealData();

            parsedConversation.Add(testReply);

            return parsedConversation;
        }

        #endregion
    }
}
