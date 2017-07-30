namespace Nike
{
    partial class Nike
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nike));
            this.entry = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.cbofg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entry
            // 
            this.entry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entry.BackgroundImage")));
            this.entry.Location = new System.Drawing.Point(334, 336);
            this.entry.Name = "entry";
            this.entry.Size = new System.Drawing.Size(123, 35);
            this.entry.TabIndex = 3;
            this.entry.UseVisualStyleBackColor = true;
            this.entry.Click += new System.EventHandler(this.entry_Click);
            // 
            // cancel
            // 
            this.cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel.BackgroundImage")));
            this.cancel.Location = new System.Drawing.Point(491, 336);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(119, 35);
            this.cancel.TabIndex = 4;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(413, 214);
            this.user.MaxLength = 11;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(197, 21);
            this.user.TabIndex = 1;
            this.user.Text = "13712345678";
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(413, 264);
            this.pwd.MaxLength = 16;
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(197, 21);
            this.pwd.TabIndex = 2;
            this.pwd.TextChanged += new System.EventHandler(this.pwd_TextChanged);
            this.pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwd_KeyDown);
            // 
            // cbofg
            // 
            this.cbofg.FormattingEnabled = true;
            this.cbofg.Items.AddRange(new object[] {
            "下拉式",
            "选项卡"});
            this.cbofg.Location = new System.Drawing.Point(811, 34);
            this.cbofg.Name = "cbofg";
            this.cbofg.Size = new System.Drawing.Size(121, 20);
            this.cbofg.TabIndex = 5;
            this.cbofg.Text = "选项卡";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(734, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "导航风格";
            // 
            // Nike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nike.Properties.Resources.login_bg;
            this.ClientSize = new System.Drawing.Size(983, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbofg);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.user);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.entry);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nike";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nike";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entry;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.ComboBox cbofg;
        private System.Windows.Forms.Label label1;
    }
}

