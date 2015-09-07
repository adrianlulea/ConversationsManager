using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Util;
using Framework.Data.Conversations;
using GraphX.PCL.Common.Enums;
using Framework.GUI.Forms.Conversations;

namespace Framework.GUI.Controls.Conversations
{
   /// <summary>
   /// 
   /// </summary>
   public partial class GraphLayoutAlgorithmsControl : UserControl
   {
      #region Members

      /// <summary>
      /// 
      /// </summary>
      private GraphPreferencesData _graphPreferences;

      /// <summary>
      /// 
      /// </summary>
      private GraphPreferencesData _currentPreferences;

      /// <summary>
      /// 
      /// </summary>
      private LayoutAlgorithmsControl _customLayoutAlgorithmsControl;

      #endregion

      #region Properties

      /// <summary>
      /// 
      /// </summary>
      public GraphPreferencesData GraphPreferences
      {
         get
         {
            return _currentPreferences;
         }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      /// <param name="graphPreferencesData"></param>
      public GraphLayoutAlgorithmsControl(GraphPreferencesData graphPreferencesData)
      {
         _graphPreferences = graphPreferencesData;
         _currentPreferences = new GraphPreferencesData(graphPreferencesData);

         string _layoutAlgorithmsPath = ConversationsManager.PreferencesData.LayoutAlgorithmPath;
         string _overlapAlgorithmsPath = ConversationsManager.PreferencesData.OverlapAlgorithmsPath;

         _customLayoutAlgorithmsControl = new LayoutAlgorithmsControl(_layoutAlgorithmsPath);
         _customLayoutAlgorithmsControl.Dock = DockStyle.Fill;

         _customLayoutAlgorithmsControl.OnLayoutAlgorithmSelected += _customLayoutAlgorithmsControl_OnLayoutAlgorithmSelected;

         //_customOverlapRemovalAlgorithmsControl = new OverlapRemovalAlgorithmsControl(_overlapAlgorithmsPath);
         //_customOverlapRemovalAlgorithmsControl.Dock = DockStyle.Fill;

         //_customOverlapRemovalAlgorithmsControl.OnLayoutAlgorithmSelected += _customOverlapRemovalAlgorithmsControl_OnLayoutAlgorithmSelected;

         InitializeComponent();

         this.availableCustomAlgorithmsHost.Controls.Add(_customLayoutAlgorithmsControl);

         //this.availableCustomOverlapRemovalAlgorithmsHost.Controls.Add(_customOverlapRemovalAlgorithmsControl);

         InitializeGraphAlgorithms();
      }

      #endregion

      #region Methods

      /// <summary>
      /// 
      /// </summary>
      public void InitializeGraphAlgorithms()
      {
         // Populate default layout algorithms
         List<string> defaultLayoutAlgorithms = DefaultGraphLayoutAlgorithm.LayoutDefaultAlgorithmList();

         defaultAlgorithmListComboBox.Items.Clear();
         defaultAlgorithmListComboBox.Items.AddRange(defaultLayoutAlgorithms.ToArray());

         // Populate default overlap removal algorithms
         List<string> defaultOverlapRemovalAlgorithms = DefaultGraphLayoutAlgorithm.OverlapRemovalDefaultAlgorithmList();

         defaultOverlapRemovalAlgorithmListComboBox.Items.Clear();
         defaultOverlapRemovalAlgorithmListComboBox.Items.AddRange(defaultOverlapRemovalAlgorithms.ToArray());

         // Populate saved settings
         string defaultLayoutAlgorithm = DefaultGraphLayoutAlgorithm.LayoutAlgorithmToString(_graphPreferences.DefaultGraphLayoutAlgorithm.DefaultLayoutAlgorithm);

         defaultAlgorithmListComboBox.SelectedItem = defaultLayoutAlgorithm;

         string defaultOverlapRemovalAlgorithm = DefaultGraphLayoutAlgorithm.OverlapRemovalAlgorithmToString(_graphPreferences.DefaultGraphLayoutAlgorithm.DefaultOverlapRemovalAlgorithm);

         defaultOverlapRemovalAlgorithmListComboBox.SelectedItem = defaultOverlapRemovalAlgorithm;

         horizontalGapNumericUpDown.Value = _graphPreferences.DefaultGraphLayoutAlgorithm.OverlapRemovalAlgorithmHorizontalGap;
         verticalGapNumericUpDown.Value = _graphPreferences.DefaultGraphLayoutAlgorithm.OverlapRemovalAlgorithmVerticalGap;

         refreshEntireGraphWhenEditingCheckBox.Checked = _graphPreferences.AlwaysRefreshEntireGraph;
      }

      /// <summary>
      /// 
      /// </summary>
      private void CheckSameSettings()
      {
         bool sameAlgorithmPrefrencesUsed = GraphPreferencesData.SameAlgorithmPreferencesUsed(_currentPreferences, GraphManagerHost.CurrentGraphPreferencesData);

         changesVisibleAfterApplicationIsRestartedLabel.Visible = (sameAlgorithmPrefrencesUsed == false);
      }

      #endregion

      #region Events

      private void horizontalGapNumericUpDown_ValueChanged(object sender, EventArgs e)
      {
         _currentPreferences.DefaultGraphLayoutAlgorithm.OverlapRemovalAlgorithmHorizontalGap = (int)horizontalGapNumericUpDown.Value;

         CheckSameSettings();
      }

      private void verticalGapNumericUpDown_ValueChanged(object sender, EventArgs e)
      {
         _currentPreferences.DefaultGraphLayoutAlgorithm.OverlapRemovalAlgorithmVerticalGap = (int)verticalGapNumericUpDown.Value;

         CheckSameSettings();
      }

      private void defaultAlgorithmListComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (defaultAlgorithmListComboBox.SelectedItem != null)
         {
            string defaultAlgorithmAsString = defaultAlgorithmListComboBox.SelectedItem as string;
            LayoutAlgorithmTypeEnum defaultAlgorithm = DefaultGraphLayoutAlgorithm.LayoutAlgorithmFromString(defaultAlgorithmAsString);

            _currentPreferences.DefaultGraphLayoutAlgorithm.DefaultLayoutAlgorithm = defaultAlgorithm;

           customAlgorithmDetailsGroupBox.Enabled = (defaultAlgorithm == LayoutAlgorithmTypeEnum.Custom);
         }

         CheckSameSettings();
      }

