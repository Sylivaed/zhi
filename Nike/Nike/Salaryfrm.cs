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
    public partial class Salaryfrm : Form
    {
        public Salaryfrm()
        {
            InitializeComponent();
        }

        private void Salaryfrm_Load(object sender, EventArgs e)
        {

           

        }

        private void elseif(bool p)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int day = now.Day;
            switch (this.coblm.Text)
            {
          
                case "当前月":


                    this.dtms.Value = now.AddDays(-day + 1);
                    this.dtmx.Value = now.AddDays(-day + 1).AddMonths(1).AddDays(-1);
                    break;
                case "上月":

                    this.dtms.Value = now.AddDays(-day + 1);
                    this.dtmx.Value = now.AddDays(-day + 1).AddDays(-1);
                    break;
           
                default: break;
            }
        }
        private void InitListViewed()
        {
            //在这里面就可以进行ListView控件的构建以及数据更新等
            lvwshow.Items.Clear();
        }
        public int i=0;
        private void button1_Click(object sender, EventArgs e)
        {
          
        
            //string sql = "select * from malesman ";

            string sql = "select * from salesman ";
            this.dtms.CustomFormat = "yyyy-MM-dd";

            this.dtmx.CustomFormat = "yyyy-MM-dd";
            if (i > 0)
            {
                InitListViewed();

            }
           
            DataTable dt = DBHellper.GetdataTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                ListViewItem root = new ListViewItem(item["SalesmanName"].ToString());
                root.SubItems.Add(item["role"].ToString());
                root.SubItems.Add(item["Mobile"].ToString());
                root.SubItems.Add(item["BaseSalary"].ToString());
                root.SubItems.Add(item["CommissionRate"].ToString());
                double yfgz = 0;
                string b = "";
                if (item["role"].ToString() == "店长")
                {

                    string sqls = string.Format("select sum(sales.amount)-1500 as b from  sales,salesman where sales.salesmanid=salesman.salesmanid and salesdate between '{0}' and'{1}'",
                dtms.Text, dtmx.Text);

                    DataTable dts = DBHellper.GetdataTable(sqls);
                    foreach (DataRow items in dts.Rows)
                    {
                        if (items["b"].ToString() == "")
                        {
                            b = "0.00";
                        }
                        else
                        {
                            b = items["b"].ToString();

                        }

                    }
                    root.SubItems.Add(b);
                    yfgz = double.Parse(b.ToString());
                }

                else if (item["role"].ToString() == "导购员")
                {

                    string sqlstr = string.Format("select sum(Sales.Amount) as b from Sales,salesman  where sales.salesmanid=salesman.salesmanid and salesdate between '{0}' and '{1}' and sales.salesmanid='" + item["salesmanid"].ToString() + "' "
                    , dtms.Text, dtmx.Text);
           
                    DataTable dtss = DBHellper.GetdataTable(sqlstr);
                    foreach (DataRow itemss in dtss.Rows)
                    {
                        if (itemss["b"].ToString() == "")
                        {
                            b = "0.00";
                        }
                        else
                        {
                            b = itemss["b"].ToString();
                        }

                    }
                    root.SubItems.Add(b);
                    yfgz = double.Parse(b.ToString());
                }
                else
                {

                    string sqlstrs = string.Format("select sum(Sales.Amount) as b from Sales,salesman  where sales.salesmanid=salesman.salesmanid and salesdate between '{0}' and '{1}' and sales.salesmanid='{2}' "
                   , dtms.Text, dtmx.Text, item["salesmanid"].ToString());
            
                    DataTable dtsss = DBHellper.GetdataTable(sqlstrs);
                    foreach (DataRow itemss in dtsss.Rows)
                    {
                        if (itemss["b"].ToString() == "")
                        {
                            b = "0.00";
                        }
                        else
                        {
                            b = itemss["b"].ToString();
                        }

                    }
                    root.SubItems.Add(b);
                    yfgz = double.Parse(b.ToString());
                }
                yfgz = (double.Parse(item["BaseSalary"].ToString()) + double.Parse(item["CommissionRate"].ToString()) * double.Parse(b));
                root.SubItems.Add(yfgz.ToString());
                lvwshow.Items.Add(root);
            }
           
            i++;
            
        }
        private double getsalesdata(string salesmanid,DateTime startdata,DateTime endData) {
            string sqlstr = string.Format("select sum(Sales.Amount) from Sales,salesman  where sales.sales.salesmanid=salesman.salesmanid and salesdate between '{0}' and '{1}' and salesmanid='{2}' "
                , startdata.ToString("yyyy-MM-dd"), endData.ToString("yyyy-MM-dd"), salesmanid);
            object obj = DBHellper.ExecuteNonQuery(sqlstr);
            if (obj is DBNull)
            {

                return 0;
            }
            else
            {
                return Convert.ToSingle(obj); 
            }
        
        }
        private double getsalesdz(DateTime startdata, DateTime endData)
        {
            string sql = string.Format("select sum(sales.amount) from  sales,salesman where sales.salesmanid=salesman.salesmanid and salesdate between '{0}' and'{1}'",
                startdata.ToString("yyyy-MM-dd"), endData.ToString("yyyy-MM-dd") );
        object obj=DBHellper.ExecuteNonQuery(sql);
            if(obj is DBNull){
            
            return 0;
            }
            else{
            
            return Convert.ToSingle(obj);
            }
        
        
        
        }
    }
}
