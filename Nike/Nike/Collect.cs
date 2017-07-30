using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;

namespace Nike
{
    public partial class Collect : Form
    {
        int i = 0;
        public Collect()
        {
            InitializeComponent();
        }

        private void list_show_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Collect_Load(object sender, EventArgs e)
        {


        








            //小票流水号
            this.lalliushui.Text = DateTime.Now.ToString("yyyyMMddhhmmss");
            string sql = "select Salesmanname from Salesman where Role='导购员'";
            DataTable s = DBHellper.GetdataTable(sql);
            foreach (DataRow data in s.Rows)
            {
                //绑定值
                this.comboxdg.Items.Add(data[0].ToString());
            }


        }

        private static void showcha(string shwd)
        {
            SpeechLib.SpVoice voice = new SpVoice();
            SpeechLib.SpeechVoiceSpeakFlags sVSFDefault = SpeechVoiceSpeakFlags.SVSFDefault;
            voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
            
            voice.Speak(shwd, sVSFDefault);
        }

        private void comboxdg_SelectedIndexChanged(object sender, EventArgs e)
        {

          

        }

        private void laltxm_TextChanged(object sender, EventArgs e)
        {

        }

        private void laltxm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                InitListViewed();
                i++;
                string sql = "select BarCode, GoodsName,TypeName,SalePrice,Discount,SalesmanName,Discount*SalePrice*'" + i + "'as a from Goods,Type,Salesman where Goods.TypeID=Type.TypeID  and BarCode='" + this.laltxm.Text + "' and Mobile='" + DBHellper.name + "'";
                DataTable row=DBHellper.GetdataTable(sql);
                foreach(DataRow item in row.Rows)
                {

                    ListViewItem ite = new ListViewItem(item["BarCode"].ToString());
                    ite.SubItems.Add(item["GoodsName"].ToString());
                    ite.SubItems.Add(item["TypeName"].ToString());
                    ite.SubItems.Add(item["SalePrice"].ToString());
            
                    ite.SubItems.Add(item["Discount"].ToString());
                    ite.SubItems.Add(double.Parse(item["a"].ToString()).ToString("f2"));
                    ite.SubItems.Add(i.ToString());
                    this.list_show.Items.Add(ite);
                    this.lalmonye.Text = double.Parse( item["a"].ToString()).ToString("f2");
                    this.textBoxys.Text = double.Parse(item["a"].ToString()).ToString("f2");
                    this.labelsps.Text = i.ToString();
                 }
                string sql1 = "select * from Salesman where Mobile='"+DBHellper.name+"'";
                DataTable name = DBHellper.GetdataTable(sql1);
                foreach (DataRow item1 in name.Rows)
                {
                    if(DBHellper.name==item1["Mobile"].ToString()){
                    this.labsy.Text="收银员:"+item1["SalesmanName"].ToString();
                    }
                }
            }
            

        }
        private void InitListViewed()
        {
            //在这里面就可以进行ListView控件的构建以及数据更新等
            list_show.Items.Clear();
        }
        private void btnjs_Click(object sender, EventArgs e)
        {
            shownod();
        }

        private void shownod()
        {
            try
            {
                double ys = double.Parse(this.textBoxys.Text);
                double ss = double.Parse(this.textBoxss.Text.Trim());
                textBoxzl.Text = (ss - ys).ToString();
                if (comboxdg.Text == "- -请选择- -")
                {
                    MessageBox.Show("请选择导购员！");
                    return;

                }
                string sqla = string.Format("select * from Salesman where salesmanname='{0}'", comboxdg.Text);
                DataTable dt = DBHellper.GetdataTable(sqla);
                string salesmanid = "";
                foreach (DataRow item in dt.Rows)
                {
                    salesmanid = item["salesmanid"].ToString();
                }

                string sqlb = string.Format("select * from Salesman where mobile='{0}'", DBHellper.name);
                DataTable de = DBHellper.GetdataTable(sqlb);
                string nameid = "";
                foreach (DataRow item in de.Rows)
                {
                    nameid = item["salesmanid"].ToString();
                }
                if (ys > ss)
                {
                    MessageBox.Show("你的金额不足！");
                    return;
                }


                string sql = string.Format("insert into sales(ReceiptsCode,Amount,SalesmanID,CashierID) values('{0}','{1}','{2}','{3}')", lalliushui.Text, textBoxys.Text, salesmanid, nameid);
                int r = DBHellper.ExecuteNonQuery(sql);
                string sqlj = string.Format("select * from sales where ReceiptsCode='{0}'", lalliushui.Text);
                DataTable dj = DBHellper.GetdataTable(sqlj);
                string salesid = "";
                foreach (DataRow item in dj.Rows)
                {
                    salesid = item["SalesID"].ToString();
                }
                string sqlo = "select *  from goods where BarCode='" + laltxm.Text + "'";
                DataTable d = DBHellper.GetdataTable(sqlo);
                string goodid = "";
                foreach (DataRow item in d.Rows)
                {
                    goodid = item["goodsid"].ToString();
                }
                string sqlm = string.Format("insert into SalesDetail(SalesID,GoodsID,Quantity,AloneAmount) values('{0}','{1}','{2}','{3}')", salesid, goodid, labelsps.Text, textBoxys.Text);
                int m = DBHellper.ExecuteNonQuery(sqlm);
                string sqlg = "update Goods set StockNum=StockNum-'" + i + "' where GoodsID='" + goodid + "'";

                int g = DBHellper.ExecuteNonQuery(sqlg);
                if (r > 0 && m > 0 && g > 0)
                {

                    string shw = @"应收" + textBoxys.Text + "实收" + textBoxss.Text + "找零" + textBoxzl.Text + "";

                    MessageBox.Show("结算成功！");
                    showcha(shw);
                }
                else
                {
                    MessageBox.Show("结算失败！");
                }
            }
            catch {
                MessageBox.Show("请选择要购买的商品！");
            }
        }
    }
}
