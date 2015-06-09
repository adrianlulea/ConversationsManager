using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Language
{
   /// <summary>
   /// Serializable language class.
   /// </summary>
   [Serializable]
   public class Language
   {
      #region Members

      /// <summary>
      /// Language's name.
      /// </summary>
      private string _name;
      
      /// <summary>
      /// Language's description.
      /// </summary>
      private string _description;

      /// <summary>
      /// Language's items.
      /// </summary>
      private List<LanguageItem> _items; 

      #endregion

      #region Properties

      /// <summary>
      /// Gets or sets language's name.
      /// </summary>
      public string Name
      {
         get { return _name; }
         set { _name = value; }
      }

      /// <summary>
      /// Gets or sets language's description.
      /// </summary>
      public string Description
      {
         get { return _description; }
         set { _description = value; }
      }

      /// <summary>
      /// Gets or sets language's items.
      /// </summary>
      public List<LanguageItem> Items
      {
         get { return _items; }
         set { _items = value; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// Default empty language constructor.
      /// </summary>
      public Language()
      {
         this._name = "";
         this._description = "";
         this._items = new List<LanguageItem>();
      }

      /// <summary>
      /// Default language by name and description constructor.
      /// </summary>
      /// <param name="name"></param>
      /// <param name="description"></param>
      public Language(string name, string description)
      {
         this._name = name;
         this._description = description;
         this._items = new List<LanguageItem>();
      }

      #endregion

      #region Methods

      /// <summary>
      /// Add language item.
      /// </summary>
      /// <param name="item">Language item.</param>
      public void AddItem(LanguageItem item)
      {
         if (this._items.Contains(item) == false)
         {
            this._items.Add(item);
         }
      }

      /// <summary>
      /// Add language item.
      /// </summary>
      /// <param name="tag">Language item's tag.</param>
      /// <param name="value">Language item's value.</param>
      public void AddItem(string tag, string value)
      {
         LanguageItem item = new LanguageItem(tag, value);

         this.AddItem(item);
      }

      /// <summary>
      /// Remove language item.
      /// </summary>
      /// <param name="item">Language item to remove.</param>
      public void RemoveItem(LanguageItem item)
      {
         this._items.Remove(item);
      }

      /// <summary>
      /// Remove language item by tag.
      /// </summary>
      /// <param name="tag">Language item's tag.</param>
      public void RemoveItem(string tag)
      {
         LanguageItem item = new LanguageItem(tag, "");

         this.RemoveItem(item);
      }

      #endregion
   }
}
