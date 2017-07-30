namespace Nike
{
    partial class Salesfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtmx = new System.Windows.Forms.DateTimePicker();
            this.dtms = new System.Windows.Forms.DateTimePicker();
            this.cbosales = new System.Windows.Forms.ComboBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lalje = new System.Windows.Forms.Label();
            this.laljl = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coblm = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtmx);
            this.groupBox1.Controls.Add(this.dtms);
            this.groupBox1.Controls.Add(this.coblm);
            this.groupBox1.Controls.Add(this.cbosales);
            this.groupBox1.Controls.Add(this.btnshow);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(932, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计条件";
            // 
            // dtmx
            // 
            this.dtmx.CustomFormat = "yyyy-MM-dd";
            this.dtmx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmx.Location = new System.Drawing.Point(515, 46);
            this.dtmx.Name = "dtmx";
            this.dtmx.Size = new System.Drawing.Size(146, 26);
            this.dtmx.TabIndex = 3;
            // 
            // dtms
            // 
            this.dtms.CustomFormat = "yyyy-MM-dd";
            this.dtms.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtms.Location = new System.Drawing.Point(321, 46);
            this.dtms.Name = "dtms";
            this.dtms.Size = new System.Drawing.Size(146, 26);
            this.dtms.TabIndex = 3;
            // 
            // cbosales
            // 
            this.cbosales.FormattingEnabled = true;
            this.cbosales.Location = new System.Drawing.Point(112, 48);
            this.cbosales.Name = "cbosales";
            this.cbosales.Size = new System.Drawing.Size(121, 24);
            this.cbosales.TabIndex = 2;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(802, 42);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(95, 28);
            this.btnshow.TabIndex = 1;
            this.btnshow.Text = "查询";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "至";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "导购员";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(18, 145);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(932, 285);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lalje);
            this.groupBox2.Controls.Add(this.laljl);
            this.groupBox2.Location = new System.Drawing.Point(18, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 133);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "统计结果";
            // 
            // lalje
            // 
            this.lalje.AutoSize = true;
            this.lalje.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalje.Location = new System.Drawing.Point(22, 81);
            this.lalje.Name = "lalje";
            this.lalje.Size = new System.Drawing.Size(563, 35);
            this.lalje.TabIndex = 0;
            this.lalje.Text = "销售金额￥0.00元，利润￥0.00元";
            // 
            // laljl
            // 
            this.laljl.AutoSize = true;
            this.laljl.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laljl.Location = new System.Drawing.Point(26, 30);
            this.laljl.Name = "laljl";
            this.laljl.Size = new System.Drawing.Size(197, 33);
            this.laljl.TabIndex = 0;
            this.laljl.Text = "销售记录0条";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "小票流水号";
            this.columnHeader1.Width = 177;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "购物日期";
            this.columnHeader2.Width = 223;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "购物金额";
            this.columnHeader3.Width = 134;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "单笔利润";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "导购员";
            this.columnHeader5.Width = 98;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "收银员";
            this.columnHeader6.Width = 95;
            // 
            // coblm
            // 
            this.coblm.FormattingEnabled = true;
            this.coblm.Items.AddRange(new object[] {
            "本日",
            "本周",
            "本月",
            "上月",
            "本年"});
            this.coblm.Location = new System.Drawing.Point(689, 45);
            this.coblm.Name = "coblm";
            this.coblm.Size = new System.Drawing.Size(67, 24);
            this.coblm.TabIndex = 2;
            this.coblm.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Salesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Salesfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售统计";
            this.Load += new System.EventHandler(this.Salesfrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtmx;
        private System.Windows.Forms.DateTimePicker dtms;
        private System.Windows.Forms.ComboBox cbosales;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lalje;
        private System.Windows.Forms.Label laljl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox coblm;
    }
}