using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Language
{
   /// <summary>
   /// Language item serializable class.
   /// </summary>
   [Serializable]
   public class LanguageItem
   {
      #region Members

      /// <summary>
      /// Language item's tag.
      /// </summary>
      private string _tag;

      /// <summary>
      /// Language item's value.
      /// </summary>
      private string _value;

      #endregion

      #region Properties

      /// <summary>
      /// Gets or sets language item's tag.
      /// </summary>
      public string Tag
      {
         get { return _tag; }
         set { _tag = value; }
      }

      /// <summary>
      /// Gets or sets language item's value.
      /// </summary>
      public string Value
      {
         get { return _value; }
         set { _value = value; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// Default empty language item constructor.
      /// </summary>
      public LanguageItem()
      {
         this._tag = "";
         this._value = "";
      }

      /// <summary>
      /// Default language item constructor.
      /// </summary>
      /// <param name="tag">Language item's tag.</param>
      /// <param name="value">Language item's value.</param>
      public LanguageItem(string tag, string value)
      {
         this._tag = tag;
         this._value = value;
      }

      #endregion

      #region Methods

      /// <summary>
      /// Override equals method
      /// </summary>
      /// <param name="obj">LanguageItem to test equality with</param>
      /// <returns>true if items are equal and false if not</returns>
      public override bool Equals(object obj)
      {
         LanguageItem item = (LanguageItem)obj;

         bool itemsHaveSameTag = (item._tag == this._tag);
         bool itemsAreEqual = itemsHaveSameTag;

         return itemsAreEqual;
         
      }

      /// <summary>
      /// Override GetHashCode method
      /// </summary>
      /// <returns></returns>
      public override int GetHashCode()
      {
         return this._tag.GetHashCode();
      }

      #endregion
   }
}
