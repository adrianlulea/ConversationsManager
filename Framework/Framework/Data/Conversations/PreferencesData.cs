using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Util;

namespace Framework.Data.Conversations
{
    /// <summary>
    /// PreferencesData serializable class.
    /// </summary>
    [Serializable]
    public class PreferencesData
    {
        #region Members

        /// <summary>
        /// Default language flag.
        /// </summary>
        private bool _defaultLanguage;
        /// <summary>
        /// Custom language file location path.
        /// </summary>
        private string _customLanguageLocation;

        /// <summary>
        /// Default theme flag.
        /// </summary>
        private bool _defaultTheme;
        /// <summary>
        /// Custom theme file location path.
        /// </summary>
        private string _customThemeLocation;

        /// <summary>
        /// Default location flag.
        /// </summary>
        private bool _defaultLocation;
        /// <summary>
        /// Custom location path.
        /// </summary>
        private string _customLocation;

        /// <summary>
        /// Binary exporting format flag.
        /// </summary>
        private bool _binaryFormat;

        /// <summary>
        /// XML exporting format flag.
        /// </summary>
        private bool _xmlFormat;

       /// <summary>
       /// Path where imported parser libraries are saved.
       /// </summary>
        private string _parserPath;

       /// <summary>
        /// Path where imported layout algorithm libraries are saved.
       /// </summary>
        private string _layoutAlgorithmPath;

       /// <summary>
        /// Path where imported overlap removal algorithm libraries are saved.
       /// </summary>
        private string _overlapAlgorithmsPath;

       /// <summary>
       /// Graph preferences data.
       /// </summary>
        private GraphPreferencesData _graphPreferences;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets default language flag.
        /// </summary>
        public bool DefaultLanguage
        {
            get { return _defaultLanguage; }
            set { _defaultLanguage = value; }
        }

        /// <summary>
        /// Gets or sets custom language location path.
        /// </summary>
        public string LanguageLocation
        {
            get { return _customLanguageLocation; }
            set { _customLanguageLocation = value; }
        }

        /// <summary>
        /// Gets or sets default theme flag.
        /// </summary>
        public bool DefaultTheme
        {
            get { return _defaultTheme; }
            set { _defaultTheme = value; }
        }

        /// <summary>
        /// Gets or sets custom theme location path.
        /// </summary>
        public string ThemeLocation
        {
            get { return _customThemeLocation; }
            set { _customThemeLocation = value; }
        }

        /// <summary>
        /// Gets or sets default location flag.
        /// </summary>
        public bool DefaultLocation
        {
            get { return _defaultLocation; }
            set { _defaultLocation = value; }
        }

        /// <summary>
        /// Gets or sets custom save location path.
        /// </summary>
        public string SaveLocation
        {
            get { return _customLocation; }
            set { _customLocation = value; }
        }

        /// <summary>
        /// Gets or sets binary format flag.
        /// </summary>
        public bool BinaryFormat
        {
            get { return _binaryFormat; }
            set
            {
                _binaryFormat = value;

                if (value)
                {
                    _xmlFormat = false;
                }
            }
        }

        /// <summary>
        /// Gets or sets XML format flag.
        /// </summary>
        public bool XMLFormat
        {
            get { return _xmlFormat; }
            set
            {
                _xmlFormat = value;

                if (value)
                {
                    _binaryFormat = false;
                }
            }
        }

       /// <summary>
       /// Gets or sets path where imported parser libraries are saved.
       /// </summary>
        public string ParserPath
        {
           get { return _parserPath; }
           set { _parserPath = value; }
        }

        /// <summary>
        /// Gets or sets path where imported overlap removal algorithm libraries are saved.
        /// </summary>
        public string OverlapAlgorithmsPath
        {
           get { return _overlapAlgorithmsPath; }
           set { _overlapAlgorithmsPath = value; }
        }

        /// <summary>
        /// Gets or sets path where imported layout algorithm libraries are saved.
        /// </summary>
        public string LayoutAlgorithmPath
        {
           get { return _layoutAlgorithmPath; }
           set { _layoutAlgorithmPath = value; }
        }

       /// <summary>
       /// Gets or sets graph preferences data.
       /// </summary>
        public GraphPreferencesData GraphPreferences
        {
           get { return _graphPreferences; }
           set { _graphPreferences = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default preferences data.
        /// </summary>
        public PreferencesData()
        {
            _defaultLanguage = true;
            _customLanguageLocation = "";
            _defaultTheme = true;
            _customThemeLocation = "";
            _defaultLocation = true;
            _customLocation = "";
            _binaryFormat = true;
            _xmlFormat = false;
            _parserPath = "Parsers";
            _layoutAlgorithmPath = "Layout";
            _overlapAlgorithmsPath = "Overlap";
            _graphPreferences = new GraphPreferencesData();
        }

        #endregion
    }
}
