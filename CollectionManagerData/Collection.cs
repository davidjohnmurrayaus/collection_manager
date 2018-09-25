using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionManager.Data
{
    /// <summary>
    /// A collection of items.
    /// </summary>
    public class Collection
    {
        /// <summary>
        /// Items in the collection
        /// </summary>
        public List<Item> Items = new List<Item>();

        /// <summary>
        /// Tags that can be applied to items in this collection.
        /// </summary>
        public Dictionary<string, Tag> Tags = new Dictionary<string, Tag>();

        /// <summary>
        /// Read collection from XML file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static Collection LoadXml(string filePath)
        {
            var myCollection = new Collection();
            var xDoc = XDocument.Load(filePath);
            var root = xDoc.FirstNode as XElement;

            var tagsNode = root.Element("Tags");
            foreach (var tagNode in from el in tagsNode.Elements("Tag") select el)
            {
                var tag = Data.Tag.FromXml(tagNode);
                myCollection.Tags.Add(tag.Name, tag);
            }

            var itemsNode = root.Element("Items");
            foreach (var itemNode in itemsNode.Elements("Item"))
            {
                var tags = new Dictionary<string, Tag>();
                var itemTagsNode = itemNode.Element("Tags");
                foreach (var tagNode in itemTagsNode.Elements("Tag"))
                {
                    var t = Data.Tag.FromXml(tagNode);
                    tags.Add(t.Name, t);
                }

                myCollection.Items.Add(new Item(myCollection.Tags)
                {
                    Name = itemNode.Descendants("Name").First().Value,
                    Tags = tags,
                    Notes = itemNode.Descendants("Notes").First().Value
                });
            }

            return myCollection;
        }

        /// <summary>
        /// Save collection to an XML file.
        /// </summary>
        /// <param name="filePath"></param>
        public void SaveXml(string filePath)
        {
            var xDoc = new XDocument();
            var root = new XElement("Collection");
            xDoc.Add(root);

            var tagsNode = new XElement("Tags");
            root.Add(tagsNode);
            foreach (Tag t in Tags.Values)
            {
                tagsNode.Add(t.AsXmlNode());
            }

            var allItemsNode = new XElement("Items");
            root.Add(allItemsNode);
            foreach (Item i in Items)
            {
                allItemsNode.Add(i.AsXmlNode());
            }

            xDoc.Save(filePath);
        }
    }
}
