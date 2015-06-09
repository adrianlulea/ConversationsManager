using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using Framework.Util;

namespace Framework.Language
{
   /// <summary>
   /// LanguageManager static singleton
   /// </summary>
   public static class LanguageManager
   {
      #region Static Members

      /// <summary>
      /// Dictionary of tag and list of controls subscribed under given tag.
      /// </summary>
      private static Dictionary<string, List<Control>> __subscribedControls = new Dictionary<string,List<Control>>();

      /// <summary>
      /// Dictionary of tag and languageValue for given tag.
      /// </summary>
      private static Dictionary<string, string> __languageValues = new Dictionary<string, string>();

      /// <summary>
      /// Path of last loaded language.
      /// </summary>
      private static string __lastLoadedLanguagePath = "";

      /// <summary>
      /// Last loaded language.
      /// </summary>
      private static Language __lastLoadedLangauge = null;

      #endregion

      #region Static Properties

      /// <summary>
      /// Gets current langauge.
      /// </summary>
      public static Language CurrentLanguage
      {
         get { return __lastLoadedLangauge; }
      }

      /// <summary>
      /// Gets current langauge path.
      /// </summary>
      public static string CurrentLanguagePath
      {
         get { return __lastLoadedLanguagePath; }
      }

      #endregion

      #region Static Methods

      /// <summary>
      /// Subscribe control with given tag to receive updates when language has changed.
      /// </summary>
      /// <param name="control">Control to receive updates.</param>
      /// <param name="tag">Tag under which control gets its text.</param>
      public static void SubscribeControl(Control control, string tag)
      {
         List<Control> controlsUnderGiveTag = new List<Control>();
         bool tagExists = __subscribedControls.ContainsKey(tag);

         if (tagExists)
         {
            controlsUnderGiveTag = __subscribedControls[tag];
         }

         controlsUnderGiveTag.Add(control);

         __subscribedControls[tag] = controlsUnderGiveTag;
      }

      /// <summary>
      /// Unsubscribe control with give tag to stop receiving updates when language has changed.
      /// </summary>
      /// <param name="control">Control to stop receiving updates.</param>
      /// <param name="tag">Tag under which control was getting its text.</param>
      public static void UnsubscribeControl(Control control, string tag)
      {
         List<Control> controlsUnderGivenTag = __subscribedControls[tag];

         if (controlsUnderGivenTag != null && 
             controlsUnderGivenTag.Count > 0)
         {
            controlsUnderGivenTag.Remove(control);
         }
      }

      /// <summary>
      /// Update new language values
      /// </summary>
      /// <param name="newLanguageValues">Dictionary of pairs [tag, languageValue]</param>
      private static void UpdateNewLanguage(Dictionary<string, string> newLanguageValues)
      {
         __languageValues.Clear();
         __languageValues = new Dictionary<string, string>(newLanguageValues);

         NotifyControlsOnLanguageChanged();
      }

      /// <summary>
      /// Update all subscribed controls
      /// </summary>
      private static void NotifyControlsOnLanguageChanged()
      {
         foreach (string tag in __languageValues.Keys)
         {
            string languageValue = __languageValues[tag];
            List<Control> controlsSubscribedUnderSameTag = __subscribedControls[tag];

            foreach (Control control in controlsSubscribedUnderSameTag)
            {
               control.Text = languageValue;
            }
         }
      }

      /// <summary>
      /// Load new language from path.
      /// </summary>
      /// <param name="path">Path to load new language from.</param>
      public static void LoadLanguage(string path)
      {
         if (__lastLoadedLanguagePath != path)
         {
            Language language = Deserialize(path);

            Dictionary<string, string> newLanguageValues = new Dictionary<string, string>();

            foreach (LanguageItem languageItem in language.Items)
            {
               string tag = languageItem.Tag;
               string languageValue = languageItem.Value;

               newLanguageValues.Add(tag, languageValue);
            }

            UpdateNewLanguage(newLanguageValues);

            __lastLoadedLanguagePath = path;
            __lastLoadedLangauge = language;
         }
      }

      #region Language save and load

      /// <summary>
      /// Serialize language to path.
      /// </summary>
      /// <param name="language">Language to serialize.</param>
      /// <param name="path">Path to serialize language to.</param>
      public static void Serialize(Language language, string path)
      {
         XmlSerializer serializer = null;
         FileStream writer  = null;

         try
         {
            serializer = new XmlSerializer(typeof(Language));
            writer = new FileStream(path, FileMode.Create);

            if (writer.CanWrite)
            {
               serializer.Serialize(writer, language);
               writer.Close();
            }
         }
         catch (IOException e)
         {
            if (writer != null)
            {
               writer.Close();
            }

            Console.WriteLine(e.StackTrace);
            throw new DataSerializationException();
         }
      }

      /// <summary>
      /// Deserialize language from path.
      /// </summary>
      /// <param name="path">Path to deserialize language from.</param>
      /// <returns>Language if could deserialize</returns>
      /// <exception cref="InvalidPathException">Thrown if give path does not exist or is not a file.</exception>
      /// <exception cref="DataSerializationException">Thrown if there was a problem when deserializing.</exception>
      public static Language Deserialize(string path)
      {
         Language language;
         Stream stream = null;

         try
         {
            if (File.Exists(path))
            {
               XmlSerializer deserializer = new XmlSerializer(typeof(Language));
               stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
               language = (Language)deserializer.Deserialize(stream);
               stream.Close();
            }
            else
            {
               throw new InvalidPathException();
            }
         }
         catch
         {
            if (stream != null)
            {
               stream.Close();
            }

            throw new DataSerializationException();
         }

         return language;
      }

      #endregion

      #endregion
   }
}
