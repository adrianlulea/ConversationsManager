using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Parser
{
   /// <summary>
   /// Parser loader singleton
   /// </summary>
   public static class ParserLoader
   {
      #region Static Members

      /// <summary>
      /// Last loaded library
      /// </summary>
      private static string lastLoadedLibrary = "";

      /// <summary>
      /// List of available parsers from the last loaded library or current library
      /// </summary>
      private static List<object> availableParsers = new List<object>();

      /// <summary>
      /// Parser's interface name
      /// </summary>
      private static string parserInterfaceName = "Parser.IConversationParser";

      #endregion

      #region Static Methods

      /// <summary>
      /// Get parser from the available parsers loaded from the current library by name
      /// </summary>
      /// <param name="parserName">Parser's name</param>
      /// <returns>IConversationParser or null if parser is not in the library's available parsers</returns>
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
      /// Load parser from library by name
      /// </summary>
      /// <param name="libraryPath">Library containing the parser</param>
      /// <param name="parserName">Parser's name</param>
      /// <returns>IConversationParser or null if the parser does not exist</returns>
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
               if (type.GetInterface(parserInterfaceName) != null)
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

      /// <summary>
      /// 
      /// </summary>
      /// <param name="libraryPath"></param>
      /// <returns></returns>
      public static List<string> ListParsers(string libraryPath)
      {
         List<string> parsers = new List<string>();

         if (File.Exists(libraryPath))
         {
            Assembly importLibraryAssembly = Assembly.LoadFrom(libraryPath);
            Type[] importLibraryTypes = importLibraryAssembly.GetExportedTypes();

            foreach (Type type in importLibraryTypes)
            {
               if (type.GetInterface(parserInterfaceName) != null)
               {
                  parsers.Add(type.Name);
               }
            }
         }

         return parsers;
      }

      #endregion
   }
}
