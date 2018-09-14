using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionManager.Data
{
    /// <summary>
    /// An item in a collection.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tags that apply to this item.
        /// </summary>
        public Dictionary<string, Tag> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TagsString
        {
            get
            {
                return string.Join(", ", Tags.Keys);
            }
            set
            {
                Tags.Clear();
                foreach (string rawTagName in value.Split(','))
                {
                    string tagName = rawTagName.Trim();
                    if (availibleTags.Keys.Contains(tagName))
                    {
                        Tags.Add(tagName, availibleTags[tagName]);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected Dictionary<string, Tag> availibleTags;

        /// <summary>
        /// Notes on this item.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Item(Dictionary<string, Tag> availibleTags)
        {
            this.availibleTags = availibleTags;
            Tags = new Dictionary<string, Tag>();
        }

        /// <summary>
        /// Convert to human readable string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Tags.Count == 0)
            {
                return Name;
            }
            else
            {
                return Name + " " + string.Join(", ", Tags.Keys);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var other = obj as Item;
            if (other == null)
            {
                return false;
            }

            return Name == other.Name
                && Notes == other.Notes
                && TagsString == other.TagsString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Notes.GetHashCode() ^ TagsString.GetHashCode();
        }
    }
}
