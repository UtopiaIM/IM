namespace IM
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            CCWin.SkinControl.ChatListItem chatListItem1 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem1 = new CCWin.SkinControl.ChatListSubItem();
            CCWin.SkinControl.ChatListItem chatListItem2 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListItem chatListItem3 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListItem chatListItem4 = new CCWin.SkinControl.ChatListItem();
            CCWin.SkinControl.ChatListSubItem chatListSubItem2 = new CCWin.SkinControl.ChatListSubItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.chatListBox = new CCWin.SkinControl.ChatListBox();
            this.Usermenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.发送即时消息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移动联系人至ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除此好友ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改备注名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.聊天记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Communicate_tabPage = new System.Windows.Forms.TabPage();
            this.skinToolStrip1 = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.Apply_tabPage = new System.Windows.Forms.TabPage();
            this.Notify_tabPage = new System.Windows.Forms.TabPage();
            this.Research_tabPage = new System.Windows.Forms.TabPage();
            this.Teach_tabPage = new System.Windows.Forms.TabPage();
            this.Collection_tabPage = new System.Windows.Forms.TabPage();
            this.Resource_tabPage = new System.Windows.Forms.TabPage();
            this.Vedio_tabPage = new System.Windows.Forms.TabPage();
            this.Entertain_tabPage = new System.Windows.Forms.TabPage();
            this.Class_tabPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.Name_skinLable = new CCWin.SkinControl.SkinLabel();
            this.Sign_skinLabel = new CCWin.SkinControl.SkinLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.skinToolStrip2 = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Usermenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Communicate_tabPage.SuspendLayout();
            this.skinToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.skinToolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatListBox
            // 
            this.chatListBox.BackColor = System.Drawing.Color.White;
            this.chatListBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox.ForeColor = System.Drawing.Color.Black;
            chatListItem1.Bounds = new System.Drawing.Rectangle(0, 1, 363, 25);
            chatListItem1.IsTwinkleHide = false;
            chatListItem1.OwnerChatListBox = this.chatListBox;
            chatListSubItem1.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem1.DisplayName = "好友1号";
            chatListSubItem1.HeadImage = null;
            chatListSubItem1.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem1.ID = 0;
            chatListSubItem1.IpAddress = null;
            chatListSubItem1.IsTwinkle = false;
            chatListSubItem1.IsTwinkleHide = false;
            chatListSubItem1.NicName = "nicName";
            chatListSubItem1.OwnerListItem = chatListItem1;
            chatListSubItem1.PersonalMsg = "Personal Message ...";
            chatListSubItem1.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem1.Tag = null;
            chatListSubItem1.TcpPort = 0;
            chatListSubItem1.UpdPort = 0;
            chatListItem1.SubItems.AddRange(new CCWin.SkinControl.ChatListSubItem[] {
            chatListSubItem1});
            chatListItem1.Text = "我的好友";
            chatListItem1.TwinkleSubItemNumber = 0;
            chatListItem2.Bounds = new System.Drawing.Rectangle(0, 27, 363, 25);
            chatListItem2.IsTwinkleHide = false;
            chatListItem2.OwnerChatListBox = this.chatListBox;
            chatListItem2.Text = "我的老师";
            chatListItem2.TwinkleSubItemNumber = 0;
            chatListItem3.Bounds = new System.Drawing.Rectangle(0, 53, 363, 25);
            chatListItem3.IsTwinkleHide = false;
            chatListItem3.OwnerChatListBox = this.chatListBox;
            chatListItem3.Text = "陌生人";
            chatListItem3.TwinkleSubItemNumber = 0;
            chatListItem4.Bounds = new System.Drawing.Rectangle(0, 79, 363, 25);
            chatListItem4.IsTwinkleHide = false;
            chatListItem4.OwnerChatListBox = this.chatListBox;
            chatListSubItem2.Bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem2.DisplayName = "黑名单1号";
            chatListSubItem2.HeadImage = null;
            chatListSubItem2.HeadRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            chatListSubItem2.ID = 0;
            chatListSubItem2.IpAddress = null;
            chatListSubItem2.IsTwinkle = false;
            chatListSubItem2.IsTwinkleHide = false;
            chatListSubItem2.NicName = "nicName";
            chatListSubItem2.OwnerListItem = chatListItem4;
            chatListSubItem2.PersonalMsg = "Personal Message ...";
            chatListSubItem2.Status = CCWin.SkinControl.ChatListSubItem.UserStatus.Online;
            chatListSubItem2.Tag = null;
            chatListSubItem2.TcpPort = 0;
            chatListSubItem2.UpdPort = 0;
            chatListItem4.SubItems.AddRange(new CCWin.SkinControl.ChatListSubItem[] {
            chatListSubItem2});
            chatListItem4.Text = "黑名单";
            chatListItem4.TwinkleSubItemNumber = 0;
            this.chatListBox.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem1,
            chatListItem2,
            chatListItem3,
            chatListItem4});
            this.chatListBox.ListSubItemMenu = this.Usermenu;
            this.chatListBox.Location = new System.Drawing.Point(3, 33);
            this.chatListBox.Margin = new System.Windows.Forms.Padding(4);
            this.chatListBox.Name = "chatListBox";
            this.chatListBox.Size = new System.Drawing.Size(363, 556);
            this.chatListBox.SubItemMenu = null;
            this.chatListBox.TabIndex = 1;
            // 
            // Usermenu
            // 
            this.Usermenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发送即时消息ToolStripMenuItem,
            this.移动联系人至ToolStripMenuItem,
            this.删除此好友ToolStripMenuItem,
            this.修改备注名ToolStripMenuItem,
            this.聊天记录ToolStripMenuItem,
            this.查看资料ToolStripMenuItem});
            this.Usermenu.Name = "Usermenu";
            this.Usermenu.Size = new System.Drawing.Size(169, 148);
            // 
            // 发送即时消息ToolStripMenuItem
            // 
            this.发送即时消息ToolStripMenuItem.Name = "发送即时消息ToolStripMenuItem";
            this.发送即时消息ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.发送即时消息ToolStripMenuItem.Text = "发送即时消息";
            this.发送即时消息ToolStripMenuItem.Click += new System.EventHandler(this.发送即时消息ToolStripMenuItem_Click);
            // 
            // 移动联系人至ToolStripMenuItem
            // 
            this.移动联系人至ToolStripMenuItem.Name = "移动联系人至ToolStripMenuItem";
            this.移动联系人至ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.移动联系人至ToolStripMenuItem.Text = "移动联系人至";
            // 
            // 删除此好友ToolStripMenuItem
            // 
            this.删除此好友ToolStripMenuItem.Name = "删除此好友ToolStripMenuItem";
            this.删除此好友ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.删除此好友ToolStripMenuItem.Text = "删除此好友";
            // 
            // 修改备注名ToolStripMenuItem
            // 
            this.修改备注名ToolStripMenuItem.Name = "修改备注名ToolStripMenuItem";
            this.修改备注名ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.修改备注名ToolStripMenuItem.Text = "修改备注名";
            // 
            // 聊天记录ToolStripMenuItem
            // 
            this.聊天记录ToolStripMenuItem.Name = "聊天记录ToolStripMenuItem";
            this.聊天记录ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.聊天记录ToolStripMenuItem.Text = "聊天记录";
            // 
            // 查看资料ToolStripMenuItem
            // 
            this.查看资料ToolStripMenuItem.Name = "查看资料ToolStripMenuItem";
            this.查看资料ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.查看资料ToolStripMenuItem.Text = "查看资料";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.Communicate_tabPage);
            this.tabControl1.Controls.Add(this.Apply_tabPage);
            this.tabControl1.Controls.Add(this.Notify_tabPage);
            this.tabControl1.Controls.Add(this.Research_tabPage);
            this.tabControl1.Controls.Add(this.Teach_tabPage);
            this.tabControl1.Controls.Add(this.Collection_tabPage);
            this.tabControl1.Controls.Add(this.Resource_tabPage);
            this.tabControl1.Controls.Add(this.Vedio_tabPage);
            this.tabControl1.Controls.Add(this.Entertain_tabPage);
            this.tabControl1.Controls.Add(this.Class_tabPage);
            this.tabControl1.Location = new System.Drawing.Point(-2, 196);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(397, 605);
            this.tabControl1.TabIndex = 5;
            // 
            // Communicate_tabPage
            // 
            this.Communicate_tabPage.Controls.Add(this.chatListBox);
            this.Communicate_tabPage.Controls.Add(this.skinToolStrip1);
            this.Communicate_tabPage.Location = new System.Drawing.Point(26, 4);
            this.Communicate_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.Communicate_tabPage.Name = "Communicate_tabPage";
            this.Communicate_tabPage.Padding = new System.Windows.Forms.Padding(4);
            this.Communicate_tabPage.Size = new System.Drawing.Size(367, 597);
            this.Communicate_tabPage.TabIndex = 0;
            this.Communicate_tabPage.Text = "交流";
            this.Communicate_tabPage.UseVisualStyleBackColor = true;
            // 
            // skinToolStrip1
            // 
            this.skinToolStrip1.Arrow = System.Drawing.Color.Black;
            this.skinToolStrip1.Back = System.Drawing.Color.White;
            this.skinToolStrip1.BackRadius = 4;
            this.skinToolStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinToolStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinToolStrip1.BaseForeAnamorphosis = false;
            this.skinToolStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinToolStrip1.BaseItemAnamorphosis = true;
            this.skinToolStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemBorderShow = true;
            this.skinToolStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemDown")));
            this.skinToolStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemMouse")));
            this.skinToolStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemRadius = 4;
            this.skinToolStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip1.Fore = System.Drawing.Color.Black;
            this.skinToolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStrip1.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip1.ItemAnamorphosis = true;
            this.skinToolStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemBorderShow = true;
            this.skinToolStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemRadius = 4;
            this.skinToolStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3,
            this.toolStripSplitButton4});
            this.skinToolStrip1.Location = new System.Drawing.Point(4, 4);
            this.skinToolStrip1.Name = "skinToolStrip1";
            this.skinToolStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.Size = new System.Drawing.Size(359, 27);
            this.skinToolStrip1.TabIndex = 0;
            this.skinToolStrip1.Text = "skinToolStrip1";
            this.skinToolStrip1.TitleAnamorphosis = true;
            this.skinToolStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip1.TitleRadius = 4;
            this.skinToolStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(70, 24);
            this.toolStripSplitButton1.Text = "联系人";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(70, 24);
            this.toolStripSplitButton2.Text = "朋友圈";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(55, 24);
            this.toolStripSplitButton3.Text = "会话";
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(85, 24);
            this.toolStripSplitButton4.Text = "我的课堂";
            // 
            // Apply_tabPage
            // 
            this.Apply_tabPage.Location = new System.Drawing.Point(26, 4);
            this.Apply_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.Apply_tabPage.Name = "Apply_tabPage";
            this.Apply_tabPage.Padding = new System.Windows.Forms.Padding(4);
            this.Apply_tabPage.Size = new System.Drawing.Size(367, 597);
            this.Apply_tabPage.TabIndex = 1;
            this.Apply_tabPage.Text = "应用";
            this.Apply_tabPage.UseVisualStyleBackColor = true;
            // 
            // Notify_tabPage
            // 
            this.Notify_tabPage.Location = new System.Drawing.Point(26, 4);
            this.Notify_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.Notify_tabPage.Name = "Notify_tabPage";
            this.Notify_tabPage.Size = new System.Drawing.Size(367, 597);
            this.Notify_tabPage.TabIndex = 2;
            this.Notify_tabPage.Text = "公告";
            this.Notify_tabPage.UseVisualStyleBackColor = true;
            // 
            // Research_tabPage
            // 
            this.Research_tabPage.Location = new System.Drawing.Point(26, 4);
            this.Research_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.Research_tabPage.Name = "Research_tabPage";
            this.Research_tabPage.Size = new System.Drawing.Size(367, 597);
            this.Research_tabPage.TabIndex = 3;
            this.Research_tabPage.Text = "教研";
            this.Research_tabPage.UseVisualStyleBackColor = true;
            // 
            // Teach_tabPage
            // 
            this.Teach_tabPage.Location = new System.Drawing.Point(26, 4);
            this.Teach_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.Teach_tabPage.Name = "Teach_tabPage";
            this.Teach_tabPage.Size = new System.Drawing.Size(367, 597);
            this.Teach_tabPage.TabIndex = 4;
            this.Teach_tabPage.Text = "备课";
            this.Teach_tabPage.UseVisualStyleBackColor = true;
            // 
            // Collection_tabPage
            // 
            this.Collection_tabPage.Location = new System.Drawing.Point(26, 4);
            this.Collection_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.Collection_tabPage.Name = "Collection_tabPage";
            this.Collection_tabPage.Size = new System.Drawing.Size(367, 597);
            this.Collection_tabPage.TabIndex = 5;
            this.Collection_tabPage.Text = "收藏";
            this.Collection_tabPage.UseVisualStyleBackColor = true;
            // 
            // Resource_tabPage
            // 
            this.Resource_tabPage.Location = new System.Drawing.Point(26, 4);
            this.Resource_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.Resource_tabPage.Name = "Resource_tabPage";
            this.Resource_tabPage.Size = new System.Drawing.Size(367, 597);
            this.Resource_tabPage.TabIndex = 6;
            this.Resource_tabPage.Text = "资源";
            this.Resource_tabPage.UseVisualStyleBackColor = true;
            // 
            // Vedio_tabPage
            // 
            this.Vedio_tabPage.Location = new System.Drawing.Point(26, 4);
            this.Vedio_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.Vedio_tabPage.Name = "Vedio_tabPage";
            this.Vedio_tabPage.Size = new System.Drawing.Size(367, 597);
            this.Vedio_tabPage.TabIndex = 7;
            this.Vedio_tabPage.Text = "视频";
            this.Vedio_tabPage.UseVisualStyleBackColor = true;
            // 
            // Entertain_tabPage
            // 
            this.Entertain_tabPage.Location = new System.Drawing.Point(26, 4);
            this.Entertain_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.Entertain_tabPage.Name = "Entertain_tabPage";
            this.Entertain_tabPage.Size = new System.Drawing.Size(367, 597);
            this.Entertain_tabPage.TabIndex = 8;
            this.Entertain_tabPage.Text = "娱乐";
            this.Entertain_tabPage.UseVisualStyleBackColor = true;
            // 
            // Class_tabPage
            // 
            this.Class_tabPage.Location = new System.Drawing.Point(26, 4);
            this.Class_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.Class_tabPage.Name = "Class_tabPage";
            this.Class_tabPage.Size = new System.Drawing.Size(367, 597);
            this.Class_tabPage.TabIndex = 9;
            this.Class_tabPage.Text = "课堂";
            this.Class_tabPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::IM.Properties.Resources.search_teacher;
            this.pictureBox1.Location = new System.Drawing.Point(33, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.skinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinPanel1.Controls.Add(this.pictureBox1);
            this.skinPanel1.Controls.Add(this.Name_skinLable);
            this.skinPanel1.Controls.Add(this.Sign_skinLabel);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(-2, 0);
            this.skinPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(392, 198);
            this.skinPanel1.TabIndex = 4;
            // 
            // Name_skinLable
            // 
            this.Name_skinLable.AutoSize = true;
            this.Name_skinLable.BackColor = System.Drawing.Color.Transparent;
            this.Name_skinLable.BorderColor = System.Drawing.Color.White;
            this.Name_skinLable.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_skinLable.Location = new System.Drawing.Point(148, 48);
            this.Name_skinLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_skinLable.Name = "Name_skinLable";
            this.Name_skinLable.Size = new System.Drawing.Size(155, 39);
            this.Name_skinLable.TabIndex = 0;
            this.Name_skinLable.Text = "威廉 乔 汀";
            // 
            // Sign_skinLabel
            // 
            this.Sign_skinLabel.AutoSize = true;
            this.Sign_skinLabel.BackColor = System.Drawing.Color.Transparent;
            this.Sign_skinLabel.BorderColor = System.Drawing.Color.White;
            this.Sign_skinLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sign_skinLabel.Location = new System.Drawing.Point(156, 104);
            this.Sign_skinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sign_skinLabel.Name = "Sign_skinLabel";
            this.Sign_skinLabel.Size = new System.Drawing.Size(174, 20);
            this.Sign_skinLabel.TabIndex = 1;
            this.Sign_skinLabel.Text = "主人还没有任何新鲜事。";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 804);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // skinToolStrip2
            // 
            this.skinToolStrip2.Arrow = System.Drawing.Color.Black;
            this.skinToolStrip2.Back = System.Drawing.Color.White;
            this.skinToolStrip2.BackRadius = 4;
            this.skinToolStrip2.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip2.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinToolStrip2.BaseFore = System.Drawing.Color.Black;
            this.skinToolStrip2.BaseForeAnamorphosis = false;
            this.skinToolStrip2.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip2.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip2.BaseHoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.BaseItemAnamorphosis = true;
            this.skinToolStrip2.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.BaseItemBorderShow = true;
            this.skinToolStrip2.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemDown")));
            this.skinToolStrip2.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemMouse")));
            this.skinToolStrip2.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.BaseItemRadius = 4;
            this.skinToolStrip2.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinToolStrip2.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip2.Fore = System.Drawing.Color.Black;
            this.skinToolStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStrip2.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.ItemAnamorphosis = true;
            this.skinToolStrip2.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemBorderShow = true;
            this.skinToolStrip2.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemRadius = 4;
            this.skinToolStrip2.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.skinToolStrip2.Location = new System.Drawing.Point(0, 802);
            this.skinToolStrip2.Name = "skinToolStrip2";
            this.skinToolStrip2.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.Size = new System.Drawing.Size(392, 25);
            this.skinToolStrip2.TabIndex = 7;
            this.skinToolStrip2.Text = "skinToolStrip2";
            this.skinToolStrip2.TitleAnamorphosis = true;
            this.skinToolStrip2.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip2.TitleRadius = 4;
            this.skinToolStrip2.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "查找";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 827);
            this.Controls.Add(this.skinToolStrip2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.skinPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Usermenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Communicate_tabPage.ResumeLayout(false);
            this.Communicate_tabPage.PerformLayout();
            this.skinToolStrip1.ResumeLayout(false);
            this.skinToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinToolStrip2.ResumeLayout(false);
            this.skinToolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.ChatListBox chatListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Communicate_tabPage;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.TabPage Apply_tabPage;
        private System.Windows.Forms.TabPage Notify_tabPage;
        private System.Windows.Forms.TabPage Research_tabPage;
        private System.Windows.Forms.TabPage Teach_tabPage;
        private System.Windows.Forms.TabPage Collection_tabPage;
        private System.Windows.Forms.TabPage Resource_tabPage;
        private System.Windows.Forms.TabPage Vedio_tabPage;
        private System.Windows.Forms.TabPage Entertain_tabPage;
        private System.Windows.Forms.TabPage Class_tabPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel Name_skinLable;
        private CCWin.SkinControl.SkinLabel Sign_skinLabel;
        private System.Windows.Forms.Button button1;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip Usermenu;
        private System.Windows.Forms.ToolStripMenuItem 发送即时消息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移动联系人至ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除此好友ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改备注名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 聊天记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看资料ToolStripMenuItem;

    }
}