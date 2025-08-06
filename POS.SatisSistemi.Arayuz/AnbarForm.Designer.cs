namespace POS.SatisSistemi.Arayuz
{
    partial class AnbarForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYeniMəhsul = new System.Windows.Forms.Button();
            this.dgvMəhsullar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMəhsullar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnYeniMəhsul);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnYeniMəhsul
            // 
            this.btnYeniMəhsul.BackColor = System.Drawing.Color.ForestGreen;
            this.btnYeniMəhsul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniMəhsul.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnYeniMəhsul.ForeColor = System.Drawing.Color.White;
            this.btnYeniMəhsul.Location = new System.Drawing.Point(12, 12);
            this.btnYeniMəhsul.Name = "btnYeniMəhsul";
            this.btnYeniMəhsul.Size = new System.Drawing.Size(149, 39);
            this.btnYeniMəhsul.TabIndex = 0;
            this.btnYeniMəhsul.Tag = "YeniMəhsul";
            this.btnYeniMəhsul.Text = "Yeni Məhsul";
            this.btnYeniMəhsul.UseVisualStyleBackColor = false;
            this.btnYeniMəhsul.Click += new System.EventHandler(this.btnYeniMəhsul_Click);
            // 
            // dgvMəhsullar
            // 
            this.dgvMəhsullar.AllowUserToAddRows = false;
            this.dgvMəhsullar.AllowUserToDeleteRows = false;
            this.dgvMəhsullar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMəhsullar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMəhsullar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMəhsullar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMəhsullar.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMəhsullar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMəhsullar.Location = new System.Drawing.Point(0, 61);
            this.dgvMəhsullar.Name = "dgvMəhsullar";
            this.dgvMəhsullar.ReadOnly = true;
            this.dgvMəhsullar.RowTemplate.Height = 30;
            this.dgvMəhsullar.Size = new System.Drawing.Size(984, 500);
            this.dgvMəhsullar.TabIndex = 1;
            this.dgvMəhsullar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMəhsullar_CellContentClick);
            // 
            // AnbarForm
            // 
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgvMəhsullar);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "AnbarForm";
            this.Tag = "AnbarFormBasliq";
            this.Text = "Anbar İdarəetməsi";
            this.Load += new System.EventHandler(this.AnbarForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMəhsullar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnYeniMəhsul;
        private System.Windows.Forms.DataGridView dgvMəhsullar;
    }
}