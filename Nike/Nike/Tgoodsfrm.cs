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
    public partial class Tgoodsfrm : Form
    {
        public Tgoodsfrm()
        {
            InitializeComponent();
        }

        private void btncx_Click(object sender, EventArgs e)
        {
            InitListViewed();
            intishow();



        }
        //调用InitListView()，便可以对ListView控件进行自由更新啦
       
        private void InitListViewed()
        {
            //在这里面就可以进行ListView控件的构建以及数据更新等
            lvwshow.Items.Clear();
        }

        private void intishow()
        {
            if (txtxp.Text == "")
            {
                MessageBox.Show("请输入退货的小票流水号！");
                return;

            }
            string sql = "select BarCode,GoodsName,AloneAmount,Quantity,SalesmanName,SalesDate from Sales,SalesDetail,goods,Salesman where Sales.SalesID=SalesDetail.SalesID and Goods.GoodsID=SalesDetail.GoodsID and Salesman.SalesmanID=Sales.SalesmanID and ReceiptsCode='" + txtxp.Text + "'";
            DataTable dt = DBHellper.GetdataTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                ListViewItem root = new ListViewItem(item["BarCode"].ToString());
                root.SubItems.Add(item["GoodsName"].ToString());
                root.SubItems.Add(item["AloneAmount"].ToString());
                root.SubItems.Add(item["Quantity"].ToString());
                root.SubItems.Add(item["SalesmanName"].ToString());
                root.SubItems.Add(item["SalesDate"].ToString());
                this.lvwshow.Items.Add(root);
                laljy.Text = "交易金额:￥" + item["AloneAmount"].ToString() + "";
                lalth.Text = "退款金额:￥" + item["AloneAmount"].ToString() + "";
            }

        }

        private void btnqx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnth_Click(object sender, EventArgs e)
        {
            int i = 0;
            Toogs();
            i++;
            if (i > 0) {
                txtxp.Text = "";
                InitListViewed();
                laljy.Text = "交易金额:￥0.00";
                lalth.Text = "退款金额:￥0.00";
            }
        }
        private void Toogs()
        {
            try
            {
                string sql = "delete Sales where ReceiptsCode ='" + txtxp.Text + "'";
                string sqa = "select SalesID from Sales where ReceiptsCode='" + txtxp.Text + "'";
                string a = DBHellper.ExecuteScalar(sqa).ToString();
                string sqls = "select goods.GoodsID from Sales,SalesDetail,goods,Salesman where Sales.SalesID=SalesDetail.SalesID and Goods.GoodsID=SalesDetail.GoodsID and Salesman.SalesmanID=Sales.SalesmanID and ReceiptsCode='" + txtxp.Text + "'";
                string goodsid = DBHellper.ExecuteScalar(sqls).ToString();
                string sqlb = "select Quantity from Sales,SalesDetail,goods,Salesman where Sales.SalesID=SalesDetail.SalesID and Goods.GoodsID=SalesDetail.GoodsID and Salesman.SalesmanID=Sales.SalesmanID and ReceiptsCode='" + txtxp.Text + "'";
                string sum = DBHellper.ExecuteScalar(sqlb).ToString();
                string sqlg = "update Goods set StockNum=StockNum+'" + sum + "' where GoodsID='" + goodsid + "'";
                int g = DBHellper.ExecuteNonQuery(sqlg);

                string sqs = "delete SalesDetail where SalesID='" + a + "'";
                int s = DBHellper.ExecuteNonQuery(sqs);
                int i = DBHellper.ExecuteNonQuery(sql);

                if (i > 0 && s > 0 && g > 0)
                {
                    MessageBox.Show("退货成功！");

                }
                else
                {
                    MessageBox.Show("退货失败！");
                }
            }
            catch
            {
                MessageBox.Show("亲 你没有退货商品！");

            }
        }

        private void Tgoodsfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
