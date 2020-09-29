namespace FileExplorer
{
    partial class ImageShowForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelImageName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.Location = new System.Drawing.Point(12, 39);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(620, 360);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(557, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelImageName
            // 
            this.labelImageName.AutoSize = true;
            this.labelImageName.Location = new System.Drawing.Point(12, 13);
            this.labelImageName.Name = "labelImageName";
            this.labelImageName.Size = new System.Drawing.Size(53, 13);
            this.labelImageName.TabIndex = 2;
            this.labelImageName.Text = "Tên ảnh: ";
            // 
            // ImageShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.labelImageName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox);
            this.Name = "ImageShowForm";
            this.Text = "Hiển thị ảnh";
            this.Load += new System.EventHandler(this.ImageShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label labelImageName;
    }
}