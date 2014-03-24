namespace IM
{
    partial class DeleteGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteGroup));
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.Group_skinComboBox = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = "D:\\IM\\IM\\IM\\bin\\Debug\\MP10.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // Group_skinComboBox
            // 
            this.Group_skinComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Group_skinComboBox.FormattingEnabled = true;
            this.Group_skinComboBox.Location = new System.Drawing.Point(124, 84);
            this.Group_skinComboBox.Name = "Group_skinComboBox";
            this.Group_skinComboBox.Size = new System.Drawing.Size(121, 26);
            this.Group_skinComboBox.TabIndex = 0;
            this.Group_skinComboBox.WaterText = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(24, 47);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(174, 20);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "选择你希望删除的分组：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 225);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.Group_skinComboBox);
            this.Name = "DeleteGroup";
            this.Text = "DeleteGroup";
            this.Load += new System.EventHandler(this.DeleteGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private CCWin.SkinControl.SkinComboBox Group_skinComboBox;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}