using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike
{
    public partial class Stsyemfrm : Form
    {
        public Stsyemfrm()
        {
            InitializeComponent();
        }

        private void btnshes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stsyemfrm_Load(object sender, EventArgs e)
        {
            txtmd.Text = DBHellper.mainname;
            txtpf.Text = DBHellper.pfs;
            txtimg.Text = "Resources/main_bg.jpg";
            txte.Text = "1500";
          
        }

        private void btnqd_Click(object sender, EventArgs e)
        {
            if (txtimg.Text != "Resources/main_bg.jpg")
            {
                MessageBox.Show("不能修改图片路径！");
                return;
            }
            else {
                this.Close();
                if (DBHellper.fg == "下拉式")
                {
                    Main frm = new Main();
                    frm.Text = txtmd.Text;
                    frm.pf = txtpf.Text;
                
                }
                else
                {
                    Mainsfrm frs = new Mainsfrm();
                    frs.Text = txtmd.Text;
                    frs.pf = txtimg.Text;

                }
              MessageBox.Show("修改成功！");
             
            }
        }
    }
}
