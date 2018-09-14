namespace CollectionManagerDesktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextFilter = new System.Windows.Forms.TextBox();
            this.ButtonFilterApply = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonNewItem = new System.Windows.Forms.Button();
            this.ListItems = new System.Windows.Forms.ListBox();
            this.ButtonClearFilter = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TableItem = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextTags = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextNotes = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TableItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextFilter
            // 
            this.TextFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextFilter.Location = new System.Drawing.Point(3, 8);
            this.TextFilter.Name = "TextFilter";
            this.TextFilter.Size = new System.Drawing.Size(295, 22);
            this.TextFilter.TabIndex = 1;
            // 
            // ButtonFilterApply
            // 
            this.ButtonFilterApply.Location = new System.Drawing.Point(304, 3);
            this.ButtonFilterApply.Name = "ButtonFilterApply";
            this.ButtonFilterApply.Size = new System.Drawing.Size(75, 33);
            this.ButtonFilterApply.TabIndex = 2;
            this.ButtonFilterApply.Text = "Filter";
            this.ButtonFilterApply.UseVisualStyleBackColor = true;
            this.ButtonFilterApply.Click += new System.EventHandler(this.ButtonFilterApply_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ButtonNewItem, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextFilter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListItems, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonFilterApply, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonClearFilter, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 617);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ButtonNewItem
            // 
            this.ButtonNewItem.Location = new System.Drawing.Point(3, 587);
            this.ButtonNewItem.Name = "ButtonNewItem";
            this.ButtonNewItem.Size = new System.Drawing.Size(75, 27);
            this.ButtonNewItem.TabIndex = 5;
            this.ButtonNewItem.Text = "New";
            this.ButtonNewItem.UseVisualStyleBackColor = true;
            this.ButtonNewItem.Click += new System.EventHandler(this.ButtonNewItem_Click);
            // 
            // ListItems
            // 
            this.ListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.ListItems, 3);
            this.ListItems.FormattingEnabled = true;
            this.ListItems.ItemHeight = 16;
            this.ListItems.Location = new System.Drawing.Point(3, 42);
            this.ListItems.Name = "ListItems";
            this.ListItems.Size = new System.Drawing.Size(457, 532);
            this.ListItems.TabIndex = 4;
            this.ListItems.SelectedIndexChanged += new System.EventHandler(this.ListItems_SelectedIndexChanged);
            // 
            // ButtonClearFilter
            // 
            this.ButtonClearFilter.Location = new System.Drawing.Point(385, 3);
            this.ButtonClearFilter.Name = "ButtonClearFilter";
            this.ButtonClearFilter.Size = new System.Drawing.Size(75, 33);
            this.ButtonClearFilter.TabIndex = 3;
            this.ButtonClearFilter.Text = "Clear";
            this.ButtonClearFilter.UseVisualStyleBackColor = true;
            this.ButtonClearFilter.Click += new System.EventHandler(this.ButtonClearFilter_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TableItem);
            this.splitContainer1.Size = new System.Drawing.Size(966, 617);
            this.splitContainer1.SplitterDistance = 463;
            this.splitContainer1.TabIndex = 4;
            // 
            // TableItem
            // 
            this.TableItem.ColumnCount = 2;
            this.TableItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableItem.Controls.Add(this.label1, 0, 0);
            this.TableItem.Controls.Add(this.TextName, 1, 0);
            this.TableItem.Controls.Add(this.label2, 0, 1);
            this.TableItem.Controls.Add(this.TextTags, 1, 1);
            this.TableItem.Controls.Add(this.label3, 0, 2);
            this.TableItem.Controls.Add(this.TextNotes, 0, 3);
            this.TableItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableItem.Location = new System.Drawing.Point(0, 0);
            this.TableItem.Name = "TableItem";
            this.TableItem.RowCount = 4;
            this.TableItem.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableItem.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableItem.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableItem.Size = new System.Drawing.Size(499, 617);
            this.TableItem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // TextName
            // 
            this.TextName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextName.Location = new System.Drawing.Point(58, 3);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(438, 22);
            this.TextName.TabIndex = 1;
            this.TextName.TextChanged += new System.EventHandler(this.TextName_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tags:";
            // 
            // TextTags
            // 
            this.TextTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTags.Location = new System.Drawing.Point(58, 31);
            this.TextTags.Name = "TextTags";
            this.TextTags.Size = new System.Drawing.Size(438, 22);
            this.TextTags.TabIndex = 3;
            this.TextTags.TextChanged += new System.EventHandler(this.TextTags_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notes:";
            // 
            // TextNotes
            // 
            this.TextNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableItem.SetColumnSpan(this.TextNotes, 2);
            this.TextNotes.Location = new System.Drawing.Point(3, 76);
            this.TextNotes.Multiline = true;
            this.TextNotes.Name = "TextNotes";
            this.TextNotes.Size = new System.Drawing.Size(493, 538);
            this.TextNotes.TabIndex = 5;
            this.TextNotes.TextChanged += new System.EventHandler(this.TextNotes_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(966, 617);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Collection Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TableItem.ResumeLayout(false);
            this.TableItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TextFilter;
        private System.Windows.Forms.Button ButtonFilterApply;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ButtonClearFilter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ButtonNewItem;
        private System.Windows.Forms.ListBox ListItems;
        private System.Windows.Forms.TableLayoutPanel TableItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextNotes;
    }
}

