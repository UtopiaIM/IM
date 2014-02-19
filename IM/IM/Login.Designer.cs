namespace IM
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Uname = new System.Windows.Forms.Label();
            this.Pword = new System.Windows.Forms.Label();
            this.Uname_textbox = new System.Windows.Forms.TextBox();
            this.Pword_textbox = new System.Windows.Forms.TextBox();
            this.regist_link = new System.Windows.Forms.LinkLabel();
            this.findpassword_link = new System.Windows.Forms.LinkLabel();
            this.autologin = new System.Windows.Forms.CheckBox();
            this.remainpw = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.login_title = new System.Windows.Forms.PictureBox();
            this.tuopan = new System.Windows.Forms.NotifyIcon(this.components);
            this.loginmenu = new CCWin.SkinControl.SkinContextMenuStrip();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.login_title)).BeginInit();
            this.loginmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Uname
            // 
            this.Uname.AutoSize = true;
            this.Uname.Location = new System.Drawing.Point(34, 108);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(52, 15);
            this.Uname.TabIndex = 1;
            this.Uname.Text = "用户：";
            // 
            // Pword
            // 
            this.Pword.AutoSize = true;
            this.Pword.Location = new System.Drawing.Point(34, 144);
            this.Pword.Name = "Pword";
            this.Pword.Size = new System.Drawing.Size(52, 15);
            this.Pword.TabIndex = 2;
            this.Pword.Text = "密码：";
            // 
            // Uname_textbox
            // 
            this.Uname_textbox.Location = new System.Drawing.Point(83, 105);
            this.Uname_textbox.Name = "Uname_textbox";
            this.Uname_textbox.Size = new System.Drawing.Size(171, 25);
            this.Uname_textbox.TabIndex = 3;
            // 
            // Pword_textbox
            // 
            this.Pword_textbox.Location = new System.Drawing.Point(83, 141);
            this.Pword_textbox.Name = "Pword_textbox";
            this.Pword_textbox.Size = new System.Drawing.Size(171, 25);
            this.Pword_textbox.TabIndex = 4;
            // 
            // regist_link
            // 
            this.regist_link.AutoSize = true;
            this.regist_link.Location = new System.Drawing.Point(259, 108);
            this.regist_link.Name = "regist_link";
            this.regist_link.Size = new System.Drawing.Size(82, 15);
            this.regist_link.TabIndex = 5;
            this.regist_link.TabStop = true;
            this.regist_link.Text = "注册新用户";
            this.regist_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regist_link_LinkClicked);
            // 
            // findpassword_link
            // 
            this.findpassword_link.AutoSize = true;
            this.findpassword_link.Location = new System.Drawing.Point(260, 144);
            this.findpassword_link.Name = "findpassword_link";
            this.findpassword_link.Size = new System.Drawing.Size(67, 15);
            this.findpassword_link.TabIndex = 6;
            this.findpassword_link.TabStop = true;
            this.findpassword_link.Text = "找回密码";
            // 
            // autologin
            // 
            this.autologin.AutoSize = true;
            this.autologin.Location = new System.Drawing.Point(178, 172);
            this.autologin.Name = "autologin";
            this.autologin.Size = new System.Drawing.Size(89, 19);
            this.autologin.TabIndex = 7;
            this.autologin.Text = "自动登录";
            this.autologin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.autologin.UseVisualStyleBackColor = true;
            // 
            // remainpw
            // 
            this.remainpw.AutoSize = true;
            this.remainpw.Location = new System.Drawing.Point(57, 172);
            this.remainpw.Name = "remainpw";
            this.remainpw.Size = new System.Drawing.Size(89, 19);
            this.remainpw.TabIndex = 8;
            this.remainpw.Text = "记住密码";
            this.remainpw.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = "D:\\IM\\IM\\IM\\bin\\Debug\\MP10.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // login_title
            // 
            this.login_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.login_title.Image = global::IM.Properties.Resources.Login_标题;
            this.login_title.Location = new System.Drawing.Point(0, 0);
            this.login_title.Name = "login_title";
            this.login_title.Size = new System.Drawing.Size(360, 85);
            this.login_title.TabIndex = 0;
            this.login_title.TabStop = false;
            // 
            // tuopan
            // 
            this.tuopan.ContextMenuStrip = this.loginmenu;
            this.tuopan.Icon = ((System.Drawing.Icon)(resources.GetObject("tuopan.Icon")));
            this.tuopan.Text = "IM";
            this.tuopan.Visible = true;
            // 
            // loginmenu
            // 
            this.loginmenu.Arrow = System.Drawing.Color.Black;
            this.loginmenu.Back = System.Drawing.Color.White;
            this.loginmenu.BackRadius = 4;
            this.loginmenu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.loginmenu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.loginmenu.Fore = System.Drawing.Color.Black;
            this.loginmenu.HoverFore = System.Drawing.Color.White;
            this.loginmenu.ItemAnamorphosis = true;
            this.loginmenu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.loginmenu.ItemBorderShow = true;
            this.loginmenu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.loginmenu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.loginmenu.ItemRadius = 4;
            this.loginmenu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.loginmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.loginmenu.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.loginmenu.Name = "skinContextMenuStrip1";
            this.loginmenu.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.loginmenu.Size = new System.Drawing.Size(154, 74);
            this.loginmenu.TitleAnamorphosis = true;
            this.loginmenu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.loginmenu.TitleRadius = 4;
            this.loginmenu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.打开ToolStripMenuItem.Text = "打开主面板";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(360, 263);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.remainpw);
            this.Controls.Add(this.autologin);
            this.Controls.Add(this.findpassword_link);
            this.Controls.Add(this.regist_link);
            this.Controls.Add(this.Pword_textbox);
            this.Controls.Add(this.Uname_textbox);
            this.Controls.Add(this.Pword);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.login_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IM";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login_title)).EndInit();
            this.loginmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox login_title;
        private System.Windows.Forms.Label Uname;
        private System.Windows.Forms.Label Pword;
        private System.Windows.Forms.TextBox Uname_textbox;
        private System.Windows.Forms.TextBox Pword_textbox;
        private System.Windows.Forms.LinkLabel regist_link;
        private System.Windows.Forms.LinkLabel findpassword_link;
        private System.Windows.Forms.CheckBox autologin;
        private System.Windows.Forms.CheckBox remainpw;
        private System.Windows.Forms.Button button1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        public System.Windows.Forms.NotifyIcon tuopan;
        private CCWin.SkinControl.SkinContextMenuStrip loginmenu;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

