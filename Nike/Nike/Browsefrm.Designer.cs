namespace Nike
{
    partial class Browsefrm
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
            this.cobej = new System.Windows.Forms.ComboBox();
            this.cobyj = new System.Windows.Forms.ComboBox();
            this.coblm = new System.Windows.Forms.ComboBox();
            this.dtmx = new System.Windows.Forms.DateTimePicker();
            this.dtms = new System.Windows.Forms.DateTimePicker();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txthh = new System.Windows.Forms.TextBox();
            this.lalsj = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cobej);
            this.groupBox1.Controls.Add(this.cobyj);
            this.groupBox1.Controls.Add(this.coblm);
            this.groupBox1.Controls.Add(this.dtmx);
            this.groupBox1.Controls.Add(this.dtms);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txthh);
            this.groupBox1.Controls.Add(this.lalsj);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品浏览";
            // 
            // cobej
            // 
            this.cobej.FormattingEnabled = true;
            this.cobej.Location = new System.Drawing.Point(286, 115);
            this.cobej.Name = "cobej";
            this.cobej.Size = new System.Drawing.Size(97, 20);
            this.cobej.TabIndex = 3;
            this.cobej.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cobyj
            // 
            this.cobyj.FormattingEnabled = true;
            this.cobyj.Location = new System.Drawing.Point(99, 115);
            this.cobyj.Name = "cobyj";
            this.cobyj.Size = new System.Drawing.Size(94, 20);
            this.cobyj.TabIndex = 3;
            this.cobyj.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cobyj.TextChanged += new System.EventHandler(this.cobyj_TextChanged);
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
            this.coblm.Location = new System.Drawing.Point(916, 29);
            this.coblm.Name = "coblm";
            this.coblm.Size = new System.Drawing.Size(61, 20);
            this.coblm.TabIndex = 3;
            this.coblm.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtmx
            // 
            this.dtmx.CustomFormat = "yyyy-MM-dd";
            this.dtmx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmx.Location = new System.Drawing.Point(715, 29);
            this.dtmx.Name = "dtmx";
            this.dtmx.Size = new System.Drawing.Size(143, 21);
            this.dtmx.TabIndex = 1;
            this.dtmx.TabStop = false;
            // 
            // dtms
            // 
            this.dtms.CustomFormat = "yyyy-MM-dd";
            this.dtms.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtms.Location = new System.Drawing.Point(497, 28);
            this.dtms.Name = "dtms";
            this.dtms.Size = new System.Drawing.Size(143, 21);
            this.dtms.TabIndex = 1;
            this.dtms.TabStop = false;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(283, 29);
            this.txtname.MaxLength = 50;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 2;
            // 
            // txthh
            // 
            this.txthh.Location = new System.Drawing.Point(106, 29);
            this.txthh.MaxLength = 7;
            this.txthh.Name = "txthh";
            this.txthh.Size = new System.Drawing.Size(100, 21);
            this.txthh.TabIndex = 2;
            // 
            // lalsj
            // 
            this.lalsj.AutoSize = true;
            this.lalsj.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalsj.Location = new System.Drawing.Point(495, 118);
            this.lalsj.Name = "lalsj";
            this.lalsj.Size = new System.Drawing.Size(112, 16);
            this.lalsj.TabIndex = 1;
            this.lalsj.Text = "当前共0条数据";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "二级分类：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "一级分类：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "入库时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "至";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "商品名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "货号/条形码：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(750, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.Location = new System.Drawing.Point(12, 172);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1031, 295);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 54;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "货号/条形码";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "商品名称";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "商品类别";
            this.columnHeader4.Width = 151;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "进货价";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "零售价";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "折扣";
            this.columnHeader7.Width = 102;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "当前入库";
            this.columnHeader8.Width = 135;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "时间";
            this.columnHeader9.Width = 122;
            // 
            // Browsefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1055, 478);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Browsefrm";
            this.Text = "商品浏览";
            this.Load += new System.EventHandler(this.Browsefrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtmx;
        private System.Windows.Forms.DateTimePicker dtms;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txthh;
        private System.Windows.Forms.Label lalsj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox coblm;
        private System.Windows.Forms.ComboBox cobej;
        private System.Windows.Forms.ComboBox cobyj;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}