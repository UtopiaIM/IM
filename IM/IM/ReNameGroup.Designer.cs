namespace IM
{
    partial class ReNameGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReNameGroup));
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.Group_skinComboBox = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.NewName_TextBox = new CCWin.SkinControl.WaterTextBox();
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
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(22, 49);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(159, 20);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "选择想要修改的组名：";
            // 
            // Group_skinComboBox
            // 
            this.Group_skinComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Group_skinComboBox.FormattingEnabled = true;
            this.Group_skinComboBox.Location = new System.Drawing.Point(184, 43);
            this.Group_skinComboBox.Name = "Group_skinComboBox";
            this.Group_skinComboBox.Size = new System.Drawing.Size(121, 26);
            this.Group_skinComboBox.TabIndex = 1;
            this.Group_skinComboBox.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(64, 103);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(114, 20);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "输入新的组名：";
            // 
            // NewName_TextBox
            // 
            this.NewName_TextBox.Location = new System.Drawing.Point(184, 103);
            this.NewName_TextBox.Name = "NewName_TextBox";
            this.NewName_TextBox.Size = new System.Drawing.Size(121, 25);
            this.NewName_TextBox.TabIndex = 3;
            this.NewName_TextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.NewName_TextBox.WaterText = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ReNameGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 255);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewName_TextBox);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.Group_skinComboBox);
            this.Controls.Add(this.skinLabel1);
            this.Name = "ReNameGroup";
            this.Text = "修改分组名称";
            this.Load += new System.EventHandler(this.ReNameGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinComboBox Group_skinComboBox;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.WaterTextBox NewName_TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}