using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionManager.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class Item
    {
        public string name;
        public HashSet<Tag> tags;
        public string notes;
    }
}
