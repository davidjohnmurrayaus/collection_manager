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
        /// Notes on this item.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Item()
        {
            Tags = new Dictionary<string, Tag>();
        }
    }
}
