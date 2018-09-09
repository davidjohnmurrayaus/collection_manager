using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionManager.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class Collection
    {
        /// <summary>
        /// Items in the collection
        /// </summary>
        public List<Item> items = new List<Item>();

        /// <summary>
        /// Tags that can be applied to items in this collection.
        /// </summary>
        public Dictionary<string, Tag> tags = new Dictionary<string, Tag>();

        /// <summary>
        /// Read collection from XML file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static Collection LoadXml(string filePath)
        {
            var myCollection = new Collection();
            var xDoc = XDocument.Load(filePath);
            var root = xDoc.FirstNode;

            foreach (var tagNode in from el in xDoc.Descendants("Tag") select el)
            {
                string name = tagNode.Descendants("Name").First().Value;
                myCollection.tags.Add(name, new Tag() {
                    Name = name,
                    Category = tagNode.Descendants("Category").First().Value
                });
            }

            foreach (var itemNode in xDoc.Descendants("Item"))
            {
                var tags = new Dictionary<string, Tag>();
                foreach (var t in itemNode.Descendants("Tags").First().Descendants().Select(t => myCollection.tags[t.Value]))
                {
                    tags.Add(t.Name, t);
                }

                myCollection.items.Add(new Item() {
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
            foreach (Tag t in tags.Values)
            {
                var tagNode = new XElement("Tag");
                tagsNode.Add(tagNode);

                tagNode.Add(new XElement("Name", t.Name));
                tagNode.Add(new XElement("Category", t.Category));
            }

            var allItemsNode = new XElement("Items");
            root.Add(allItemsNode);
            foreach (Item i in items)
            {
                var itemNode = new XElement("Item");
                allItemsNode.Add();

                itemNode.Add(new XElement("Name", i.Name));
                var itemTagsNode = new XElement("Tags");
                itemNode.Add(itemTagsNode);
                foreach (string t in i.Tags.Keys)
                {
                    itemTagsNode.Add("Tag", t);
                }
                itemNode.Add(new XElement("Notes", i.Notes));
            }

            xDoc.Save(filePath);
        }
    }
}
