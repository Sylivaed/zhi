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
    public partial class UpdatePwdfrm : Form
    {
        public UpdatePwdfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqls = "select * from salesman where Mobile='" + DBHellper.name + "' ";
            DataTable dt = DBHellper.GetdataTable(sqls);
            foreach (DataRow item in dt.Rows)
            {
                if (TXTpwd.Text != item["pwd"].ToString()) {
                    MessageBox.Show("你的原密码输入错误");
                    TXTpwd.Text = "";
                    return;
                }
            }
            if (txtpwds.Text != TXTpwdq.Text) {
                MessageBox.Show("两次密码不一致！");
                txtpwds.Text = "";
                TXTpwdq.Text = "";
                return;

            }
            string sql = "update  salesman set pwd='"+txtpwds.Text+"' where Mobile='"+DBHellper.name+"'";
            int i = DBHellper.ExecuteNonQuery(sql);
            if (i > 0)
            {
                MessageBox.Show("修改成功！\n请退出系统重新登录！");
                Application.Exit();
            }
            else {
                MessageBox.Show("修改失败！");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
