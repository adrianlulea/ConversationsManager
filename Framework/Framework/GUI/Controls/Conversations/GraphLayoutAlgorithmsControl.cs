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

         InitializeComponent();

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

            _currentPreferences.DefaultGraphLayoutAlgorithm.DefaultOverlapRemovalAlgorithm = defaultOverlapAlgorithm;
         }

         CheckSameSettings();
      }

      private void refreshEntireGraphWhenEditingCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         _currentPreferences.AlwaysRefreshEntireGraph = refreshEntireGraphWhenEditingCheckBox.Checked;

         CheckSameSettings();
      }

      #endregion
   }
}
