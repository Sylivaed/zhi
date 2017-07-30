namespace Nike
{
    partial class Collect
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
            this.laltxm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboxdg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lalliushui = new System.Windows.Forms.Label();
            this.list_show = new System.Windows.Forms.ListView();
            this.huohao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leibie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zhj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shuliang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.lalmonye = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelsps = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxys = new System.Windows.Forms.TextBox();
            this.textBoxzl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxss = new System.Windows.Forms.TextBox();
            this.btnjs = new System.Windows.Forms.Button();
            this.labsy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "货号/条形码：";
            // 
            // laltxm
            // 
            this.laltxm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laltxm.Location = new System.Drawing.Point(133, 39);
            this.laltxm.MaxLength = 7;
            this.laltxm.Name = "laltxm";
            this.laltxm.Size = new System.Drawing.Size(136, 26);
            this.laltxm.TabIndex = 1;
            this.laltxm.TextChanged += new System.EventHandler(this.laltxm_TextChanged);
            this.laltxm.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.laltxm_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(382, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "导购员：";
            // 
            // comboxdg
            // 
            this.comboxdg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxdg.FormattingEnabled = true;
            this.comboxdg.Location = new System.Drawing.Point(448, 40);
            this.comboxdg.Name = "comboxdg";
            this.comboxdg.Size = new System.Drawing.Size(124, 24);
            this.comboxdg.TabIndex = 3;
            this.comboxdg.Text = "- -请选择- -";
            this.comboxdg.SelectedIndexChanged += new System.EventHandler(this.comboxdg_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(656, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "小票流水号:";
            // 
            // lalliushui
            // 
            this.lalliushui.AutoSize = true;
            this.lalliushui.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalliushui.Location = new System.Drawing.Point(759, 44);
            this.lalliushui.Name = "lalliushui";
            this.lalliushui.Size = new System.Drawing.Size(0, 16);
            this.lalliushui.TabIndex = 5;
            // 
            // list_show
            // 
            this.list_show.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.huohao,
            this.name,
            this.leibie,
            this.lsj,
            this.zk,
            this.zhj,
            this.shuliang});
            this.list_show.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_show.FullRowSelect = true;
            this.list_show.Location = new System.Drawing.Point(29, 122);
            this.list_show.Name = "list_show";
            this.list_show.Size = new System.Drawing.Size(1039, 179);
            this.list_show.TabIndex = 6;
            this.list_show.UseCompatibleStateImageBehavior = false;
            this.list_show.View = System.Windows.Forms.View.Details;
            this.list_show.SelectedIndexChanged += new System.EventHandler(this.list_show_SelectedIndexChanged);
            // 
            // huohao
            // 
            this.huohao.Text = "货号/条形码";
            this.huohao.Width = 137;
            // 
            // name
            // 
            this.name.Text = "商品名称";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 430;
            // 
            // leibie
            // 
            this.leibie.Text = "商品类别";
            this.leibie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.leibie.Width = 101;
            // 
            // lsj
            // 
            this.lsj.Text = "零售价";
            this.lsj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lsj.Width = 99;
            // 
            // zk
            // 
            this.zk.Text = "折扣";
            this.zk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zk.Width = 74;
            // 
            // zhj
            // 
            this.zhj.Text = "折后价";
            this.zhj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zhj.Width = 96;
            // 
            // shuliang
            // 
            this.shuliang.Text = "数量";
            this.shuliang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.shuliang.Width = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(29, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "共:￥";
            // 
            // lalmonye
            // 
            this.lalmonye.AutoSize = true;
            this.lalmonye.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalmonye.Location = new System.Drawing.Point(128, 351);
            this.lalmonye.Name = "lalmonye";
            this.lalmonye.Size = new System.Drawing.Size(79, 33);
            this.lalmonye.TabIndex = 8;
            this.lalmonye.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(34, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "商品数";
            // 
            // labelsps
            // 
            this.labelsps.AutoSize = true;
            this.labelsps.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelsps.Location = new System.Drawing.Point(133, 409);
            this.labelsps.Name = "labelsps";
            this.labelsps.Size = new System.Drawing.Size(22, 24);
            this.labelsps.TabIndex = 8;
            this.labelsps.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(309, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "应收";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(309, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "找零";
            // 
            // textBoxys
            // 
            this.textBoxys.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxys.Location = new System.Drawing.Point(388, 353);
            this.textBoxys.Name = "textBoxys";
            this.textBoxys.Size = new System.Drawing.Size(161, 29);
            this.textBoxys.TabIndex = 9;
            // 
            // textBoxzl
            // 
            this.textBoxzl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxzl.Location = new System.Drawing.Point(388, 448);
            this.textBoxzl.Name = "textBoxzl";
            this.textBoxzl.Size = new System.Drawing.Size(161, 29);
            this.textBoxzl.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(309, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "实收";
            // 
            // textBoxss
            // 
            this.textBoxss.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxss.Location = new System.Drawing.Point(388, 400);
            this.textBoxss.Name = "textBoxss";
            this.textBoxss.Size = new System.Drawing.Size(161, 29);
            this.textBoxss.TabIndex = 9;
            this.textBoxss.Text = "0.00";
            // 
            // btnjs
            // 
            this.btnjs.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnjs.Location = new System.Drawing.Point(591, 351);
            this.btnjs.Name = "btnjs";
            this.btnjs.Size = new System.Drawing.Size(112, 58);
            this.btnjs.TabIndex = 10;
            this.btnjs.Text = "结算";
            this.btnjs.UseVisualStyleBackColor = true;
            this.btnjs.Click += new System.EventHandler(this.btnjs_Click);
            // 
            // labsy
            // 
            this.labsy.AutoSize = true;
            this.labsy.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labsy.Location = new System.Drawing.Point(186, 416);
            this.labsy.Name = "labsy";
            this.labsy.Size = new System.Drawing.Size(0, 16);
            this.labsy.TabIndex = 11;
            // 
            // Collect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1109, 610);
            this.Controls.Add(this.labsy);
            this.Controls.Add(this.btnjs);
            this.Controls.Add(this.textBoxss);
            this.Controls.Add(this.textBoxzl);
            this.Controls.Add(this.textBoxys);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelsps);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lalmonye);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.list_show);
            this.Controls.Add(this.lalliushui);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboxdg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laltxm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Collect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收银台";
            this.Load += new System.EventHandler(this.Collect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox laltxm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboxdg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lalliushui;
        private System.Windows.Forms.ListView list_show;
        private System.Windows.Forms.ColumnHeader huohao;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader leibie;
        private System.Windows.Forms.ColumnHeader lsj;
        private System.Windows.Forms.ColumnHeader zk;
        private System.Windows.Forms.ColumnHeader zhj;
        private System.Windows.Forms.ColumnHeader shuliang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lalmonye;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelsps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxys;
        private System.Windows.Forms.TextBox textBoxzl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxss;
        private System.Windows.Forms.Button btnjs;
        private System.Windows.Forms.Label labsy;
    }
}