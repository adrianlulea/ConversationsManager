using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Collections;

namespace LayoutCustomAlgorithm
{
   /// <summary>
   /// Algorithm loader singleton
   /// </summary>
    public static class AlgorithmLoader
    {
       #region Static Memebers

       /// <summary>
       /// Last loaded library
       /// </summary>
       private static string lastLoadedLibrary = "";

       /// <summary>
       /// List of available algorithms from the last loaded library or current library
       /// </summary>
       private static List<object> availableAlgorithms = new List<object>();

       /// <summary>
       /// Algorithm's interface name
       /// </summary>
       private static string algorithmInterfaceName = "LayoutCustomAlgorithm.ILayoutAlgorithm";

       #endregion

       #region Static Members

       /// <summary>
       /// 
       /// </summary>
       /// <param name="algorithmName"></param>
       /// <returns></returns>
       private static ILayoutAlgorithm GetAlgorithm(string algorithmName)
       {
          ILayoutAlgorithm algorithm = null;

          foreach (var a in availableAlgorithms)
          {
             if (a.GetType().Name == algorithmName)
             {
                algorithm = (ILayoutAlgorithm)a;
                break;
             }
          }

          return algorithm;
       }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="libraryPath"></param>
       /// <param name="algorithmName"></param>
       /// <returns></returns>
       public static ILayoutAlgorithm LoadAlgorithm(string libraryPath, string algorithmName)       
       {
          if (lastLoadedLibrary != "")
          {
             return GetAlgorithm(algorithmName);
          }
          else
          {
             lastLoadedLibrary = libraryPath;
             availableAlgorithms.Clear();
          }

          if (File.Exists(libraryPath))
          {
             // Load assembly
             Assembly importLibraryAssembly = Assembly.LoadFrom(libraryPath);
             Type[] importLibraryTypes = importLibraryAssembly.GetExportedTypes();

             // Get instances of interest
             foreach (Type type in importLibraryTypes)
             {
                if (type.GetInterface(algorithmInterfaceName) != null)
                {
                   object obj = Activator.CreateInstance(type);

                   if (obj != null)
                   {
                      availableAlgorithms.Add(obj);
                   }
                }
             }
          }

          return GetAlgorithm(algorithmName);
       }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="libraryPath"></param>
       /// <returns></returns>
       public static List<string> ListAlgorithms(string libraryPath)
       {
          List<string> algorithms = new List<string>();

          if (File.Exists(libraryPath))
          {
             Assembly importLibraryAssembly = Assembly.LoadFrom(libraryPath);
             Type[] importLibraryTypes = importLibraryAssembly.GetExportedTypes();

             foreach (Type type in importLibraryTypes)
             {
                if (type.GetInterface(algorithmInterfaceName) != null)
                {
                   algorithms.Add(type.Name);
                }
             }
          }

          return algorithms;
       }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="algorithmsPath"></param>
       /// <returns></returns>
       public static Dictionary<string, List<string>> ListAlgorithmsFromDirectory(string algorithmsPath)
       {
          Dictionary<string, List<string>> libraryAlgorithmsHash = new Dictionary<string, List<string>>();

          if (Directory.Exists(algorithmsPath))
          {
             string[] algorithmsLibraries = Directory.GetFiles(algorithmsPath, "*.dll");

             foreach (string library in algorithmsLibraries)
             {
                FileInfo fi = new FileInfo(library);
                List<string> algorithms = new List<string>();

                algorithms = AlgorithmLoader.ListAlgorithms(library);

                libraryAlgorithmsHash.Add(fi.Name, algorithms);
             }
          }

          return libraryAlgorithmsHash;
       }

       #endregion
    }
}
