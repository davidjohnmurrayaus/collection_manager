using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionManagerDesktop
{
    public partial class MainForm : Form
    {
        const string DEFAULT_FILEPATH = "collection.xml";

        CollectionManager.Data.Collection myCollection;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFilterApply_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(DEFAULT_FILEPATH))
            {
                myCollection = CollectionManager.Data.Collection.LoadXml(DEFAULT_FILEPATH);
            }
            else
            {
                myCollection = new CollectionManager.Data.Collection();
            }

            foreach (var i in myCollection.items)
            {
                dataGridView1.Rows.Add(new string[] {
                    i.Name,
                    string.Join(",", i.Tags.Keys.ToArray()),
                    "Details" });
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCollection.SaveXml(DEFAULT_FILEPATH);
        }
    }
}
