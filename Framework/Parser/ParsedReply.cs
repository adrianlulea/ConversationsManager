using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
   /// <summary>
   /// Parsed Reply class
   /// </summary>
   public class ParsedReply
   {
      #region Members

      /// <summary>
      /// Flag whether data is sealed.
      /// </summary>
      private bool _sealed = false;

      /// <summary>
      /// Reply's author
      /// </summary>
      private string _author;

      /// <summary>
      /// Reply's text
      /// </summary>
      private string _text;

      /// <summary>
      /// Reply's ID
      /// </summary>
      private Guid _id;

      /// <summary>
      /// List of parents
      /// </summary>
      private List<Guid> _parents;

      /// <summary>
      /// List of children
      /// </summary>
      private List<Guid> _children;

      /// <summary>
      /// Reply's timestamp
      /// </summary>
      private DateTime _timestamp;

      #endregion

      #region Properties

      /// <summary>
      /// Get Reply's Author
      /// </summary>
      public string Author
      {
         get { return _author; }
      }

      /// <summary>
      /// Get Reply's Text
      /// </summary>
      public string Text
      {
         get { return _text; }
      }

      /// <summary>
      /// Get Reply's Id
      /// </summary>
      public Guid Id
      {
         get { return _id; }
      }

      /// <summary>
      /// Get Reply's list of parents
      /// </summary>
      public List<Guid> Parents
      {
         get
         {
            List<Guid> parents = new List<Guid>();
            parents.AddRange(_parents);

            return parents;
         }
      }

      /// <summary>
      /// Get Reply's list of children
      /// </summary>
      public List<Guid> Children
      {
         get
         {
            List<Guid> children = new List<Guid>();
            children.AddRange(_children);

            return children;
         }
      }

      /// <summary>
      /// Get Reply's timestamp
      /// </summary>
      public DateTime Timestamp
      {
         get { return _timestamp; }
      }

      /// <summary>
      /// Check if data is sealed
      /// </summary>
      public bool Sealed
      {
         get { return _sealed; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// Create new parsed reply
      /// </summary>
      /// <param name="author">Parsed reply's author</param>
      /// <param name="text">Parsed reply's text</param>
      /// <param name="timestamp">Parsed reply's timestamp</param>
      /// <param name="id">Parsed reply's id</param>
      public ParsedReply(string author, string text, DateTime timestamp, Guid id)
      {
         this._author = author;
         this._text = text;
         this._timestamp = timestamp;
         this._id = id;

         this._children = new List<Guid>();
         this._parents = new List<Guid>();
         this._sealed = false;
      }

      #endregion

      #region Methods

      /// <summary>
      /// Make sure that the data cannot be altered anymore
      /// </summary>
      public void SealData()
      {
         this._sealed = true;
      }

      /// <summary>
      /// Add child to reply
      /// </summary>
      /// <param name="id">Child's Id</param>
      public void AddChild(Guid id)
      {
         if (this._sealed == false)
         {
            this._children.Add(id);
         }
      }

      /// <summary>
      /// /Add parent to reply
      /// </summary>
      /// <param name="id">Parent's Id</param>
      public void AddParent(Guid id)
      {
         if (this._sealed == false)
         {
            this._parents.Add(id);
         }
      }

      /// <summary>
      /// Output string representation for the reply.
      /// </summary>
      /// <returns>Reply's string representation</returns>
      public override string ToString()
      {
         string stringRepresentation = "";

         stringRepresentation += "Autor=(" + this._author
                               + "), Id=(" + this._id
                               + "), Text=(" + this._text
                               + "), Parents=(";

         foreach (Guid parent in this._parents)
         {
            stringRepresentation += "(" + parent + ")";
         }

         stringRepresentation += "), Children=(";

         foreach (Guid child in this._children)
         {
            stringRepresentation += "(" + child + ")";
         }

         stringRepresentation += ")";

         return stringRepresentation;
      }

      #endregion
   }
}
