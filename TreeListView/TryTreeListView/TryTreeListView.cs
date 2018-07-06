using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TryTreeListView
{
    /// <summary>
    /// Summary description for TryTreeListView.
    /// </summary>
    public class TryTreeListView : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TreeListView treeListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.IContainer components;

        public TryTreeListView()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TryTreeListView));
            System.Windows.Forms.TreeListViewItemCollection.TreeListViewItemCollectionComparer treeListViewItemCollectionComparer1 = new System.Windows.Forms.TreeListViewItemCollection.TreeListViewItemCollectionComparer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeListView1 = new System.Windows.Forms.TreeListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(21, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add / Remove All";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(838, 637);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(333, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Expand / Collapse All";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // treeListView1
            // 
            this.treeListView1.AllowColumnReorder = true;
            this.treeListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView1.CheckBoxes = System.Windows.Forms.CheckBoxesTypes.Recursive;
            this.treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            treeListViewItemCollectionComparer1.Column = 0;
            treeListViewItemCollectionComparer1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.treeListView1.Comparer = treeListViewItemCollectionComparer1;
            this.treeListView1.HideSelection = false;
            this.treeListView1.LabelEdit = true;
            this.treeListView1.Location = new System.Drawing.Point(10, 9);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.Size = new System.Drawing.Size(1172, 610);
            this.treeListView1.SmallImageList = this.imageList1;
            this.treeListView1.TabIndex = 0;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.AfterLabelEdit += new System.Windows.Forms.TreeListViewLabelEditEventHandler(this.treeListView1_AfterLabelEdit);
            this.treeListView1.BeforeLabelEdit += new System.Windows.Forms.TreeListViewBeforeLabelEditEventHandler(this.treeListView1_BeforeLabelEdit);
            this.treeListView1.BeforeExpand += new System.Windows.Forms.TreeListViewCancelEventHandler(this.treeListView1_BeforeExpand);
            this.treeListView1.BeforeCollapse += new System.Windows.Forms.TreeListViewCancelEventHandler(this.treeListView1_BeforeCollapse);
            this.treeListView1.AfterExpand += new System.Windows.Forms.TreeListViewEventHandler(this.treeListView1_AfterExpand);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Attribute";
            this.columnHeader2.Width = 100;
            // 
            // TryTreeListView
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(13, 28);
            this.ClientSize = new System.Drawing.Size(1192, 695);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeListView1);
            this.Name = "TryTreeListView";
            this.Text = "TryTreeListView";
            this.Load += new System.EventHandler(this.TryTreeListView_Load);
            this.ResumeLayout(false);

        }
        #endregion

        [STAThread]
        static void Main() 
        {
            Application.Run(new TryTreeListView());
        }

        private void TryTreeListView_Load(object sender, System.EventArgs e)
        {
            AddItems();
        }

        private void treeListView1_BeforeExpand(object sender, System.Windows.Forms.TreeListViewCancelEventArgs e)
        {
            if(e.Item.ImageIndex == 1) e.Item.ImageIndex = 2;
        }

        private void treeListView1_BeforeCollapse(object sender, System.Windows.Forms.TreeListViewCancelEventArgs e)
        {
            if(e.Item.ImageIndex == 2) e.Item.ImageIndex = 1;
        }

        private void treeListView1_BeforeLabelEdit(object sender, System.Windows.Forms.TreeListViewBeforeLabelEditEventArgs e)
        {
            if(e.Item.ImageIndex < 1 || e.Item.ImageIndex > 2)
                e.ColumnIndex = 0;
            if(e.ColumnIndex == 1)
            {
                ComboBox combobox = new ComboBox();
                combobox.Items.AddRange(new string[]{"New value 1","New value 2","New value 3"});
                e.Editor = combobox;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if(treeListView1.Items.Count > 0)
                treeListView1.Items.Clear();
            else
                AddItems();
        }

        bool collapse = false;
        private void button2_Click(object sender, System.EventArgs e)
        {
            if(collapse)
                treeListView1.CollapseAll();
            else
                treeListView1.ExpandAll();

            collapse = !collapse;
        }

        private void AddItems()
        {
            for(int k = 0; k < 4; k++)
            {
                TreeListViewItem itemA = new TreeListViewItem("Drive " + Enum.GetName(typeof(Drives), k), 0);
                itemA.Expand();
                itemA.SubItems.Add(Enum.GetName(typeof(DrivesDescr), k) + " drive");
                treeListView1.Items.Add(itemA);
                for(int i = 1; i < 11; i++)
                {
                    TreeListViewItem item = new TreeListViewItem("Folder " + i.ToString(), 1);
                    itemA.Items.Add(item);
                    ListViewItem.ListViewSubItem subitem = item.SubItems.Add((Math.Abs(2-i)).ToString());
//					subitem.ForeColor = Color.FromArgb(173,194,231);
//					subitem.BackColor = Color.Yellow;
//					subitem.Font = new Font(subitem.Font, FontStyle.Bold | FontStyle.Underline);
                    for(int j = 1; j < 5; j++)
                        item.Items.Add("Sub " + j, 3);
                }
            }
        }
    
        private enum DrivesDescr{First, Second, Third, Fourth}
        private enum Drives{C, D, E, Z}

        private void treeListView1_AfterExpand(object sender, TreeListViewEventArgs e)
        {

        }

        private void treeListView1_AfterLabelEdit(object sender, TreeListViewLabelEditEventArgs e)
        {
            MessageBox.Show(string.Format("编辑之前的值：{0}，编辑之后的值：{1}",e.LabelOld,e.Label));
        }
    }
}
