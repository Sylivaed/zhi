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
    public partial class Putfrm : Form
    {
        public Putfrm()
        {
            InitializeComponent();
        }

        private void btnqx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Putfrm_Load(object sender, EventArgs e)
        {

            string sql = "select * from Type where ParentID=0";
            DataTable dr = DBHellper.GetdataTable(sql);
            foreach (DataRow item in dr.Rows)
            {
                this.cbol.Items.Add(item["typename"].ToString());
                
            }
           

        }

        private void btnrk_Click(object sender, EventArgs e)
        {
            int i = 0;
            ruku();
            i++;
            if(i>0){
                txthh.Text ="";
                txtname.Text = "";
                txtjg.Text = "";
                txtls.Text = "";
                txtzk.Text = "";
                txtsl.Text = "";
                cbol.Text = "";
                cbox.Text = "";
            }
            
        }
        public void ruku() {

            string hh = txthh.Text;
            string name = txtname.Text;
            string sqlc = "select typeid from Type where typename='" + this.cbox.Text + "'";
            DataTable dr = DBHellper.GetdataTable(sqlc);
            string lb = "";
            foreach (DataRow item in dr.Rows)
            {
                lb = item["typeid"].ToString();
            }
            string jg = txtjg.Text;
            string ls = txtls.Text;
            string zk = txtzk.Text;
            string sl = txtsl.Text;
            string lx = cbol.Text;
            string xsl = cbox.Text;
            if (hh == "" || name == "" || jg == "" || ls == "" || zk == "" || sl == ""||lx==""||xsl=="")
            {
                MessageBox.Show("你的入库信息填写不完整！");

            }
            string sql = string.Format("insert into Goods values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','')", hh, lb, name, jg, ls, zk, sl);
            int i = DBHellper.ExecuteNonQuery(sql);
            if (i > 0)
            {
                MessageBox.Show("已成功入库！");
            }
            else
            {
                MessageBox.Show("入库失败！");
            }
        }

        private void cobl_TextChanged(object sender, EventArgs e)
        {
            cbox.Items.Clear();

            if (cbol.Text != "")
            {

                string cbosqlb = "select * from  type where ParentID=(select TypeID  from type where TypeName='" + cbol.Text + "')";
                DataTable dta = DBHellper.GetdataTable(cbosqlb);
                foreach (DataRow item in dta.Rows)
                {
                    cbox.Items.Add(item["TypeName"].ToString());
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select BarCode from goods";
            DataTable dr = DBHellper.GetdataTable(sql);
            foreach (DataRow item in dr.Rows)
            {
                if (item["BarCode"].ToString() == txthh.Text) {
                    MessageBox.Show("此货号已经存在！");
                    return;
                }

            }
            MessageBox.Show("读取成功！");
        }
    }
}
