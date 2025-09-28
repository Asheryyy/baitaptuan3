namespace baitap001
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnĐK = new System.Windows.Forms.Button();
            this.chkHide = new System.Windows.Forms.CheckBox();
            this.lblTK = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDN
            // 
            this.txtDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDN.Location = new System.Drawing.Point(268, 74);
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(272, 27);
            this.txtDN.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(268, 153);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(272, 27);
            this.txtMK.TabIndex = 1;
            this.txtMK.TextChanged += new System.EventHandler(this.txtMK_TextChanged);
            // 
            // picHide
            // 
            this.picHide.Image = ((System.Drawing.Image)(resources.GetObject("picHide.Image")));
            this.picHide.Location = new System.Drawing.Point(606, 153);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(43, 30);
            this.picHide.TabIndex = 2;
            this.picHide.TabStop = false;
            // 
            // picShow
            // 
            this.picShow.Image = ((System.Drawing.Image)(resources.GetObject("picShow.Image")));
            this.picShow.Location = new System.Drawing.Point(606, 153);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(43, 30);
            this.picShow.TabIndex = 3;
            this.picShow.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(164, 274);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(282, 35);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Nếu không có tài khoản";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(362, 198);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(154, 51);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnĐK
            // 
            this.btnĐK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnĐK.Location = new System.Drawing.Point(481, 274);
            this.btnĐK.Name = "btnĐK";
            this.btnĐK.Size = new System.Drawing.Size(187, 35);
            this.btnĐK.TabIndex = 6;
            this.btnĐK.Text = "Đăng kí tại đây";
            this.btnĐK.UseVisualStyleBackColor = true;
            this.btnĐK.Click += new System.EventHandler(this.btnĐK_Click);
            // 
            // chkHide
            // 
            this.chkHide.AutoSize = true;
            this.chkHide.Location = new System.Drawing.Point(569, 163);
            this.chkHide.Name = "chkHide";
            this.chkHide.Size = new System.Drawing.Size(18, 17);
            this.chkHide.TabIndex = 7;
            this.chkHide.UseVisualStyleBackColor = true;
            this.chkHide.CheckedChanged += new System.EventHandler(this.chkHide_CheckedChanged);
            // 
            // lblTK
            // 
            this.lblTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.Location = new System.Drawing.Point(100, 74);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(122, 23);
            this.lblTK.TabIndex = 8;
            this.lblTK.Text = "Tài Khoản";
            this.lblTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTK.Click += new System.EventHandler(this.lblTK_Click);
            // 
            // lblMK
            // 
            this.lblMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.Location = new System.Drawing.Point(103, 163);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(119, 23);
            this.lblMK.TabIndex = 9;
            this.lblMK.Text = "Mật Khẩu";
            this.lblMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMK.Click += new System.EventHandler(this.lblMK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblTK);
            this.Controls.Add(this.chkHide);
            this.Controls.Add(this.btnĐK);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.picHide);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtDN);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnĐK;
        private System.Windows.Forms.CheckBox chkHide;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblMK;
    }
}

