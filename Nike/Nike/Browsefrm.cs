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
    public partial class Browsefrm : Form
    {
        public Browsefrm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime now =DateTime.Now;
            int day = now.Day;  
            switch (this.coblm.Text)
            {
                case "本日": this.dtms.Value = now;
                    this.dtmx.Value = now;
                    break;
                case "本周":
                    int dayofweek = (int)now.DayOfWeek;
                    if(dayofweek==0)dayofweek=7;
                    
                   this.dtms.Value = now.AddDays(-dayofweek+1);
                    this.dtmx.Value = now.AddDays(-dayofweek+1+6);
                    break;
                case "本月":
                    

                    this.dtms.Value = now.AddDays(-day+1);
                    this.dtmx.Value = now.AddDays(-day + 1).AddMonths(1).AddDays(-1);
                    break;
                case "上月":

                    this.dtms.Value = now.AddDays(-day + 1);
                    this.dtmx.Value = now.AddDays(-day + 1).AddDays(-1);
                    break;
                case "本年":
                    int dayofyear = now.DayOfYear;

                    
                    
                    this.dtms.Value = now.AddDays(-dayofyear+1);
                    this.dtmx.Value = now.AddDays(-dayofyear + 1).AddYears(1).AddYears(-1);
                    break;
            default:break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            InitListViewed();
            ingen();
}

      
    
        private void ingen()
        {
            
            string sql = "select * from Goods,Type where Goods.TypeID=Type.TypeID ";
            string hh = txthh.Text;
            if (txthh.Text != "")
            {
                sql += "and BarCode like'%" + hh + "%'";

            }
            string name = txtname.Text;
            if(name!=""){

                sql += " and GoodsName like'%" + name + "%'";
            
            }
            if(coblm.Text!=""){
                if (coblm.Text == "本日") {
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
            if (cobyj.Text != "")
            {
                sql += " and ParentID=(select TypeID  from type where TypeName='" + cobyj.Text + "')";
            }
            if (cobej.Text != "")
            {

                sql += " and typename='" + cobej.Text + "'";
            }
            



            DataTable dr = DBHellper.GetdataTable(sql);
            int i = 0;
            foreach (DataRow item in dr.Rows)
            {
                
                ListViewItem root = new ListViewItem(item["GoodsID"].ToString());
                root.SubItems.Add(item["BarCode"].ToString());
                root.SubItems.Add(item["GoodsName"].ToString());
                root.SubItems.Add(item["TypeName"].ToString());
                root.SubItems.Add(item["StorePrice"].ToString());
                root.SubItems.Add(item["SalePrice"].ToString());
                root.SubItems.Add(item["Discount"].ToString());
                root.SubItems.Add(item["StockNum"].ToString());
                root.SubItems.Add(item["StockDate"].ToString());
                this.listView1.Items.Add(root);
                i++;
              
              
            }
            lalsj.Text = "当前共" + i + "条数据";
            if (listView1.Items == null)
            {
                lalsj.Text = "当前共0条数据";
            }

       
         
           
        }
        private void InitListViewed()
        {
            //在这里面就可以进行ListView控件的构建以及数据更新等
            listView1.Items.Clear();
        }
        private void Browsefrm_Load(object sender, EventArgs e)
        {
            string cbosql = "select TypeName from  type where ParentID=0";
            DataTable dt = DBHellper.GetdataTable(cbosql);
            foreach (DataRow item in dt.Rows)
            {
                cobyj.Items.Add(item["TypeName"].ToString());
            }
            
        }


        private void cobyj_TextChanged(object sender, EventArgs e)
        {
            cobej.Items.Clear();
            
            if (cobyj.Text != "")
            {
                
                string cbosqlb = "select * from  type where ParentID=(select TypeID  from type where TypeName='" + cobyj.Text + "')";
                DataTable dta = DBHellper.GetdataTable(cbosqlb);
                foreach (DataRow item in dta.Rows)
                {
                    cobej.Items.Add(item["TypeName"].ToString());
                }
               
            }
        }

      
    }
}
