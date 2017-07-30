namespace Nike
{
    partial class Tgoodsfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtxp = new System.Windows.Forms.TextBox();
            this.btncx = new System.Windows.Forms.Button();
            this.lvwshow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnth = new System.Windows.Forms.Button();
            this.btnqx = new System.Windows.Forms.Button();
            this.laljy = new System.Windows.Forms.Label();
            this.lalth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(240, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "购物小票流水号";
            // 
            // txtxp
            // 
            this.txtxp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtxp.Location = new System.Drawing.Point(404, 38);
            this.txtxp.MaxLength = 14;
            this.txtxp.Name = "txtxp";
            this.txtxp.Size = new System.Drawing.Size(244, 26);
            this.txtxp.TabIndex = 1;
            // 
            // btncx
            // 
            this.btncx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncx.Location = new System.Drawing.Point(674, 35);
            this.btncx.Name = "btncx";
            this.btncx.Size = new System.Drawing.Size(84, 28);
            this.btncx.TabIndex = 2;
            this.btncx.Text = "查询";
            this.btncx.UseVisualStyleBackColor = true;
            this.btncx.Click += new System.EventHandler(this.btncx_Click);
            // 
            // lvwshow
            // 
            this.lvwshow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwshow.Location = new System.Drawing.Point(12, 95);
            this.lvwshow.Name = "lvwshow";
            this.lvwshow.Size = new System.Drawing.Size(893, 268);
            this.lvwshow.TabIndex = 3;
            this.lvwshow.UseCompatibleStateImageBehavior = false;
            this.lvwshow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "货号\\条形码";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名称";
            this.columnHeader2.Width = 213;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "实收价格";
            this.columnHeader3.Width = 157;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "数量";
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "导购员";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "购买日期";
            this.columnHeader6.Width = 170;
            // 
            // btnth
            // 
            this.btnth.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnth.Location = new System.Drawing.Point(674, 402);
            this.btnth.Name = "btnth";
            this.btnth.Size = new System.Drawing.Size(98, 28);
            this.btnth.TabIndex = 2;
            this.btnth.Text = "退货";
            this.btnth.UseVisualStyleBackColor = true;
            this.btnth.Click += new System.EventHandler(this.btnth_Click);
            // 
            // btnqx
            // 
            this.btnqx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnqx.Location = new System.Drawing.Point(787, 402);
            this.btnqx.Name = "btnqx";
            this.btnqx.Size = new System.Drawing.Size(90, 28);
            this.btnqx.TabIndex = 2;
            this.btnqx.Text = "取消";
            this.btnqx.UseVisualStyleBackColor = true;
            this.btnqx.Click += new System.EventHandler(this.btnqx_Click);
            // 
            // laljy
            // 
            this.laljy.AutoSize = true;
            this.laljy.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laljy.Location = new System.Drawing.Point(14, 395);
            this.laljy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laljy.Name = "laljy";
            this.laljy.Size = new System.Drawing.Size(281, 33);
            this.laljy.TabIndex = 0;
            this.laljy.Text = "交易金额：￥0.00";
            // 
            // lalth
            // 
            this.lalth.AutoSize = true;
            this.lalth.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalth.Location = new System.Drawing.Point(338, 395);
            this.lalth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalth.Name = "lalth";
            this.lalth.Size = new System.Drawing.Size(281, 33);
            this.lalth.TabIndex = 0;
            this.lalth.Text = "退款金额：￥0.00";
            // 
            // Tgoodsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 479);
            this.Controls.Add(this.lvwshow);
            this.Controls.Add(this.btnqx);
            this.Controls.Add(this.btnth);
            this.Controls.Add(this.btncx);
            this.Controls.Add(this.txtxp);
            this.Controls.Add(this.lalth);
            this.Controls.Add(this.laljy);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Tgoodsfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退货管理";
            this.Load += new System.EventHandler(this.Tgoodsfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtxp;
        private System.Windows.Forms.Button btncx;
        private System.Windows.Forms.ListView lvwshow;
        private System.Windows.Forms.Button btnth;
        private System.Windows.Forms.Button btnqx;
        private System.Windows.Forms.Label laljy;
        private System.Windows.Forms.Label lalth;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}