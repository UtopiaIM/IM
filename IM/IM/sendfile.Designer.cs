namespace IM
{
    partial class sendfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendfile));
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.waterTextBox1 = new CCWin.SkinControl.WaterTextBox();
            this.skinButtom1 = new CCWin.SkinControl.SkinButtom();
            this.skinButtom2 = new CCWin.SkinControl.SkinButtom();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinProgressBar1 = new CCWin.SkinControl.SkinProgressBar();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
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
            this.skinLabel1.Location = new System.Drawing.Point(17, 43);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(129, 20);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "选择发送的文件：";
            // 
            // waterTextBox1
            // 
            this.waterTextBox1.Location = new System.Drawing.Point(152, 43);
            this.waterTextBox1.Name = "waterTextBox1";
            this.waterTextBox1.Size = new System.Drawing.Size(245, 25);
            this.waterTextBox1.TabIndex = 1;
            this.waterTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.waterTextBox1.WaterText = "";
            // 
            // skinButtom1
            // 
            this.skinButtom1.BackColor = System.Drawing.Color.Transparent;
            this.skinButtom1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtom1.DownBack = null;
            this.skinButtom1.Location = new System.Drawing.Point(421, 45);
            this.skinButtom1.MouseBack = null;
            this.skinButtom1.Name = "skinButtom1";
            this.skinButtom1.NormlBack = null;
            this.skinButtom1.Size = new System.Drawing.Size(75, 23);
            this.skinButtom1.TabIndex = 2;
            this.skinButtom1.Text = "选择文件";
            this.skinButtom1.UseVisualStyleBackColor = false;
            // 
            // skinButtom2
            // 
            this.skinButtom2.BackColor = System.Drawing.Color.Transparent;
            this.skinButtom2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtom2.DownBack = null;
            this.skinButtom2.Location = new System.Drawing.Point(224, 165);
            this.skinButtom2.MouseBack = null;
            this.skinButtom2.Name = "skinButtom2";
            this.skinButtom2.NormlBack = null;
            this.skinButtom2.Size = new System.Drawing.Size(75, 23);
            this.skinButtom2.TabIndex = 3;
            this.skinButtom2.Text = "发送文件";
            this.skinButtom2.UseVisualStyleBackColor = false;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(62, 123);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(84, 20);
            this.skinLabel2.TabIndex = 4;
            this.skinLabel2.Text = "发送进度：";
            this.skinLabel2.Click += new System.EventHandler(this.skinLabel2_Click);
            // 
            // skinProgressBar1
            // 
            this.skinProgressBar1.Back = null;
            this.skinProgressBar1.BarBack = null;
            this.skinProgressBar1.ForeColor = System.Drawing.Color.Red;
            this.skinProgressBar1.Location = new System.Drawing.Point(152, 123);
            this.skinProgressBar1.Name = "skinProgressBar1";
            this.skinProgressBar1.Size = new System.Drawing.Size(245, 23);
            this.skinProgressBar1.TabIndex = 5;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(61, 85);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(84, 20);
            this.skinLabel3.TabIndex = 6;
            this.skinLabel3.Text = "文件大小：";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(151, 85);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(51, 20);
            this.skinLabel4.TabIndex = 7;
            this.skinLabel4.Text = "20MB";
            // 
            // sendfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IM.Properties.Resources.teachermanager_背景;
            this.ClientSize = new System.Drawing.Size(519, 234);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinProgressBar1);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinButtom2);
            this.Controls.Add(this.skinButtom1);
            this.Controls.Add(this.waterTextBox1);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sendfile";
            this.Text = "IM教育应用平台";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.WaterTextBox waterTextBox1;
        private CCWin.SkinControl.SkinButtom skinButtom1;
        private CCWin.SkinControl.SkinButtom skinButtom2;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinProgressBar skinProgressBar1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
    }
}