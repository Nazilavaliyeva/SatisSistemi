namespace POS.SatisSistemi.Arayuz
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblBasliq = new System.Windows.Forms.Label();
            this.lblİstifadəçiAdı = new System.Windows.Forms.Label();
            this.txtİstifadəçiAdı = new System.Windows.Forms.TextBox();
            this.txtŞifrə = new System.Windows.Forms.TextBox();
            this.lblŞifrə = new System.Windows.Forms.Label();
            this.btnGiriş = new System.Windows.Forms.Button();
            this.linkQeydiyyat = new System.Windows.Forms.LinkLabel();
            this.linkŞifrəBərpa = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBasliq
            // 
            this.lblBasliq.AutoSize = true;
            this.lblBasliq.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasliq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblBasliq.Location = new System.Drawing.Point(85, 20);
            this.lblBasliq.Name = "lblBasliq";
            this.lblBasliq.Size = new System.Drawing.Size(142, 30);
            this.lblBasliq.TabIndex = 0;
            this.lblBasliq.Text = "Sistemə Giriş";
            // 
            // lblİstifadəçiAdı
            // 
            this.lblİstifadəçiAdı.AutoSize = true;
            this.lblİstifadəçiAdı.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblİstifadəçiAdı.Location = new System.Drawing.Point(30, 80);
            this.lblİstifadəçiAdı.Name = "lblİstifadəçiAdı";
            this.lblİstifadəçiAdı.Size = new System.Drawing.Size(94, 17);
            this.lblİstifadəçiAdı.TabIndex = 1;
            this.lblİstifadəçiAdı.Text = "İstifadəçi Adı";
            // 
            // txtİstifadəçiAdı
            // 
            this.txtİstifadəçiAdı.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtİstifadəçiAdı.Location = new System.Drawing.Point(33, 100);
            this.txtİstifadəçiAdı.Name = "txtİstifadəçiAdı";
            this.txtİstifadəçiAdı.Size = new System.Drawing.Size(250, 29);
            this.txtİstifadəçiAdı.TabIndex = 0;
            // 
            // txtŞifrə
            // 
            this.txtŞifrə.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtŞifrə.Location = new System.Drawing.Point(33, 160);
            this.txtŞifrə.Name = "txtŞifrə";
            this.txtŞifrə.Size = new System.Drawing.Size(250, 29);
            this.txtŞifrə.TabIndex = 1;
            this.txtŞifrə.UseSystemPasswordChar = true;
            // 
            // lblŞifrə
            // 
            this.lblŞifrə.AutoSize = true;
            this.lblŞifrə.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblŞifrə.Location = new System.Drawing.Point(30, 140);
            this.lblŞifrə.Name = "lblŞifrə";
            this.lblŞifrə.Size = new System.Drawing.Size(37, 17);
            this.lblŞifrə.TabIndex = 3;
            this.lblŞifrə.Text = "Şifrə";
            // 
            // btnGiriş
            // 
            this.btnGiriş.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnGiriş.FlatAppearance.BorderSize = 0;
            this.btnGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiriş.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiriş.ForeColor = System.Drawing.Color.White;
            this.btnGiriş.Location = new System.Drawing.Point(33, 210);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(250, 40);
            this.btnGiriş.TabIndex = 2;
            this.btnGiriş.Text = "GİRİŞ ET";
            this.btnGiriş.UseVisualStyleBackColor = false;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // linkQeydiyyat
            // 
            this.linkQeydiyyat.AutoSize = true;
            this.linkQeydiyyat.Location = new System.Drawing.Point(125, 265);
            this.linkQeydiyyat.Name = "linkQeydiyyat";
            this.linkQeydiyyat.Size = new System.Drawing.Size(62, 17);
            this.linkQeydiyyat.TabIndex = 3;
            this.linkQeydiyyat.TabStop = true;
            this.linkQeydiyyat.Text = "Qeydiyyat";
            this.linkQeydiyyat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQeydiyyat_LinkClicked);
            // 
            // linkŞifrəBərpa
            // 
            this.linkŞifrəBərpa.AutoSize = true;
            this.linkŞifrəBərpa.Location = new System.Drawing.Point(110, 290);
            this.linkŞifrəBərpa.Name = "linkŞifrəBərpa";
            this.linkŞifrəBərpa.Size = new System.Drawing.Size(93, 17);
            this.linkŞifrəBərpa.TabIndex = 4;
            this.linkŞifrəBərpa.TabStop = true;
            this.linkŞifrəBərpa.Text = "Şifrəmi unutdum";
            this.linkŞifrəBərpa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkŞifrəBərpa_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblBasliq);
            this.panel1.Controls.Add(this.linkŞifrəBərpa);
            this.panel1.Controls.Add(this.lblİstifadəçiAdı);
            this.panel1.Controls.Add(this.linkQeydiyyat);
            this.panel1.Controls.Add(this.txtİstifadəçiAdı);
            this.panel1.Controls.Add(this.btnGiriş);
            this.panel1.Controls.Add(this.lblŞifrə);
            this.panel1.Controls.Add(this.txtŞifrə);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 330);
            this.panel1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnGiriş;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(334, 354);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblBasliq;
        private System.Windows.Forms.Label lblİstifadəçiAdı;
        private System.Windows.Forms.TextBox txtİstifadəçiAdı;
        private System.Windows.Forms.TextBox txtŞifrə;
        private System.Windows.Forms.Label lblŞifrə;
        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.LinkLabel linkQeydiyyat;
        private System.Windows.Forms.LinkLabel linkŞifrəBərpa;
        private System.Windows.Forms.Panel panel1;
    }
}