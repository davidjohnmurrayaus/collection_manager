using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollectionManager.Web
{
    /// <summary>
    /// Create or edit an item
    /// </summary>
    public partial class ItemEdit : BasePage
    {
        /// <summary>
        /// Name of the page for navigation.
        /// </summary>
        protected const string PAGE_NAME = "ItemEdit.aspx";

        /// <summary>
        /// Request parameter name.
        /// </summary>
        protected const string PARAM_NAME_ITEM_ID = "item_id";

        /// <summary>
        /// 
        /// </summary>
        protected string ItemId
        {
            get
            {
                return Request[PARAM_NAME_ITEM_ID];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected Data.Item MyItem
        {
            get
            {
                if (ItemId == "-1")
                {
                    return new Data.Item();
                }
                else
                {
                    return MyCollection.items.Where(i => i.Name == ItemId).First();
                }
            }
        }

        /// <summary>
        /// Get a URI for this page.
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public static string GetUri(string itemId)
        {
            return PAGE_NAME + "?" + PARAM_NAME_ITEM_ID + "=" + itemId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextName.Text = MyItem.Name;
                TextTags.Text = string.Join(", ", MyItem.Tags.Keys);
                TextNotes.Text = MyItem.Notes;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            MyItem.Name = TextName.Text;
            MyItem.Tags = new Dictionary<string, Data.Tag>();
            foreach (string rawTagName in TextTags.Text.Split(','))
            {
                string tagName = rawTagName.Trim();
                if (MyCollection.tags.Keys.Contains(tagName))
                {
                    var myTag = MyCollection.tags[tagName];
                    MyItem.Tags.Add(myTag.Name, myTag);
                }
                else
                {
                    var myTag = new Data.Tag() { Name = tagName };
                    MyCollection.tags.Add(tagName, myTag);
                    MyItem.Tags.Add(myTag.Name, myTag);
                }
            }
            MyItem.Notes = TextNotes.Text;
            SaveCollection();
            Response.Redirect(Default.PAGE_URI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(Default.PAGE_URI);
        }
    }
}