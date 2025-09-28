namespace baitap001
{
    partial class hienthi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hienthi));
            this.lblTK = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHienTK = new System.Windows.Forms.Label();
            this.lblHienEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTK
            // 
            this.lblTK.BackColor = System.Drawing.Color.Transparent;
            this.lblTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.Location = new System.Drawing.Point(138, 71);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(145, 23);
            this.lblTK.TabIndex = 0;
            this.lblTK.Text = "Tài Khoản";
            this.lblTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(138, 212);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(145, 23);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHienTK
            // 
            this.lblHienTK.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHienTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienTK.Location = new System.Drawing.Point(380, 72);
            this.lblHienTK.Name = "lblHienTK";
            this.lblHienTK.Size = new System.Drawing.Size(272, 23);
            this.lblHienTK.TabIndex = 2;
            this.lblHienTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHienTK.Click += new System.EventHandler(this.lblHienTK_Click);
            // 
            // lblHienEmail
            // 
            this.lblHienEmail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHienEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienEmail.Location = new System.Drawing.Point(380, 212);
            this.lblHienEmail.Name = "lblHienEmail";
            this.lblHienEmail.Size = new System.Drawing.Size(272, 23);
            this.lblHienEmail.TabIndex = 3;
            this.lblHienEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHienEmail.Click += new System.EventHandler(this.lblHienEmail_Click);
            // 
            // hienthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHienEmail);
            this.Controls.Add(this.lblHienTK);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTK);
            this.Name = "hienthi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hienthi";
            this.Load += new System.EventHandler(this.hienthi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHienTK;
        private System.Windows.Forms.Label lblHienEmail;
    }
}