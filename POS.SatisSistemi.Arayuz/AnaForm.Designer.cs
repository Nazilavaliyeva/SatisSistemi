namespace POS.SatisSistemi.Arayuz
{
    partial class AnaForm
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
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.btnNisyə = new System.Windows.Forms.Button();
            this.btnKöçürmə = new System.Windows.Forms.Button();
            this.btnKartla = new System.Windows.Forms.Button();
            this.btnNəğd = new System.Windows.Forms.Button();
            this.lblÜmumiYekun = new System.Windows.Forms.Label();
            this.lblÜmumiYekunBaşlıq = new System.Windows.Forms.Label();
            this.pnlÜst = new System.Windows.Forms.Panel();
            this.btnAnbar = new System.Windows.Forms.Button();
            this.btnDilEn = new System.Windows.Forms.Button();
            this.btnDilAz = new System.Windows.Forms.Button();
            this.txtAxtarış = new System.Windows.Forms.TextBox();
            this.dgvSəbət = new System.Windows.Forms.DataGridView();
            this.lbAxtarışNəticələri = new System.Windows.Forms.ListBox();
            this.pnlAlt.SuspendLayout();
            this.pnlÜst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSəbət)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAlt.Controls.Add(this.btnNisyə);
            this.pnlAlt.Controls.Add(this.btnKöçürmə);
            this.pnlAlt.Controls.Add(this.btnKartla);
            this.pnlAlt.Controls.Add(this.btnNəğd);
            this.pnlAlt.Controls.Add(this.lblÜmumiYekun);
            this.pnlAlt.Controls.Add(this.lblÜmumiYekunBaşlıq);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 481);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(984, 80);
            this.pnlAlt.TabIndex = 0;
            // 
            // btnNisyə
            // 
            this.btnNisyə.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNisyə.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNisyə.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNisyə.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNisyə.Location = new System.Drawing.Point(860, 15);
            this.btnNisyə.Name = "btnNisyə";
            this.btnNisyə.Size = new System.Drawing.Size(112, 53);
            this.btnNisyə.TabIndex = 5;
            this.btnNisyə.Tag = "Nisyə";
            this.btnNisyə.Text = "Nisyə";
            this.btnNisyə.UseVisualStyleBackColor = false;
            this.btnNisyə.Click += new System.EventHandler(this.btnÖdəniş_Click);
            // 
            // btnKöçürmə
            // 
            this.btnKöçürmə.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKöçürmə.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnKöçürmə.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKöçürmə.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnKöçürmə.Location = new System.Drawing.Point(742, 15);
            this.btnKöçürmə.Name = "btnKöçürmə";
            this.btnKöçürmə.Size = new System.Drawing.Size(112, 53);
            this.btnKöçürmə.TabIndex = 4;
            this.btnKöçürmə.Tag = "Köçürmə";
            this.btnKöçürmə.Text = "Köçürmə";
            this.btnKöçürmə.UseVisualStyleBackColor = false;
            this.btnKöçürmə.Click += new System.EventHandler(this.btnÖdəniş_Click);
            // 
            // btnKartla
            // 
            this.btnKartla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKartla.BackColor = System.Drawing.Color.MediumPurple;
            this.btnKartla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKartla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnKartla.ForeColor = System.Drawing.Color.White;
            this.btnKartla.Location = new System.Drawing.Point(624, 15);
            this.btnKartla.Name = "btnKartla";
            this.btnKartla.Size = new System.Drawing.Size(112, 53);
            this.btnKartla.TabIndex = 3;
            this.btnKartla.Tag = "Kartla";
            this.btnKartla.Text = "Kartla";
            this.btnKartla.UseVisualStyleBackColor = false;
            this.btnKartla.Click += new System.EventHandler(this.btnÖdəniş_Click);
            // 
            // btnNəğd
            // 
            this.btnNəğd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNəğd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNəğd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNəğd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNəğd.ForeColor = System.Drawing.Color.White;
            this.btnNəğd.Location = new System.Drawing.Point(506, 15);
            this.btnNəğd.Name = "btnNəğd";
            this.btnNəğd.Size = new System.Drawing.Size(112, 53);
            this.btnNəğd.TabIndex = 2;
            this.btnNəğd.Tag = "Nəğd";
            this.btnNəğd.Text = "Nəğd";
            this.btnNəğd.UseVisualStyleBackColor = false;
            this.btnNəğd.Click += new System.EventHandler(this.btnÖdəniş_Click);
            // 
            // lblÜmumiYekun
            // 
            this.lblÜmumiYekun.AutoSize = true;
            this.lblÜmumiYekun.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblÜmumiYekun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblÜmumiYekun.Location = new System.Drawing.Point(230, 23);
            this.lblÜmumiYekun.Name = "lblÜmumiYekun";
            this.lblÜmumiYekun.Size = new System.Drawing.Size(109, 45);
            this.lblÜmumiYekun.TabIndex = 1;
            this.lblÜmumiYekun.Text = "0.00₼";
            // 
            // lblÜmumiYekunBaşlıq
            // 
            this.lblÜmumiYekunBaşlıq.AutoSize = true;
            this.lblÜmumiYekunBaşlıq.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblÜmumiYekunBaşlıq.Location = new System.Drawing.Point(12, 35);
            this.lblÜmumiYekunBaşlıq.Name = "lblÜmumiYekunBaşlıq";
            this.lblÜmumiYekunBaşlıq.Size = new System.Drawing.Size(161, 30);
            this.lblÜmumiYekunBaşlıq.TabIndex = 0;
            this.lblÜmumiYekunBaşlıq.Tag = "ÜmumiYekun";
            this.lblÜmumiYekunBaşlıq.Text = "ÜMUMİ YEKUN:";
            // 
            // pnlÜst
            // 
            this.pnlÜst.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlÜst.Controls.Add(this.btnAnbar);
            this.pnlÜst.Controls.Add(this.btnDilEn);
            this.pnlÜst.Controls.Add(this.btnDilAz);
            this.pnlÜst.Controls.Add(this.txtAxtarış);
            this.pnlÜst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlÜst.Location = new System.Drawing.Point(0, 0);
            this.pnlÜst.Name = "pnlÜst";
            this.pnlÜst.Size = new System.Drawing.Size(984, 60);
            this.pnlÜst.TabIndex = 1;
            // 
            // btnAnbar
            // 
            this.btnAnbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnbar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAnbar.Location = new System.Drawing.Point(753, 14);
            this.btnAnbar.Name = "btnAnbar";
            this.btnAnbar.Size = new System.Drawing.Size(117, 34);
            this.btnAnbar.TabIndex = 3;
            this.btnAnbar.Tag = "Anbar";
            this.btnAnbar.Text = "Anbar";
            this.btnAnbar.UseVisualStyleBackColor = true;
            this.btnAnbar.Click += new System.EventHandler(this.btnAnbar_Click);
            // 
            // btnDilEn
            // 
            this.btnDilEn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDilEn.Location = new System.Drawing.Point(925, 14);
            this.btnDilEn.Name = "btnDilEn";
            this.btnDilEn.Size = new System.Drawing.Size(47, 34);
            this.btnDilEn.TabIndex = 2;
            this.btnDilEn.Tag = "en";
            this.btnDilEn.Text = "EN";
            this.btnDilEn.UseVisualStyleBackColor = true;
            this.btnDilEn.Click += new System.EventHandler(this.btnDil_Click);
            // 
            // btnDilAz
            // 
            this.btnDilAz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDilAz.Location = new System.Drawing.Point(876, 14);
            this.btnDilAz.Name = "btnDilAz";
            this.btnDilAz.Size = new System.Drawing.Size(47, 34);
            this.btnDilAz.TabIndex = 1;
            this.btnDilAz.Tag = "az";
            this.btnDilAz.Text = "AZ";
            this.btnDilAz.UseVisualStyleBackColor = true;
            this.btnDilAz.Click += new System.EventHandler(this.btnDil_Click);
            // 
            // txtAxtarış
            // 
            this.txtAxtarış.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAxtarış.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtAxtarış.Location = new System.Drawing.Point(12, 12);
            this.txtAxtarış.Name = "txtAxtarış";
            this.txtAxtarış.Size = new System.Drawing.Size(730, 35);
            this.txtAxtarış.TabIndex = 0;
            this.txtAxtarış.Tag = "Axtar";
            this.txtAxtarış.TextChanged += new System.EventHandler(this.txtAxtarış_TextChanged);
            // 
            // dgvSəbət
            // 
            this.dgvSəbət.AllowUserToAddRows = false;
            this.dgvSəbət.AllowUserToDeleteRows = false;
            this.dgvSəbət.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSəbət.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSəbət.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSəbət.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSəbət.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSəbət.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSəbət.Location = new System.Drawing.Point(12, 66);
            this.dgvSəbət.Name = "dgvSəbət";
            this.dgvSəbət.RowTemplate.Height = 35;
            this.dgvSəbət.Size = new System.Drawing.Size(960, 409);
            this.dgvSəbət.TabIndex = 2;
            this.dgvSəbət.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSəbət_CellContentClick);
            this.dgvSəbət.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSəbət_CellValueChanged);
            // 
            // lbAxtarışNəticələri
            // 
            this.lbAxtarışNəticələri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAxtarışNəticələri.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbAxtarışNəticələri.FormattingEnabled = true;
            this.lbAxtarışNəticələri.ItemHeight = 21;
            this.lbAxtarışNəticələri.Location = new System.Drawing.Point(12, 66);
            this.lbAxtarışNəticələri.Name = "lbAxtarışNəticələri";
            this.lbAxtarışNəticələri.Size = new System.Drawing.Size(730, 151);
            this.lbAxtarışNəticələri.TabIndex = 3;
            this.lbAxtarışNəticələri.Visible = false;
            this.lbAxtarışNəticələri.DoubleClick += new System.EventHandler(this.lbAxtarışNəticələri_DoubleClick);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lbAxtarışNəticələri);
            this.Controls.Add(this.dgvSəbət);
            this.Controls.Add(this.pnlÜst);
            this.Controls.Add(this.pnlAlt);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "AnaForm";
            this.Tag = "AnaFormBasliq";
            this.Text = "POS - Satış Nöqtəsi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.pnlAlt.ResumeLayout(false);
            this.pnlAlt.PerformLayout();
            this.pnlÜst.ResumeLayout(false);
            this.pnlÜst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSəbət)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Panel pnlÜst;
        private System.Windows.Forms.DataGridView dgvSəbət;
        private System.Windows.Forms.TextBox txtAxtarış;
        private System.Windows.Forms.Label lblÜmumiYekun;
        private System.Windows.Forms.Label lblÜmumiYekunBaşlıq;
        private System.Windows.Forms.Button btnNəğd;
        private System.Windows.Forms.Button btnNisyə;
        private System.Windows.Forms.Button btnKöçürmə;
        private System.Windows.Forms.Button btnKartla;
        private System.Windows.Forms.Button btnAnbar;
        private System.Windows.Forms.Button btnDilEn;
        private System.Windows.Forms.Button btnDilAz;
        private System.Windows.Forms.ListBox lbAxtarışNəticələri;
    }
}