using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CollectionManager.Web
{
    /// <summary>
    /// Base class for all pages that work with a collection.
    /// </summary>
    public class BasePage : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        private const string DEFAULT_FILEPATH= @"C:\inetpub\wwwroot\collection_manager_data\MyCollection.xml";

        /// <summary>
        /// 
        /// </summary>
        private Data.Collection _MyCollection;

        /// <summary>
        /// 
        /// </summary>
        protected Data.Collection MyCollection
        {
            get
            {
                if (_MyCollection == null)
                {
                    if (File.Exists(DEFAULT_FILEPATH))
                    {
                        _MyCollection = Data.Collection.LoadXml(DEFAULT_FILEPATH);
                    }
                    else
                    {
                        _MyCollection = new Data.Collection();
                    }
                }
                return _MyCollection;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected void SaveCollection()
        {
            MyCollection.SaveXml(DEFAULT_FILEPATH);
        }
    }
}