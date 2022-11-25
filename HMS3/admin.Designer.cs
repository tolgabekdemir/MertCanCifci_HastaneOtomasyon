namespace HMS3
{
    partial class admin
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
            this.dgv_Admin = new System.Windows.Forms.DataGridView();
            this.btnDon = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbxKullaniciTipi = new System.Windows.Forms.ComboBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblKullaniciTipi = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlAdmin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admin)).BeginInit();
            this.PnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Admin
            // 
            this.dgv_Admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Admin.Location = new System.Drawing.Point(403, 66);
            this.dgv_Admin.Name = "dgv_Admin";
            this.dgv_Admin.Size = new System.Drawing.Size(394, 363);
            this.dgv_Admin.TabIndex = 41;
            this.dgv_Admin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Admin_CellDoubleClick);
            // 
            // btnDon
            // 
            this.btnDon.AutoSize = true;
            this.btnDon.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDon.Location = new System.Drawing.Point(90, 358);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(291, 38);
            this.btnDon.TabIndex = 39;
            this.btnDon.Text = "Menüye Dön";
            this.btnDon.UseVisualStyleBackColor = false;
            this.btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTemizle.Location = new System.Drawing.Point(91, 316);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(292, 36);
            this.btnTemizle.TabIndex = 38;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSil.Location = new System.Drawing.Point(91, 274);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(292, 36);
            this.btnSil.TabIndex = 37;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEkle.Location = new System.Drawing.Point(91, 190);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(292, 36);
            this.btnEkle.TabIndex = 36;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuncelle.Location = new System.Drawing.Point(91, 232);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(292, 36);
            this.btnGuncelle.TabIndex = 35;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbxKullaniciTipi
            // 
            this.cmbxKullaniciTipi.BackColor = System.Drawing.Color.White;
            this.cmbxKullaniciTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxKullaniciTipi.FormattingEnabled = true;
            this.cmbxKullaniciTipi.Items.AddRange(new object[] {
            "Admin",
            "Doktor",
            "Satış Personeli"});
            this.cmbxKullaniciTipi.Location = new System.Drawing.Point(135, 26);
            this.cmbxKullaniciTipi.Name = "cmbxKullaniciTipi";
            this.cmbxKullaniciTipi.Size = new System.Drawing.Size(246, 33);
            this.cmbxKullaniciTipi.TabIndex = 34;
            this.cmbxKullaniciTipi.SelectedIndexChanged += new System.EventHandler(this.cmbxKullaniciTipi_SelectedIndexChanged);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(137, 73);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(246, 30);
            this.txtKullaniciAdi.TabIndex = 33;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Location = new System.Drawing.Point(137, 117);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(246, 30);
            this.txtSifre.TabIndex = 32;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.Location = new System.Drawing.Point(3, 120);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 25);
            this.lblSifre.TabIndex = 31;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(3, 76);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(125, 25);
            this.lblKullaniciAdi.TabIndex = 30;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblKullaniciTipi
            // 
            this.lblKullaniciTipi.AutoSize = true;
            this.lblKullaniciTipi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKullaniciTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciTipi.Location = new System.Drawing.Point(3, 29);
            this.lblKullaniciTipi.Name = "lblKullaniciTipi";
            this.lblKullaniciTipi.Size = new System.Drawing.Size(128, 25);
            this.lblKullaniciTipi.TabIndex = 29;
            this.lblKullaniciTipi.Text = "Kullanıcı Tipi:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(137, 153);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(246, 30);
            this.txtID.TabIndex = 43;
            this.txtID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // PnlAdmin
            // 
            this.PnlAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlAdmin.Controls.Add(this.lblKullaniciTipi);
            this.PnlAdmin.Controls.Add(this.btnDon);
            this.PnlAdmin.Controls.Add(this.lblKullaniciAdi);
            this.PnlAdmin.Controls.Add(this.btnTemizle);
            this.PnlAdmin.Controls.Add(this.lblSifre);
            this.PnlAdmin.Controls.Add(this.btnSil);
            this.PnlAdmin.Controls.Add(this.label1);
            this.PnlAdmin.Controls.Add(this.btnGuncelle);
            this.PnlAdmin.Controls.Add(this.btnEkle);
            this.PnlAdmin.Controls.Add(this.cmbxKullaniciTipi);
            this.PnlAdmin.Controls.Add(this.txtID);
            this.PnlAdmin.Controls.Add(this.txtKullaniciAdi);
            this.PnlAdmin.Controls.Add(this.txtSifre);
            this.PnlAdmin.Location = new System.Drawing.Point(11, 22);
            this.PnlAdmin.Name = "PnlAdmin";
            this.PnlAdmin.Size = new System.Drawing.Size(386, 407);
            this.PnlAdmin.TabIndex = 44;
            this.PnlAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Ara:";
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAra.ForeColor = System.Drawing.Color.Black;
            this.txtAra.Location = new System.Drawing.Point(459, 22);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(338, 30);
            this.txtAra.TabIndex = 45;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.PnlAdmin);
            this.Controls.Add(this.dgv_Admin);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admin)).EndInit();
            this.PnlAdmin.ResumeLayout(false);
            this.PnlAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Admin;
        private System.Windows.Forms.Button btnDon;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbxKullaniciTipi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciTipi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAra;
    }
}