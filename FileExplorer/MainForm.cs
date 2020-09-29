using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

/* 
    Họ tên: Nguyễn Văn Mạnh
    Mã số SV: 0450080109
    Lớp (Học ghép): 07_ĐHCNTT2
    GV hướng dẫn: ThS. Hà Thanh Dũng

 1. Chương trình giả lập chức năng File Explorer trên Windows
 2. Sử dụng TreeView và ListView
 3. Thực hiện chức năng show (hiển thị) "FILE ẢNH" 
    khi người dùng nhấn double click chuột/chọn chức năng xem trên form,
    file ảnh mẫu được lưu tại:
    FileExplorer/
    -- images/
       -- animals/
       -- covid-19/
       -- humans/
       -- plants/
*/
namespace FileExplorer
{
    public partial class FileExplorerApp : Form
    {
        // Hàm khởi tạo
        public FileExplorerApp()
        {
            InitializeComponent();
            PopulateTreeView();
            this.treeView.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
        }

        // Chọn vị trí gốc cho thư mục
        // Lấy thư mục project (FileExplorer) làm thư mục gốc
        private void PopulateTreeView()
        {
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(@"../..");

            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach(DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if(subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            } 
        }

        // Xử lý khi người dùng click chuột vào các item trên TreeView
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };

            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[] {
                    new ListViewItem.ListViewSubItem(item, "File"),
                    new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())
                };

                // Lấy đường dẫn cho thư mục hiện tại
                string pathFile = e.Node.FullPath + @"\";
                this.labelFilePath.Text = string.Format("Đường dẫn: {0}", pathFile);
         
                item.SubItems.AddRange(subItems);
                // Kiểm tra nếu là file ảnh thì thêm vào ListView
                if (ImageExtensions.Contains(Path.GetExtension(file.ToString()).ToUpperInvariant()))
                {
                    listView.Items.Add(item);
                }

            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        // Xử lý khi người dùng trỏ chuột vào item trong ListView
        private void listView_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                string labelFilePath = treeView.SelectedNode.FullPath;
                string imageSelectedName = listView.FocusedItem.Text;

                /* 
                 Đường dẫn sẽ khác nhau trên mỗi máy tính
                 Nên cần lấy đường dẫn gốc (exePath) --> khi chạy chương trình trên máy khác
                */
                // exePath = "D:\DATA\C_Sharp\FileExplorer\FileExplorer\bin\Debug"
                string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

                /* 
                    Sử dụng Directory.GetParent để lùi về 1 thư mục
                    --> exePath1 = "D:\DATA\C_Sharp\FileExplorer\FileExplorer\bin"
                    --> exePath2 = "D:\DATA\C_Sharp\FileExplorer\FileExplorer"
                    --> exePath3 = "D:\DATA\C_Sharp\FileExplorer"
                */
                string exePath1 = Directory.GetParent(exePath).FullName;
                string exePath2 = Directory.GetParent(exePath1).FullName;
                string exePath3 = Directory.GetParent(exePath2).FullName;
                string filePath = exePath3 + "\\" + labelFilePath + "\\" + imageSelectedName;

                // Gọi đến form khác (ImageShowForm) để hiển thị ảnh
                ImageShowForm imageShowForm = new ImageShowForm();

                // Set ảnh cho thuộc tính pictureBox cho form ImageShowForm
                imageShowForm.pictureBox.Image = Image.FromFile(filePath);

                // Set label cho tên ảnh ở form mới (form dùng để hiển thị ảnh)
                imageShowForm.labelImageName.Text += imageSelectedName;

                // Chọn cách căn chỉnh độ lớn của ảnh truyền vào PictureBox và show ra
                imageShowForm.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                imageShowForm.ShowDialog();
            }
            // Chương trình chỉ hiển thị ảnh, không hiển thị thư mục hoặc file.
            // => Bắt lỗi nếu người dùng chọn hiển thị thư mục hoặc file
            catch (Exception ex)
            {
                MessageBox.Show("Chương trình chỉ hiển thị ảnh!", "Thông báo");
            }
        }

        // Xử lý khi người dùng nhấn nút "Xem", sẽ gọi lại hàm xử lý ở trên
        private void btnShowImage_Click(object sender, EventArgs e)
        {
            listView_ItemActivate(sender, e);
        }
    }
}
