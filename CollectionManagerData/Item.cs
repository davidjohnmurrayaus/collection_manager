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
        /// Access the tags as a comma delimited string.
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
                    if (!availibleTags.Keys.Contains(tagName))
                    {
                        availibleTags.Add(tagName, new Tag() { Name = tagName });
                    }
                    Tags.Add(tagName, availibleTags[tagName]);

                }
            }
        }

        /// <summary>
        /// All of the known tags.
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
        /// Convert item to xml.
        /// </summary>
        /// <returns></returns>
        internal XElement AsXmlNode()
        {
            var itemNode = new XElement("Item");

            itemNode.Add(new XElement("Name", Name));

            var itemTagsNode = new XElement("Tags");
            foreach (var t in Tags.Values)
            {
                itemTagsNode.Add(t.AsXmlNode());
            }
            itemNode.Add(itemTagsNode);

            itemNode.Add(new XElement("Notes", Notes));

            return itemNode;
        }

        /// <summary>
        /// Object is equal if all fields match.
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
        /// Hash code is based on all fields.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Notes.GetHashCode() ^ TagsString.GetHashCode();
        }
    }
}
