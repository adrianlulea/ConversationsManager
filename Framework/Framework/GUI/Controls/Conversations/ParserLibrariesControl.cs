using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Framework.Data.Conversations;
using Parser;

namespace Framework.GUI.Controls.Conversations
{
   /// <summary>
   /// 
   /// </summary>
   public partial class ParserLibrariesControl : UserControl
   {
      #region Members

      private string _parsersPath;

      #endregion

      #region Properties

      /// <summary>
      /// 
      /// </summary>
      public List<ListViewItem> Parsers
      {
         get
         {
            List<ListViewItem> parsers = new List<ListViewItem>();

            foreach(ListViewItem parser in parserListView.Items)
            {
               ListViewItem item = new ListViewItem(parser.Text);
               item.SubItems.Add(parser.SubItems[1]);

               parsers.Add(item);
            }

            return parsers;
         }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      /// <param name="parsersPath"></param>
      public ParserLibrariesControl(string parsersPath)
      {
         this._parsersPath = parsersPath;
         InitializeComponent();
         InitializeParsers();
      }

      #endregion

      #region Event Handlers

      private void addParserLibraryButton_Click(object sender, EventArgs e)
      {
         if (browseParserLibrary.ShowDialog() == System.Windows.Forms.DialogResult.OK)
         {
            string libraryPath = browseParserLibrary.FileName;

            // Copy library to parsers path
            FileInfo fi = new FileInfo(libraryPath);
            string parsersPath = Directory.GetCurrentDirectory() + "\\" + this._parsersPath;
            string newLibraryPath = parsersPath + "\\" + fi.Name;
            bool overwriteLibrary = false; //overwriting will generate a nasty exception as the libraries are loaded at runtime

            if (Directory.Exists(parsersPath) == false)
            {
               Directory.CreateDirectory(parsersPath);
            }

            if (File.Exists(newLibraryPath))
            {
               // Library already loaded
               return;
            }

            File.Copy(libraryPath, newLibraryPath, overwriteLibrary);

            // Load parsers from library
            LoadParsersFromLibrary(newLibraryPath);
         }
      }

      #endregion

      #region Methods

      /// <summary>
      /// 
      /// </summary>
      /// <param name="library"></param>
      private void LoadParsersFromLibrary(string library)
      {
         /*FileInfo fi = new FileInfo(library);

         if (File.Exists(library))
         {
            List<string> parsers = ParserLoader.ListParsers(library);

            foreach (string parser in parsers)
            {
               ListViewItem p = new ListViewItem(parser);
               p.SubItems.Add(fi.Name);

               this.parserListView.Items.Add(p);
            }
         }*/
      }

      /// <summary>
      /// 
      /// </summary>
      public void InitializeParsers()
      {
         this.parserListView.Items.Clear();

         /*
         if (Directory.Exists(this._parsersPath))
         {
            string[] parserLibraries = Directory.GetFiles(this._parsersPath, "*.dll", SearchOption.TopDirectoryOnly);

            foreach (string library in parserLibraries)
            {
               LoadParsersFromLibrary(library);
            }
         }*/

         Dictionary<string, List<string>> libraryParsersHash = ParserLoader.ListParsersFromDirectory(_parsersPath);

         foreach (string library in libraryParsersHash.Keys)
         {
            List<string> parsers = libraryParsersHash[library];

            foreach (string parser in parsers)
            {
               ListViewItem p = new ListViewItem(parser);
               p.SubItems.Add(library);

               this.parserListView.Items.Add(p);
            }
         }
      }

      #endregion
   }
}
