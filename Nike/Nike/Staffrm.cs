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
    public partial class Staffrm : Form
    {
        public Staffrm()
        {
            InitializeComponent();
        }

        private void Staffrm_Load(object sender, EventArgs e)
        {
            string sql = "select distinct role from salesman";
            DataTable dt = DBHellper.GetdataTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                cbojs.Items.Add(item["role"].ToString());
            }
            string sqls = "select * from salesman";
            DataTable dts = DBHellper.GetdataTable(sqls);
            dgvshow.AutoGenerateColumns = false;
            dgvshow.DataSource = dts;
            dgvshow.Rows[0].Selected = false;
            btnupdate.Visible = false;
          
           
        }
        public string id;
        private void dgvshow_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvshow.SelectedRows.Count > 0)
            {
                btnin.Visible = false;
                btnupdate.Visible = true;
            }
            txtname.Text = dgvshow.SelectedRows[0].Cells["salesmanname"].Value.ToString();
            txttel.Text = dgvshow.SelectedRows[0].Cells["Mobile"].Value.ToString();
            cboxb.Text = dgvshow.SelectedRows[0].Cells["gender"].Value.ToString();
            txtgz.Text = dgvshow.SelectedRows[0].Cells["BaseSalary"].Value.ToString();
            txttc.Text = dgvshow.SelectedRows[0].Cells["CommissionRate"].Value.ToString();
            cbojs.Text = dgvshow.SelectedRows[0].Cells["Role"].Value.ToString();
            id = dgvshow.SelectedRows[0].Cells["SalesmanID"].Value.ToString();
          
        }

        private void dgvshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(dgvshow.SelectedRows.Count==0){
            MessageBox.Show("请选择修改信息！");
            return ;
            }
            btnin.Visible = false;
            string sql = string.Format("update Salesman set SalesmanName='{0}',Mobile='{1}',Gender='{2}',BaseSalary='{3}',CommissionRate='{4}',Role='{5}' where SalesmanID='{6}'"
                ,txtname.Text,txttel.Text,cboxb.Text,txtgz.Text,txttc.Text,cbojs.Text,id);
            int i = DBHellper.ExecuteNonQuery(sql);
            if (i > 0)
            {
                MessageBox.Show("修改成功！");
                string sqls = "select * from salesman";
                DataTable dts = DBHellper.GetdataTable(sqls);
                dgvshow.AutoGenerateColumns = false;
                dgvshow.DataSource = dts;
            }
            else {
                MessageBox.Show("修改失败！");
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            if( txtname.Text==""||txttel.Text==""||cboxb.Text==""|| txtgz.Text==""||txttc.Text==""||cbojs.Text==""){
                MessageBox.Show("信息填写不完整！");
                return;
            }
            string pwd = "0000";
            string sql = string.Format("insert into Salesman values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')"
                , txtname.Text, txttel.Text,pwd, cboxb.Text, txtgz.Text, txttc.Text, cbojs.Text);
            int i = DBHellper.ExecuteNonQuery(sql);
            if (i > 0)
            {
                MessageBox.Show("新增成功！");
                string sqls = "select * from salesman";
                DataTable dts = DBHellper.GetdataTable(sqls);
                dgvshow.AutoGenerateColumns = false;
                dgvshow.DataSource = dts;
            }
            else
            {
                MessageBox.Show("新增失败！");
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "delete salesman where salesmanid='"+id+"'";
            int i = DBHellper.ExecuteNonQuery(sql);
            if (i > 0)
            {
                MessageBox.Show("删除成功！");
                string sqls = "select * from salesman";
                DataTable dts = DBHellper.GetdataTable(sqls);
                dgvshow.AutoGenerateColumns = false;
                dgvshow.DataSource = dts;
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }
   

        
    }
}
