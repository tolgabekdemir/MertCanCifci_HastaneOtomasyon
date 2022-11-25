namespace HMS3
{
    partial class doktor
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
            this.dgv_Doktor = new System.Windows.Forms.DataGridView();
            this.btnDon = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.cmbxAmeliyat = new System.Windows.Forms.ComboBox();
            this.cmbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtHstAdi = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtHstTel = new System.Windows.Forms.TextBox();
            this.lblAmeliyat = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblHstTel = new System.Windows.Forms.Label();
            this.lblHstAdi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.PnlDoktor = new System.Windows.Forms.Panel();
            this.txtHstId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doktor)).BeginInit();
            this.panel1.SuspendLayout();
            this.PnlDoktor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Doktor
            // 
            this.dgv_Doktor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Doktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Doktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Doktor.Location = new System.Drawing.Point(12, 243);
            this.dgv_Doktor.Name = "dgv_Doktor";
            this.dgv_Doktor.Size = new System.Drawing.Size(776, 206);
            this.dgv_Doktor.TabIndex = 54;
            this.dgv_Doktor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Doktor_CellDoubleClick);
            // 
            // btnDon
            // 
            this.btnDon.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDon.Location = new System.Drawing.Point(635, 202);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(153, 35);
            this.btnDon.TabIndex = 53;
            this.btnDon.Text = "Menüye Dön";
            this.btnDon.UseVisualStyleBackColor = false;
            this.btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTemizle.Location = new System.Drawing.Point(480, 202);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(158, 35);
            this.btnTemizle.TabIndex = 51;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSil.Location = new System.Drawing.Point(328, 202);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(158, 35);
            this.btnSil.TabIndex = 50;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuncelle.Location = new System.Drawing.Point(176, 202);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(158, 35);
            this.btnGuncelle.TabIndex = 49;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEkle.Location = new System.Drawing.Point(21, 202);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(158, 35);
            this.BtnEkle.TabIndex = 48;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbxAmeliyat
            // 
            this.cmbxAmeliyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAmeliyat.FormattingEnabled = true;
            this.cmbxAmeliyat.Items.AddRange(new object[] {
            "Burun şekillendirme",
            "Kepçe kulak ve kulaktaki diğer estetik rahatsızlıklar",
            "Saç ekimleri",
            "Yüz yenileme, germe, göz kapağı kaldırma, kırışık tedavileri",
            "Çene daraltma ve uzatma",
            "Cilt üzerindeki yara izlerinin giderilmesi",
            "Meme operasyonları",
            "Karın germe operasyonu (Abdominoplasti)",
            "Deri üzerinde ve altında fazla yağın alınması, bacak implantları, yağ alma enjeks" +
                "iyonları",
            "İmplantlar üzerinden kontur şekillendirmeleri",
            "Cilt bakımı ve cilt gençleştirme"});
            this.cmbxAmeliyat.Location = new System.Drawing.Point(471, 100);
            this.cmbxAmeliyat.Name = "cmbxAmeliyat";
            this.cmbxAmeliyat.Size = new System.Drawing.Size(256, 24);
            this.cmbxAmeliyat.TabIndex = 47;
            // 
            // cmbxCinsiyet
            // 
            this.cmbxCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxCinsiyet.FormattingEnabled = true;
            this.cmbxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbxCinsiyet.Location = new System.Drawing.Point(135, 96);
            this.cmbxCinsiyet.Name = "cmbxCinsiyet";
            this.cmbxCinsiyet.Size = new System.Drawing.Size(200, 28);
            this.cmbxCinsiyet.TabIndex = 46;
            // 
            // txtHstAdi
            // 
            this.txtHstAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHstAdi.Location = new System.Drawing.Point(135, 25);
            this.txtHstAdi.Name = "txtHstAdi";
            this.txtHstAdi.Size = new System.Drawing.Size(200, 26);
            this.txtHstAdi.TabIndex = 45;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(471, 22);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(256, 65);
            this.txtAdres.TabIndex = 44;
            // 
            // txtHstTel
            // 
            this.txtHstTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHstTel.Location = new System.Drawing.Point(135, 64);
            this.txtHstTel.Name = "txtHstTel";
            this.txtHstTel.Size = new System.Drawing.Size(200, 26);
            this.txtHstTel.TabIndex = 43;
            // 
            // lblAmeliyat
            // 
            this.lblAmeliyat.AutoSize = true;
            this.lblAmeliyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmeliyat.Location = new System.Drawing.Point(383, 104);
            this.lblAmeliyat.Name = "lblAmeliyat";
            this.lblAmeliyat.Size = new System.Drawing.Size(82, 20);
            this.lblAmeliyat.TabIndex = 42;
            this.lblAmeliyat.Text = "Ameliyat:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdres.Location = new System.Drawing.Point(383, 31);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(61, 20);
            this.lblAdres.TabIndex = 41;
            this.lblAdres.Text = "Adres:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinsiyet.Location = new System.Drawing.Point(5, 104);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(77, 20);
            this.lblCinsiyet.TabIndex = 40;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblHstTel
            // 
            this.lblHstTel.AutoSize = true;
            this.lblHstTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHstTel.Location = new System.Drawing.Point(5, 67);
            this.lblHstTel.Name = "lblHstTel";
            this.lblHstTel.Size = new System.Drawing.Size(123, 20);
            this.lblHstTel.TabIndex = 39;
            this.lblHstTel.Text = "Hasta Tel. No:";
            // 
            // lblHstAdi
            // 
            this.lblHstAdi.AutoSize = true;
            this.lblHstAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHstAdi.Location = new System.Drawing.Point(5, 31);
            this.lblHstAdi.Name = "lblHstAdi";
            this.lblHstAdi.Size = new System.Drawing.Size(93, 20);
            this.lblHstAdi.TabIndex = 38;
            this.lblHstAdi.Text = "Hasta Adı:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Controls.Add(this.txtAra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ara:";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Location = new System.Drawing.Point(16, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(253, 34);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Hasta Kayıt Formu";
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAra.ForeColor = System.Drawing.Color.Black;
            this.txtAra.Location = new System.Drawing.Point(541, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(247, 23);
            this.txtAra.TabIndex = 2;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // PnlDoktor
            // 
            this.PnlDoktor.BackColor = System.Drawing.SystemColors.Control;
            this.PnlDoktor.Controls.Add(this.txtHstId);
            this.PnlDoktor.Controls.Add(this.txtHstAdi);
            this.PnlDoktor.Controls.Add(this.label2);
            this.PnlDoktor.Controls.Add(this.lblHstAdi);
            this.PnlDoktor.Controls.Add(this.lblHstTel);
            this.PnlDoktor.Controls.Add(this.lblCinsiyet);
            this.PnlDoktor.Controls.Add(this.lblAdres);
            this.PnlDoktor.Controls.Add(this.lblAmeliyat);
            this.PnlDoktor.Controls.Add(this.txtHstTel);
            this.PnlDoktor.Controls.Add(this.txtAdres);
            this.PnlDoktor.Controls.Add(this.cmbxAmeliyat);
            this.PnlDoktor.Controls.Add(this.cmbxCinsiyet);
            this.PnlDoktor.Location = new System.Drawing.Point(12, 59);
            this.PnlDoktor.Name = "PnlDoktor";
            this.PnlDoktor.Size = new System.Drawing.Size(776, 137);
            this.PnlDoktor.TabIndex = 56;
            // 
            // txtHstId
            // 
            this.txtHstId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHstId.Location = new System.Drawing.Point(136, 118);
            this.txtHstId.Name = "txtHstId";
            this.txtHstId.Size = new System.Drawing.Size(175, 26);
            this.txtHstId.TabIndex = 49;
            this.txtHstId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Hasta Adı:";
            this.label2.Visible = false;
            // 
            // doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlDoktor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Doktor);
            this.Controls.Add(this.btnDon);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Name = "doktor";
            this.Text = "doktor";
            this.Load += new System.EventHandler(this.doktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doktor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlDoktor.ResumeLayout(false);
            this.PnlDoktor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Doktor;
        private System.Windows.Forms.Button btnDon;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.ComboBox cmbxAmeliyat;
        private System.Windows.Forms.ComboBox cmbxCinsiyet;
        private System.Windows.Forms.TextBox txtHstAdi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtHstTel;
        private System.Windows.Forms.Label lblAmeliyat;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblHstTel;
        private System.Windows.Forms.Label lblHstAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Panel PnlDoktor;
        private System.Windows.Forms.TextBox txtHstId;
        private System.Windows.Forms.Label label2;
    }
}