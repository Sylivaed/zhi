using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nike
{
    public partial class Main : Form
    {
        public string pf = "WaveColor1";
        public Main()
        {
            InitializeComponent();
            
            skinEngine1.SkinFile = string.Format("ssk\\"+pf+".ssk");
            DBHellper.pfs = pf;
        }

        private void Main_Load(object sender, EventArgs e)
        {
             DBHellper.mainname=this.Text;
            
            string sql1 = "select * from Salesman where Mobile='" + DBHellper.name + "'";
            DataTable name = DBHellper.GetdataTable(sql1);
            foreach (DataRow item1 in name.Rows)
            {
                if (DBHellper.name == item1["Mobile"].ToString())
                {
                    this.toolname.Text = item1["SalesmanName"].ToString()+item1["role"].ToString() + "欢迎你！";
                }
            }


            DirectoryInfo my = new DirectoryInfo("ssk\\");
            foreach (FileSystemInfo fsi in my.GetFileSystemInfos())
            {
                if (fsi is FileInfo)
                {

                    FileInfo fi = (FileInfo)fsi;
                    string s = System.IO.Path.GetExtension(fi.FullName);
                    string y = System.IO.Path.GetFileNameWithoutExtension(fi.FullName);
                    if (s == ".ssk")
                    {

                        this.cbopf.Items.Add(y);

                    }
                }

            }
        }

        private void 收银台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Collect frm = new Collect();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Collect frm = new Collect();
            frm.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Collect frm = new Collect();
            frm.Show();
        }

        private void 商品入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Putfrm frm = new Putfrm();
            frm.Show();

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Collect frm = new Collect();
            frm.Show();
        }

        private void 商品浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browsefrm frm = new Browsefrm();
            frm.ShowDialog();
        }


        private void cbopf_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }

        private void 工资核算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salaryfrm frm = new Salaryfrm();
            frm.Show();
        }

        private void cbopf_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DirectoryInfo my = new DirectoryInfo("ssk\\");
                foreach (FileSystemInfo fsi in my.GetFileSystemInfos())
                {
                    if (fsi is FileInfo)
                    {

                        FileInfo fi = (FileInfo)fsi;
                        string s = System.IO.Path.GetExtension(fi.FullName);
                        string y = System.IO.Path.GetFileNameWithoutExtension(fi.FullName);
                        if (s == ".ssk")
                        {

                            this.cbopf.Items.Add(y);
                        }
                    }
                }
                skinEngine1.SkinFile = string.Format("ssk\\{0}.ssk", this.cbopf.Text);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re = MessageBox.Show("确定要关闭程序？","提示：",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
               Application.ExitThread();
            }
            else {
                e.Cancel = true;
            }
        }

        private void 退货ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tgoodsfrm frm = new Tgoodsfrm();
            frm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Tgoodsfrm frm = new Tgoodsfrm();
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Putfrm frm = new Putfrm();
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Browsefrm frm = new Browsefrm();
            frm.ShowDialog();
        }

        private void 商品分类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classifyfrm frm = new Classifyfrm();
            frm.Show();
        }

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staffrm frm = new Staffrm();
            frm.Show();
        }

        private void 系统配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stsyemfrm frm = new Stsyemfrm();
            frm.ShowDialog();
            
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePwdfrm frm = new UpdatePwdfrm();
            frm.Show();
        }
    }
}
