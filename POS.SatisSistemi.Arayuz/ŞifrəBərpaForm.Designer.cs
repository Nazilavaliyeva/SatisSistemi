namespace POS.SatisSistemi.Arayuz
{
    partial class ŞifrəBərpaForm
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
            lblBasliq = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnGöndər = new Button();
            btnLəğvEt = new Button();
            lblTəlimat = new Label();
            SuspendLayout();
            // 
            // lblBasliq
            // 
            lblBasliq.AutoSize = true;
            lblBasliq.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblBasliq.ForeColor = Color.FromArgb(0, 117, 214);
            lblBasliq.Location = new Point(85, 20);
            lblBasliq.Name = "lblBasliq";
            lblBasliq.Size = new Size(194, 32);
            lblBasliq.TabIndex = 0;
            lblBasliq.Text = "Şifrənin Bərpası";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblEmail.Location = new Point(57, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 23);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-poçt";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F);
            txtEmail.Location = new Point(60, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 29);
            txtEmail.TabIndex = 0;
            // 
            // btnGöndər
            // 
            btnGöndər.BackColor = Color.FromArgb(0, 117, 214);
            btnGöndər.FlatAppearance.BorderSize = 0;
            btnGöndər.FlatStyle = FlatStyle.Flat;
            btnGöndər.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGöndər.ForeColor = Color.White;
            btnGöndər.Location = new Point(220, 210);
            btnGöndər.Name = "btnGöndər";
            btnGöndər.Size = new Size(130, 40);
            btnGöndər.TabIndex = 1;
            btnGöndər.Text = "Göndər";
            btnGöndər.UseVisualStyleBackColor = false;
            btnGöndər.Click += btnGöndər_Click;
            // 
            // btnLəğvEt
            // 
            btnLəğvEt.BackColor = Color.Gainsboro;
            btnLəğvEt.DialogResult = DialogResult.Cancel;
            btnLəğvEt.FlatAppearance.BorderSize = 0;
            btnLəğvEt.FlatStyle = FlatStyle.Flat;
            btnLəğvEt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLəğvEt.Location = new Point(60, 210);
            btnLəğvEt.Name = "btnLəğvEt";
            btnLəğvEt.Size = new Size(130, 40);
            btnLəğvEt.TabIndex = 2;
            btnLəğvEt.Text = "Ləğv Et";
            btnLəğvEt.UseVisualStyleBackColor = false;
            // 
            // lblTəlimat
            // 
            lblTəlimat.Location = new Point(12, 60);
            lblTəlimat.Name = "lblTəlimat";
            lblTəlimat.Size = new Size(404, 63);
            lblTəlimat.TabIndex = 3;
            lblTəlimat.Text = "Qeydiyyatdan keçdiyiniz e-poçt ünvanını daxil edin. Bərpa təlimatları həmin ünvana göndəriləcək.";
            lblTəlimat.Click += lblTəlimat_Click;
            // 
            // ŞifrəBərpaForm
            // 
            AcceptButton = btnGöndər;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnLəğvEt;
            ClientSize = new Size(421, 300);
            Controls.Add(lblTəlimat);
            Controls.Add(btnLəğvEt);
            Controls.Add(btnGöndər);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblBasliq);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ŞifrəBərpaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifrə Bərpası";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBasliq;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGöndər;
        private System.Windows.Forms.Button btnLəğvEt;
        private System.Windows.Forms.Label lblTəlimat;
    }
}