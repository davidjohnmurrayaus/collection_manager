using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionManager.Data
{
    /// <summary>
    /// A tag that can be applied to collection items.
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// name of this tag.
        /// </summary>
        public string Name;

        /// <summary>
        /// Category that this tag belongs to.
        /// </summary>
        public string Category;

        /// <summary>
        /// Conveet tag to xml node.
        /// </summary>
        /// <returns></returns>
        internal XElement AsXmlNode()
        {
            var tagNode = new XElement("Tag");

            tagNode.Add(new XElement("Name", Name));
            tagNode.Add(new XElement("Category", Category));

            return tagNode;
        }

        /// <summary>
        /// Convert xml to tag.
        /// </summary>
        /// <param name="tagNode"></param>
        /// <returns></returns>
        internal static Tag FromXml(XElement tagNode)
        {
            return new Tag()
            {
                Name = tagNode.Elements("Name").First().Value,
                Category = tagNode.Elements("Category").First().Value
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
