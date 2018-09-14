using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollectionManager.Web
{
    /// <summary>
    /// Default page that displays a colleciton.
    /// </summary>
    public partial class Default : BasePage
    {
        /// <summary>
        /// URI of the page for naviagtion.
        /// </summary>
        public const string PAGE_URI = "Default.aspx";

        /// <summary>
        /// On page load 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterItems.DataSource = MyCollection.Items;
            RepeaterItems.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonAddItem_Click(object sender, EventArgs e)
        {
            Response.Redirect(ItemEdit.GetUri("-1"));
        }
    }
}