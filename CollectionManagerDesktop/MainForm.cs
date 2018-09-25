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
                    PopulateEditControls();
                }
                finally
                {
                    disableItemUpdates = false;
                }
            }
        }

        /// <summary>
        /// Put items in list box.
        /// </summary>
        void PopulateItems()
        {
            try
            {
                disableItemUpdates = true;
                ListItems.Items.Clear();
                foreach (var i in MyCollection.Items)
                {
                    if (string.IsNullOrWhiteSpace(TextFilter.Text))
                    {
                        ListItems.Items.Add(i);
                    }
                    else if (i.ToString().ToUpper().Contains(TextFilter.Text.ToUpper()))
                    {
                        ListItems.Items.Add(i);
                    }
                }
            }
            finally
            {
                disableItemUpdates = false;
            }
        }

        /// <summary>
        /// Put values of item into edit controls.
        /// </summary>
        void PopulateEditControls()
        {
            TextName.Text = CurrentItem.Name;
            TextTags.Text = CurrentItem.TagsString;
            TextNotes.Text = CurrentItem.Notes;
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
            PopulateItems();
        }

        /// <summary>
        /// Clear the filter to displayed items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClearFilter_Click(object sender, EventArgs e)
        {
            TextFilter.Text = "";
            PopulateItems();
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
                    PopulateEditControls();
                }
                finally
                {
                    disableItemUpdates = false;
                }
            }
        }

        /// <summary>
        /// Save changes to backing object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            int index = ListItems.SelectedIndex;
            CurrentItem.Name = TextName.Text;
            CurrentItem.TagsString = TextTags.Text;
            CurrentItem.Notes = TextNotes.Text;
            PopulateItems();
            ListItems.SelectedIndex = index;
        }

        /// <summary>
        /// Abandon changes to item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            PopulateEditControls();
        }
        #endregion
    }
}
