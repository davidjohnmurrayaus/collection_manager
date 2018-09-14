using System;
using System.IO;
using System.Windows.Forms;

namespace CollectionManagerDesktop
{
    /// <summary>
    /// Desktop collection manager program.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Fields and Properties
        /// <summary>
        /// File to read and write collection to/from.
        /// </summary>
        protected const string DEFAULT_FILEPATH = "collection.xml";

        /// <summary>
        /// The colleciton of items.
        /// </summary>
        protected CollectionManager.Data.Collection MyCollection;

        /// <summary>
        /// The currently selected item.
        /// </summary>
        protected CollectionManager.Data.Item CurrentItem;

        /// <summary>
        /// Flag to stop an infinite loop of update events.
        /// </summary>
        private bool disableItemUpdates = false;
        #endregion

        #region Methods
        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create a new item, insert it into collection and make it the selected item.
        /// </summary>
        protected void CreateAndSelectItem()
        {
            if (!disableItemUpdates)
            {
                var newItem = new CollectionManager.Data.Item(MyCollection.Tags) { Name = "New Item" };
                MyCollection.Items.Add(newItem);
                CurrentItem = newItem;

                try
                {
                    disableItemUpdates = true;
                    ListItems.Items.Add(newItem);
                    ListItems.SelectedItem = newItem;
                }
                finally
                {
                    disableItemUpdates = false;
                }
            }
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Load collection from disk and populate form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(DEFAULT_FILEPATH))
            {
                MyCollection = CollectionManager.Data.Collection.LoadXml(DEFAULT_FILEPATH);
            }
            else
            {
                MyCollection = new CollectionManager.Data.Collection();
            }

            ListItems.Items.Clear();
            foreach (var i in MyCollection.Items)
            {
                ListItems.Items.Add(i);
            }
        }

        /// <summary>
        /// Save collection to disk.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyCollection.SaveXml(DEFAULT_FILEPATH);
        }

        /// <summary>
        /// Apply a filter to the displayed items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFilterApply_Click(object sender, EventArgs e)
        {
            ListItems.Items.Clear();
            foreach (var i in MyCollection.Items)
            {
                if (TextFilter.Text.Length == 0)
                {
                    ListItems.Items.Add(i);
                }
                else if (i.ToString().Contains(TextFilter.Text))
                {
                    ListItems.Items.Add(i);
                }
            }
        }

        /// <summary>
        /// Clear the filter to displayed items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClearFilter_Click(object sender, EventArgs e)
        {
            ListItems.Items.Clear();
            foreach (var i in MyCollection.Items)
            {
                ListItems.Items.Add(i);
            }
        }

        /// <summary>
        /// Add a new item and select it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewItem_Click(object sender, EventArgs e)
        {
            CreateAndSelectItem();
        }

        /// <summary>
        /// Change the selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!disableItemUpdates)
            {
                CurrentItem = ListItems.SelectedItem as CollectionManager.Data.Item;

                try
                {
                    disableItemUpdates = true;
                    TextName.Text = CurrentItem.Name;
                    TextTags.Text = CurrentItem.TagsString;
                    TextNotes.Text = CurrentItem.Notes;
                }
                finally
                {
                    disableItemUpdates = false;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextName_TextChanged(object sender, EventArgs e)
        {
            if (!disableItemUpdates)
            {
                if (CurrentItem == null)
                {
                    CreateAndSelectItem();
                }
                CurrentItem.Name = TextName.Text;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextTags_TextChanged(object sender, EventArgs e)
        {
            if (!disableItemUpdates)
            {
                if (CurrentItem == null)
                {
                    CreateAndSelectItem();
                }
                CurrentItem.TagsString = TextTags.Text;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextNotes_TextChanged(object sender, EventArgs e)
        {
            if (!disableItemUpdates)
            {
                if (CurrentItem == null)
                {
                    CreateAndSelectItem();
                }
                CurrentItem.Notes = TextNotes.Text;
            }
        }
        #endregion
    }
}
