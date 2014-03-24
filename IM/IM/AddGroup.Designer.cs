namespace IM
{
    partial class AddGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGroup));
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.GroupName_TextBox = new CCWin.SkinControl.WaterTextBox();
            this.OK = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
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
            this.skinLabel1.Location = new System.Drawing.Point(23, 30);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(84, 20);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "分组命名：";
            // 
            // GroupName_TextBox
            // 
            this.GroupName_TextBox.Location = new System.Drawing.Point(27, 62);
            this.GroupName_TextBox.Name = "GroupName_TextBox";
            this.GroupName_TextBox.Size = new System.Drawing.Size(312, 25);
            this.GroupName_TextBox.TabIndex = 1;
            this.GroupName_TextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.GroupName_TextBox.WaterText = "";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(70, 121);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "确认";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(204, 121);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 169);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.GroupName_TextBox);
            this.Controls.Add(this.skinLabel1);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.WaterTextBox GroupName_TextBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button cancel;
    }
}