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
    public partial class Classifyfrm : Form
    {
        public Classifyfrm()
        {
            InitializeComponent();
        }

        private void Classifyfrm_Load(object sender, EventArgs e)
        {



            intshow();
          


        }

        private void intshow()
        {
            string sql = "select * from type";
            DataTable dt = DBHellper.GetdataTable(sql);

            foreach (DataRow item in dt.Rows)
            {
                if (item["ParentID"].ToString() == "0")
                {
                    TreeNode root = new TreeNode(item["typename"].ToString());

                    foreach (DataRow items in dt.Rows)
                    {
                        if (items["ParentID"].ToString() == item["typeid"].ToString())
                        {
                            root.Nodes.Add(items["typename"].ToString());

                        }
                    }
                    tvwshow.Nodes.Add(root);
                }
                tvwshow.ExpandAll();

            }
            string sqla = "select * from type where ParentID =0";
            DataTable dta = DBHellper.GetdataTable(sqla);



            foreach (DataRow item in dta.Rows)
            {

                cbofj.Items.Add(item["typename"].ToString());


            }
        }

        
        private void tvwshow_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
         

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (tvwshow.SelectedNode == null)
            {
                MessageBox.Show("请选择修改的分类！");
                return;
            }
            string sqla = "select typeid from type where typename='"+cbofj.Text+"'";
            string id = "";
            DataTable dt = DBHellper.GetdataTable(sqla);
            foreach (DataRow item in dt.Rows)
            {
                id = item["typeid"].ToString();
            }
            string sql = "update type set ParentID="+id+" where typename ='"+TXTfl.Text+"'";
            int asd = DBHellper.ExecuteNonQuery(sql);
            if (asd > 0)
            {
                MessageBox.Show("修改成功");
                tvwshow.Nodes.Clear();
                intshow();
            }
            else {
                MessageBox.Show("修改失败");
            }
        }


        private void tvwshow_AfterSelect(object sender, TreeViewEventArgs e)
        {

         
                TXTfl.Text = tvwshow.SelectedNode.Text;
                string sqla = "select * from type where ParentID =(select ParentID from type where typename='" + TXTfl.Text + "')";
                DataTable dta = DBHellper.GetdataTable(sqla);



                foreach (DataRow item in dta.Rows)
                {
                    if (item["ParentID"].ToString() == "0")
                    {
                        cbofj.Text = "";
                    }
                    else
                    {
                        string sqlas = "select typename from type where typeid =(select ParentID from type where typename='" + TXTfl.Text + "')";
                        DataTable dtas = DBHellper.GetdataTable(sqlas);
                        foreach (DataRow items in dtas.Rows)
                        {
                            cbofj.Text = items["typename"].ToString();
                        }
                    }
                }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            string sqla = "select typeid from type where typename='"+cbofj.Text+"'";
            string id = "";
            DataTable dt = DBHellper.GetdataTable(sqla);
            foreach (DataRow item in dt.Rows)
            {
                id = item["typeid"].ToString();
            }
            string sql = "insert into type values('"+TXTfl.Text+"','"+id+"')";
            int asd = DBHellper.ExecuteNonQuery(sql);
            if (asd > 0)
            {
                MessageBox.Show("修改成功");
                tvwshow.Nodes.Clear();
                intshow();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}




