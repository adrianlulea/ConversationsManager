using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LayoutCustomAlgorithm;
using System.IO;
using Framework.Util;

namespace Framework.GUI.Controls.Conversations
{
   /// <summary>
   /// 
   /// </summary>
   public partial class LayoutAlgorithmsControl : UserControl
   {
      #region Members

      private string _algorithmsPath;

      #endregion

      #region Properties

      /// <summary>
      /// 
      /// </summary>
      public List<ListViewItem> Algorithms
      {
         get
         {
            List<ListViewItem> algorithms = new List<ListViewItem>();

            foreach (ListViewItem algorithm in algorithmListView.Items)
            {
               ListViewItem item = new ListViewItem(algorithm.Text);
               item.SubItems.Add(algorithm.SubItems[1]);

               algorithms.Add(item);
            }

            return algorithms;
         }
      }

      #endregion

      #region Constructors 

      /// <summary>
      /// 
      /// </summary>
      /// <param name="algorithmsPath"></param>
      public LayoutAlgorithmsControl(string algorithmsPath)
      {
         this._algorithmsPath = algorithmsPath;
         InitializeComponent();
         InitializeAlgorithms();
      }

      #endregion

      #region Events

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      public delegate void LayoutAlgorithmSelected(object sender, SelectedAlgorithmEventArgs e);

      /// <summary>
      /// 
      /// </summary>
      public event LayoutAlgorithmSelected OnLayoutAlgorithmSelected;

      #endregion

      #region Event Handlers

      private void addAlgorithmButton_Click(object sender, EventArgs e)
      {
         if (browseAlgorithmLibrary.ShowDialog() == DialogResult.OK)
         {
            string libraryPath = browseAlgorithmLibrary.FileName;

            // Copy library to algorithms path
            FileInfo fi = new FileInfo(libraryPath);
            string algorithmsPath = Directory.GetCurrentDirectory() + "\\" + this._algorithmsPath;
            string newLibraryPath = algorithmsPath + "\\" + fi.Name;
            bool overwriteLibrary = false; //overwriting will generate a nasty exception as the libraries are loaded at runtime

            if (Directory.Exists(algorithmsPath) == false)
            {
               Directory.CreateDirectory(algorithmsPath);
            }

            if (File.Exists(newLibraryPath))
            {
               // Library already loaded
               return;
            }

            File.Copy(libraryPath, newLibraryPath, overwriteLibrary);

            InitializeAlgorithms();
         }
      }

      private void algorithmListView_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (OnLayoutAlgorithmSelected != null)
         {
            string algorithmName = "";
            string libraryName = "";
            bool valid = false;

            if (algorithmListView.SelectedItems.Count > 0)
            {
               ListViewItem selectedItem = algorithmListView.SelectedItems[0];

               algorithmName = selectedItem.SubItems[0].Text;
               libraryName = selectedItem.SubItems[1].Text;

               valid = true;
            }

            SelectedAlgorithmEventArgs args = new SelectedAlgorithmEventArgs(algorithmName, libraryName, valid);

            OnLayoutAlgorithmSelected(this, args);
         }
      }

      #endregion

      #region Methods

      /// <summary>
      /// 
      /// </summary>
      public void InitializeAlgorithms()
      {
         this.algorithmListView.Items.Clear();

         Dictionary<string, List<string>> libraryAlgorithmsHash = AlgorithmLoader.ListAlgorithmsFromDirectory(_algorithmsPath);

         foreach (string library in libraryAlgorithmsHash.Keys)
         {
            List<string> algorithms = libraryAlgorithmsHash[library];

            foreach (string algorithm in algorithms)
            {
               ListViewItem a = new ListViewItem(algorithm);
               a.SubItems.Add(library);

               this.algorithmListView.Items.Add(a);
            }
         }
      }

      #endregion

   }
}
