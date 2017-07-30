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
    public partial class Mainsfrm : Form
    {
        public string pf = "WaveColor1";
        public Mainsfrm()
        {
            InitializeComponent();
            skinEngine1.SkinFile = string.Format("ssk\\"+pf+".ssk");
        }

        private void Mainsfrm_Load(object sender, System.EventArgs e)
        {
            DBHellper.pfs = pf;
            DBHellper.mainname=this.Text;
            DBHellper.nams = lalxt.Text;
            string sql1 = "select * from Salesman where Mobile='" + DBHellper.name + "'";
            DataTable name = DBHellper.GetdataTable(sql1);
            foreach (DataRow item1 in name.Rows)
            {
                if (DBHellper.name == item1["Mobile"].ToString())
                {
                    this.lalname.Text = item1["SalesmanName"].ToString() + item1["role"].ToString() + "欢迎你！";
                    DBHellper.salesmanname = item1["SalesmanName"].ToString();
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

        private void cbopf_KeyDown(object sender, KeyEventArgs e)
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

        private void Mainsfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re = MessageBox.Show("确定要关闭程序？", "提示：", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Collect frm = new Collect();
            frm.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Putfrm frm = new Putfrm();
            frm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Browsefrm frm = new Browsefrm();
            frm.ShowDialog();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Salaryfrm frm = new Salaryfrm();
            frm.ShowDialog();
            lalxt.Text = DBHellper.nams;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Salesfrm frm = new Salesfrm();
            frm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Tgoodsfrm frm = new Tgoodsfrm();
            frm.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Classifyfrm frm = new Classifyfrm();
            frm.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Staffrm frm = new Staffrm();
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UpdatePwdfrm frm = new UpdatePwdfrm();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Stsyemfrm frm = new Stsyemfrm();
            frm.Show();
        }

  

    }
}
