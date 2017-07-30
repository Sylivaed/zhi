namespace Nike
{
    partial class Classifyfrm
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
            this.tvwshow = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnin = new System.Windows.Forms.Button();
            this.cbofj = new System.Windows.Forms.ComboBox();
            this.TXTfl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwshow
            // 
            this.tvwshow.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvwshow.Location = new System.Drawing.Point(12, 12);
            this.tvwshow.Name = "tvwshow";
            this.tvwshow.Size = new System.Drawing.Size(276, 409);
            this.tvwshow.TabIndex = 0;
            this.tvwshow.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwshow_AfterSelect);
            this.tvwshow.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwshow_NodeMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(305, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 408);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品分类信息";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnin);
            this.panel1.Controls.Add(this.cbofj);
            this.panel1.Controls.Add(this.TXTfl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Location = new System.Drawing.Point(17, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 326);
            this.panel1.TabIndex = 5;
            // 
            // btnin
            // 
            this.btnin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnin.Location = new System.Drawing.Point(48, 187);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(139, 34);
            this.btnin.TabIndex = 4;
            this.btnin.Text = "新增分类";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // cbofj
            // 
            this.cbofj.FormattingEnabled = true;
            this.cbofj.Location = new System.Drawing.Point(94, 103);
            this.cbofj.Name = "cbofj";
            this.cbofj.Size = new System.Drawing.Size(118, 24);
            this.cbofj.TabIndex = 3;
            // 
            // TXTfl
            // 
            this.TXTfl.Location = new System.Drawing.Point(94, 36);
            this.TXTfl.Name = "TXTfl";
            this.TXTfl.Size = new System.Drawing.Size(118, 26);
            this.TXTfl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "父级分类";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "分类名称";
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnupdate.Location = new System.Drawing.Point(48, 227);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 34);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "修改分类";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Classifyfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tvwshow);
            this.MaximizeBox = false;
            this.Name = "Classifyfrm";
            this.Text = "商品分类";
            this.Load += new System.EventHandler(this.Classifyfrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwshow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbofj;
        private System.Windows.Forms.TextBox TXTfl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Panel panel1;
    }
}