      private void defaultOverlapRemovalAlgorithmListComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (defaultOverlapRemovalAlgorithmListComboBox.SelectedItem != null)
         {
            string defaultOverlapAlgorithmAsString = defaultOverlapRemovalAlgorithmListComboBox.SelectedItem as string;
            OverlapRemovalAlgorithmTypeEnum defaultOverlapAlgorithm = DefaultGraphLayoutAlgorithm.OverlapRemovalAlgorithmFromString(defaultOverlapAlgorithmAsString);
            bool viableOverlapRemovalAlgorithmParameters = (defaultOverlapAlgorithm != OverlapRemovalAlgorithmTypeEnum.None);

            _currentPreferences.DefaultGraphLayoutAlgorithm.DefaultOverlapRemovalAlgorithm = defaultOverlapAlgorithm;

            horizontalGapNumericUpDown.Enabled = viableOverlapRemovalAlgorithmParameters;
            verticalGapNumericUpDown.Enabled = viableOverlapRemovalAlgorithmParameters;

         }

         CheckSameSettings();
      }

      private void refreshEntireGraphWhenEditingCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         _currentPreferences.AlwaysRefreshEntireGraph = refreshEntireGraphWhenEditingCheckBox.Checked;

         CheckSameSettings();
      }

      /*private void customAlgorithm_EnabledChanged(object sender, EventArgs e)
      {
         bool enableDefaultOverlapRemovalAlgorithmOptions = (customAlgorithmDetailsGroupBox.Enabled == false);
         defaultOverlapRemovalAlgorithmListComboBox.Enabled = enableDefaultOverlapRemovalAlgorithmOptions;
         horizontalGapNumericUpDown.Enabled = enableDefaultOverlapRemovalAlgorithmOptions;
         verticalGapNumericUpDown.Enabled = enableDefaultOverlapRemovalAlgorithmOptions;
      }*/

      private void _customLayoutAlgorithmsControl_OnLayoutAlgorithmSelected(object sender, SelectedAlgorithmEventArgs e)
      {
         string noValidAlgorithmSelected = "None";
         bool invalidAlgorithmSelected = (e.Valid == false);

         noCustomAlgorithmSelected.Visible = invalidAlgorithmSelected;

         if (e.Valid)
         {
            selectedCustomAlgorithmNameLabel.Text = e.AlgorithmName;
            selectedCustomAlgorithmLibraryLabel.Text = e.LibraryName;

            _currentPreferences.CustomAlgorithmName = e.AlgorithmName;
            _currentPreferences.CustomAlgorithmLibrary = e.LibraryName;
         }
         else
         {
            selectedCustomAlgorithmNameLabel.Text = noValidAlgorithmSelected;
            selectedCustomAlgorithmLibraryLabel.Text = noValidAlgorithmSelected;

            _currentPreferences.CustomAlgorithmName = ConversationsManager.PreferencesData.GraphPreferences.CustomAlgorithmName;
            _currentPreferences.CustomAlgorithmLibrary = ConversationsManager.PreferencesData.GraphPreferences.CustomAlgorithmLibrary;
            _currentPreferences.DefaultGraphLayoutAlgorithm.DefaultLayoutAlgorithm = ConversationsManager.PreferencesData.GraphPreferences.DefaultGraphLayoutAlgorithm.DefaultLayoutAlgorithm;
         }
      }

      #endregion
   }
}
