using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace Framework.Util.Parsing
{
    /// <summary>
    /// 
    /// </summary>
    public static class ParserLoader
    {
        private static string lastLoadedLibrary = "";
        private static List<object> availableParsers = new List<object>();
        private static string parserIName = "Framework.Util.Parsing.IConversationParser";

        private static IConversationParser GetParser(string parserName)
        {
            IConversationParser parser = null;

            foreach (var p in availableParsers)
            {
                if (p.GetType().Name == parserName)
                {
                    parser = (IConversationParser)p;
                    break;
                }
            }

            return parser;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="libraryPath"></param>
        /// <param name="parserName"></param>
        /// <returns></returns>
        public static IConversationParser LoadParser(string libraryPath, string parserName)
        {
            if (lastLoadedLibrary != "")
            {
                return GetParser(parserName);
            }
            else
            {
                lastLoadedLibrary = libraryPath;
                availableParsers.Clear();
            }

            if (File.Exists(libraryPath))
            {
                // Load assembly
                Assembly importLibraryAssembly = Assembly.LoadFrom(libraryPath);
                Type[] importLibraryTypes = importLibraryAssembly.GetExportedTypes();

                // Get instances of interest
                foreach (Type type in importLibraryTypes)
                {
                    if (type.GetInterface(parserIName) != null)
                    {
                        object obj = Activator.CreateInstance(type);

                        if (obj != null)
                        {
                            availableParsers.Add(obj);
                        }
                    }
                }
            }

            return GetParser(parserName);
        }
    }
}
