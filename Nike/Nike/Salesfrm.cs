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
    public partial class Salesfrm : Form
    {
        public Salesfrm()
        {
            InitializeComponent();
        }

        private void Salesfrm_Load(object sender, EventArgs e)
        {
            string sql = "select distinct * from salesman where role='导购员'";
            DataTable dt = DBHellper.GetdataTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                cbosales.Items.Add(item["salesmanname"].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int day = now.Day;
            switch (this.coblm.Text)
            {
                case "本日": this.dtms.Value = now;
                    this.dtmx.Value = now;
                    break;
                case "本周":
                    int dayofweek = (int)now.DayOfWeek;
                    if (dayofweek == 0) dayofweek = 7;

                    this.dtms.Value = now.AddDays(-dayofweek + 1);
                    this.dtmx.Value = now.AddDays(-dayofweek + 1 + 6);
                    break;
                case "本月":


                    this.dtms.Value = now.AddDays(-day + 1);
                    this.dtmx.Value = now.AddDays(-day + 1).AddMonths(1).AddDays(-1);
                    break;
                case "上月":

                    this.dtms.Value = now.AddDays(-day + 1);
                    this.dtmx.Value = now.AddDays(-day + 1).AddDays(-1);
                    break;
                case "本年":
                    int dayofyear = now.DayOfYear;



                    this.dtms.Value = now.AddDays(-dayofyear + 1);
                    this.dtmx.Value = now.AddDays(-dayofyear + 1).AddYears(1).AddYears(-1);
                    break;
                default: break;
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string sql = "select *,aloneamount-quantity*storeprice as a from Sales,SalesDetail,goods,Salesman where Sales.SalesID=SalesDetail.SalesID and Goods.GoodsID=SalesDetail.GoodsID and Salesman.SalesmanID=Sales.SalesmanID ";
            if (cbosales.Text != "") {
                sql += " and salesmanname='" + cbosales.Text + "'";
            
            }
            if (coblm.Text != "")
            {
                if (coblm.Text == "本日")
                {
                    sql += " and StockDate >='" + dtms.Text + "'  and StockDate<='" + dtmx.Text + "'";
                }
                if (coblm.Text == "本周")
                {
                    sql += " and StockDate>='" + dtms.Text + "'  and StockDate<='" + dtmx.Text + "'";
                }
                if (coblm.Text == "本月")
                {
                    sql += " and StockDate>='" + dtms.Text + "'  and StockDate<='" + dtmx.Text + "'";
                }
                if (coblm.Text == "上月")
                {
                    sql += " and StockDate>='" + dtms.Text + "'  and StockDate<='" + dtmx.Text + "'";
                }
                if (coblm.Text == "本年")
                {
                    sql += " and StockDate>='" + dtms.Text + "'  and StockDate<='" + dtmx.Text + "'";
                }

            }
          DataTable dt= DBHellper.GetdataTable(sql);
          int i = 0;
          double a = 0;
            double  b=0;
          foreach (DataRow item in dt.Rows)
          {
              ListViewItem root = new ListViewItem(item["receiptscode"].ToString());
              root.SubItems.Add(item["salesdate"].ToString());
              root.SubItems.Add(item["aloneamount"].ToString());
              root.SubItems.Add(item["a"].ToString());
              root.SubItems.Add(item["salesmanname"].ToString());
              root.SubItems.Add(DBHellper.salesmanname);
              this.listView1.Items.Add(root);
              i++;
              a += double.Parse(item["aloneamount"].ToString());
              b += double.Parse(item["a"].ToString());
              laljl.Text = "销售记录"+i+"条";
              lalje.Text = "销售金额￥"+a+"元，利润￥"+b+"元";
          }
        }
    }
}
