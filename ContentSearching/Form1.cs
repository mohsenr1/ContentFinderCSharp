using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace ContentSearching
{
    public partial class frmMain : Form
    {



        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGetDirectory_Click(object sender, EventArgs e)
        {
            string path = "";

            //این فولدر بروسر برای انتخاب فولدری است که می خواهیم جستجو در آن انجام شود.
            FolderBrowserDialog fbd;
            fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
                txtDirectory.Text = path;
                panel1.Enabled = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvResualts.Rows.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(txtDirectory.Text);

            //ببین کاربر عبارتی برای جستجو وارد کرده یا نه
            if (txtPhrase.Text != "")
            {
                //ببین دایرکتوری نوشته شده معتبر است یا نه
                if (dirInfo.Exists)
                {
                    ArrayList mainArrayList = returnContentsOfDirectory(txtDirectory.Text);

                    //ببین فایلی در دایرکتوری با فرمت اتخاب شده وجود دارد یا نه
                    if (mainArrayList.Count > 0)
                    {


                        int count = 0;
                        //به ازای هر فایل در آن دایرکتوری با پسوند داده شده
                        foreach (Files file in mainArrayList)
                        {
                            int FirstChr = FirstChr = file.Content.ToUpper().IndexOf(txtPhrase.Text.ToUpper());
                            //اگر تعداد عبارات داده شده برای جستجو توسط کاربر با محتوای فایل برابر بود فایل را در دیتا گرید نمایش بده
                            
                            if (FirstChr >= 0)
                            {
                                this.dgvResualts.Rows.Add();
                                this.dgvResualts.Rows[count].Cells[0].Value = file.Path;
                                this.dgvResualts.Rows[count].Cells[1].Value = file.Content;
                                count++;
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("دایرکتوری مورد نظر فاقد فایل با فرمت HTML است!)");
                    }
                }
                else
                {
                    MessageBox.Show("دایرکتوری وارد شده صحیح نیست. لطفا آن را چک کنید.");
                }
            }
            else
            {
                MessageBox.Show("شما باید عبارتی برای جستجو وارد کنید!");
            }
        }

        public ArrayList returnContentsOfDirectory(string path)
        {
             ArrayList fileContents = new ArrayList();

             DirectoryInfo di = new DirectoryInfo(path);
             FileInfo[] rgFiles = di.GetFiles("*.*", SearchOption.AllDirectories);

             
             StreamReader rd;
             foreach (FileInfo fi in rgFiles)
             {
                 
                 rd = new StreamReader(fi.FullName,Encoding.UTF8);
                 string content = rd.ReadToEnd();
                 rd.Close();
                 Files file = new Files();
                 file.Content = content;
                 file.Path = fi.FullName;
                 fileContents.Add(file);
             }
             
             return fileContents;
        }

        private void dgvResualts_SelectionChanged(object sender, EventArgs e)
        {
            
            foreach (DataGridViewCell cell in ((DataGridView)sender).SelectedCells)
            {
                cell.Style = new DataGridViewCellStyle()
                {
                    BackColor = Color.White,
                    Font = new Font("Tahoma", 8F),
                    ForeColor = SystemColors.WindowText,
                    SelectionBackColor = Color.Khaki,
                    SelectionForeColor = Color.MistyRose,
                };
            }
        }

        private void dgvResualts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
                System.Diagnostics.Process.Start(dgvResualts.CurrentRow.Cells[0].Value.ToString());
        }

        private void dgvResualts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Process.Start(dgvResualts.CurrentRow.Cells[0].Value.ToString());
        }

        private void بازکردنفولدردرپنجرهجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("explorer.exe"," /select, \""+ @dgvResualts.CurrentRow.Cells[0].Value.ToString()+"\"");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvResualts.SelectedCells.Count>0)
            {
                بازکردنفولدردرپنجرهجدیدToolStripMenuItem.Enabled = true;

            }
            else 
            {
                بازکردنفولدردرپنجرهجدیدToolStripMenuItem.Enabled = false;
            }
        }
    }
}
