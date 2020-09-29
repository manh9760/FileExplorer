namespace FileExplorer
{
    partial class FileExplorerApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorerApp));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imgListTreeView = new System.Windows.Forms.ImageList(this.components);
            this.btnShowImage = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.imgListListView = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnShowImage);
            this.splitContainer1.Panel2.Controls.Add(this.labelFilePath);
            this.splitContainer1.Panel2.Controls.Add(this.listView);
            this.splitContainer1.Size = new System.Drawing.Size(660, 450);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imgListTreeView;
            this.treeView.Location = new System.Drawing.Point(18, 15);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(190, 394);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // imgListTreeView
            // 
            this.imgListTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListTreeView.ImageStream")));
            this.imgListTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListTreeView.Images.SetKeyName(0, "folder-vector-icon.jpg");
            // 
            // btnShowImage
            // 
            this.btnShowImage.Location = new System.Drawing.Point(346, 394);
            this.btnShowImage.Name = "btnShowImage";
            this.btnShowImage.Size = new System.Drawing.Size(75, 23);
            this.btnShowImage.TabIndex = 3;
            this.btnShowImage.Text = "Xem";
            this.btnShowImage.UseVisualStyleBackColor = true;
            this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(22, 394);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(0, 13);
            this.labelFilePath.TabIndex = 2;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.imgListListView;
            this.listView.Location = new System.Drawing.Point(17, 14);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(404, 359);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
            // 
            // imgListListView
            // 
            this.imgListListView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListListView.ImageStream")));
            this.imgListListView.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListListView.Images.SetKeyName(0, "folder-vector-icon.jpg");
            this.imgListListView.Images.SetKeyName(1, "mmm.png");
            // 
            // FileExplorerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FileExplorerApp";
            this.Text = "Ứng dụng File Explorer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Button btnShowImage;
        private System.Windows.Forms.ImageList imgListTreeView;
        private System.Windows.Forms.ImageList imgListListView;
    }
}

