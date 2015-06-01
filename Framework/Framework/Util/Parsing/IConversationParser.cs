using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util.Parsing
{
    /// <summary>
    /// 
    /// </summary>
    public interface IConversationParser
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parsedFile"></param>
        /// <returns></returns>
        bool ExpectedFormat(string parsedFile);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parsedFile"></param>
        /// <param name="existingIDs"></param>
        /// <returns></returns>
        List<ParsedReply> ParseConversation(string parsedFile, List<Guid> existingIDs);
    }
}
