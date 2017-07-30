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

namespace Nike
{
    public partial class Nike : Form
    {
        public Nike()
        {
            InitializeComponent();
        }

        private void entry_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=.; initial catalog=Nike;integrated Security=true";
            string ure = this.user.Text.Trim();
            string pwd = this.pwd.Text.Trim();
            SqlConnection con = new SqlConnection();
            
            con.ConnectionString = constr;
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Salesman where Mobile='" + ure + "'";
            SqlDataReader dr = com.ExecuteReader();//执行SQL语句


            if (ure == "" || pwd == "")
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                if (dr.Read())
                {
                    /*从数据库里查询出和用户相对应的PassWorld的值 
                     *reader.GetOrdinal("PassWord")的作用是得到PassWord的为这行数据中的第几列,返回回值是int 
                     *reader.GetString()的作用是得到第几列的值,返回类型为String. 
                     */
                    string dbpassword = dr.GetValue(3).ToString();

                    //比较用户输入的密码与从数据库中查询到的密码是否一至  
                    if (pwd == dbpassword)
                    {
                        DBHellper.name = ure;
                        this.Hide();
                        if (cbofg.Text == "选项卡")
                        {
                            //如果相等,就登录成功   
                            Mainsfrm frm = new Mainsfrm();
                            frm.Show();

                        }
                        else {
                            Main frm = new Main();
                            frm.Show();
                        }
                    }
                   

                }
                else
                {
                    //如果不相等,说明密码不对   
                    MessageBox.Show("输入的账号或密码有误!");
                }
            }


            
            dr.Close();//关闭执行
            con.Close();//关闭数据库
           
            
            
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBHellper.fg = cbofg.Text;
        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pwd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                entry_Click(sender,e);
            
            }
        }
    }
}
