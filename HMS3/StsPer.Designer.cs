namespace HMS3
{
    partial class StsPer
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
            this.dgv_StsPer = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDon = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.PnlStsPer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.txtHstId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStsPerMain = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAra2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StsPer)).BeginInit();
            this.PnlStsPer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStsPerMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_StsPer
            // 
            this.dgv_StsPer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_StsPer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_StsPer.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_StsPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StsPer.Location = new System.Drawing.Point(5, 85);
            this.dgv_StsPer.Name = "dgv_StsPer";
            this.dgv_StsPer.Size = new System.Drawing.Size(792, 151);
            this.dgv_StsPer.TabIndex = 47;
            this.dgv_StsPer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StsPer_CellContentClick);
            this.dgv_StsPer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StsPer_CellDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 26);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // btnDon
            // 
            this.btnDon.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDon.Location = new System.Drawing.Point(525, 45);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(129, 34);
            this.btnDon.TabIndex = 45;
            this.btnDon.Text = "Menüye Dön";
            this.btnDon.UseVisualStyleBackColor = false;
            this.btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSil.Location = new System.Drawing.Point(390, 45);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(129, 34);
            this.btnSil.TabIndex = 43;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKaydet.Location = new System.Drawing.Point(120, 45);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(129, 34);
            this.btnKaydet.TabIndex = 42;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuncelle.Location = new System.Drawing.Point(255, 45);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(129, 34);
            this.btnGuncelle.TabIndex = 41;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiyat.Location = new System.Drawing.Point(443, 6);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(87, 26);
            this.txtFiyat.TabIndex = 39;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiyat.ForeColor = System.Drawing.Color.White;
            this.lblFiyat.Location = new System.Drawing.Point(347, 9);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(90, 20);
            this.lblFiyat.TabIndex = 38;
            this.lblFiyat.Text = "Fiyat (TL):";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(7, 9);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(131, 20);
            this.lblTarih.TabIndex = 37;
            this.lblTarih.Text = "Ameliyat Tarihi:";
            // 
            // PnlStsPer
            // 
            this.PnlStsPer.BackColor = System.Drawing.Color.MidnightBlue;
            this.PnlStsPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlStsPer.Controls.Add(this.label1);
            this.PnlStsPer.Controls.Add(this.txtAra);
            this.PnlStsPer.Controls.Add(this.txtHstId);
            this.PnlStsPer.Controls.Add(this.label2);
            this.PnlStsPer.Controls.Add(this.dateTimePicker1);
            this.PnlStsPer.Controls.Add(this.lblTarih);
            this.PnlStsPer.Controls.Add(this.lblFiyat);
            this.PnlStsPer.Controls.Add(this.txtFiyat);
            this.PnlStsPer.Location = new System.Drawing.Point(5, 4);
            this.PnlStsPer.Name = "PnlStsPer";
            this.PnlStsPer.Size = new System.Drawing.Size(792, 35);
            this.PnlStsPer.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(574, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ara:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAra.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAra.ForeColor = System.Drawing.Color.Black;
            this.txtAra.Location = new System.Drawing.Point(616, 6);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(165, 23);
            this.txtAra.TabIndex = 52;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // txtHstId
            // 
            this.txtHstId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHstId.Location = new System.Drawing.Point(104, 26);
            this.txtHstId.Name = "txtHstId";
            this.txtHstId.Size = new System.Drawing.Size(39, 20);
            this.txtHstId.TabIndex = 51;
            this.txtHstId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Hasta Adı:";
            this.label2.Visible = false;
            // 
            // dgvStsPerMain
            // 
            this.dgvStsPerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStsPerMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStsPerMain.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvStsPerMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStsPerMain.Location = new System.Drawing.Point(5, 279);
            this.dgvStsPerMain.Name = "dgvStsPerMain";
            this.dgvStsPerMain.Size = new System.Drawing.Size(792, 159);
            this.dgvStsPerMain.TabIndex = 49;
            this.dgvStsPerMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStsPerMain_CellContentClick);
            this.dgvStsPerMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStsPerMain_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(579, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ara:";
            // 
            // txtAra2
            // 
            this.txtAra2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAra2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txtAra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAra2.ForeColor = System.Drawing.Color.Black;
            this.txtAra2.Location = new System.Drawing.Point(623, 250);
            this.txtAra2.Name = "txtAra2";
            this.txtAra2.Size = new System.Drawing.Size(174, 23);
            this.txtAra2.TabIndex = 50;
            this.txtAra2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StsPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAra2);
            this.Controls.Add(this.dgvStsPerMain);
            this.Controls.Add(this.PnlStsPer);
            this.Controls.Add(this.dgv_StsPer);
            this.Controls.Add(this.btnDon);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGuncelle);
            this.Name = "StsPer";
            this.Text = "Satış Personeli Ekranı";
            this.Load += new System.EventHandler(this.StsPer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StsPer)).EndInit();
            this.PnlStsPer.ResumeLayout(false);
            this.PnlStsPer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStsPerMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_StsPer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDon;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Panel PnlStsPer;
        private System.Windows.Forms.DataGridView dgvStsPerMain;
        private System.Windows.Forms.TextBox txtHstId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAra2;
    }
}

