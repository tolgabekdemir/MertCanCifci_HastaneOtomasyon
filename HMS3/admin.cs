using HMS.Classes;
using HMS3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS3
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        /*void Yenile()
        {
            dgv_Admin.DataSource = Crud.List("Select * from kullaniciKayit");
        }*/
        void Temizle()
        {
            foreach (Control items in this.PnlAdmin.Controls)
            {
                if (items is TextBox)
                {
                    items.Text = "";
                    cmbxKullaniciTipi.Text = "";

                }
            }
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sql = "insert into kullaniciKayit (kullaniciTipi,kullaniciAdi,kullaniciSifre) values(@tip,@ad,@sifre)";
            using (SqlCommand cmd = new SqlCommand(sql, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@tip", SqlDbType.VarChar).Value = cmbxKullaniciTipi.Text;
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = txtKullaniciAdi.Text;
                cmd.Parameters.Add("@sifre", SqlDbType.VarChar).Value =txtSifre.Text;
                cmd.ExecuteNonQuery();
            }
            admin_Load(null, null);
            Temizle();
            MessageBox.Show("kayıt eklenmiştir!");
        }

        private void admin_Load(object sender, EventArgs e)
        {
            dgv_Admin.DataSource = null;
            dgv_Admin.DataSource = KullanicilariGetir();
        }

        public List<KullaniciBilgileri> KullanicilariGetir()
        {
            List<KullaniciBilgileri> kullaniciList = new List<KullaniciBilgileri>();

            string sqlSorgusu = "select * from kullaniciKayit";

            using (SqlCommand cmd = new SqlCommand(sqlSorgusu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = Giris.kullaniciID;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        KullaniciBilgileri kullanici = new KullaniciBilgileri();

                        kullanici.kullaniciId = dr["kullaniciId"].ToString();
                        kullanici.kullaniciTipi= dr["kullaniciTipi"].ToString();
                        kullanici.kullaniciAdi = dr["kullaniciAdi"].ToString();
                        kullanici.kullaniciSifre = dr["kullaniciSifre"].ToString();



                        kullaniciList.Add(kullanici);
                    }
                }
            }

            return kullaniciList;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sql = "update kullaniciKayit set kullaniciTipi=@tip,kullaniciAdi=@ad,kullaniciSifre=@sifre where kullaniciId=@Id";
            using (SqlCommand cmd = new SqlCommand(sql, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value= Convert.ToInt32(txtID.Text);
                cmd.Parameters.Add("@tip", SqlDbType.VarChar).Value = cmbxKullaniciTipi.Text;
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = txtKullaniciAdi.Text;
                cmd.Parameters.Add("@sifre", SqlDbType.VarChar).Value = txtSifre.Text;
                cmd.ExecuteNonQuery();
            }
            admin_Load(null, null);
            MessageBox.Show("Başarılı bir şekilde güncellenmiştir.");
        }

        private void dgv_Admin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)

        {
            //SatisPdgvStsPerMain.CurrentRow.Cells[0].Value.ToString();
            txtID.Text = dgv_Admin.CurrentRow.Cells[0].Value.ToString();
            cmbxKullaniciTipi.Text = dgv_Admin.CurrentRow.Cells[1].Value.ToString();
            txtKullaniciAdi.Text = dgv_Admin.CurrentRow.Cells[2].Value.ToString();
            txtSifre.Text = dgv_Admin.CurrentRow.Cells[3].Value.ToString();

        }
      
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Seçili kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string sql = "delete from doktorKayit where satisPersoneli=@StsPer;" +
                             "delete from kullaniciKayit where kullaniciId=@KullaniciId";
                using (SqlCommand cmd = new SqlCommand(sql, DbYonetimi.BaglantiTestEt()))
                {
                    cmd.Parameters.Add("@Stsper", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text);
                    cmd.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text);

                    
                    cmd.ExecuteNonQuery();
                }
                    

                admin_Load(null, null);
                Temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            Giris gr = new Giris();
            gr.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbxKullaniciTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            //dgv_Admin.DataSource = Crud.List("Select * from kullaniciKayit where kullaniciTipi like '%" + txtAra.Text + "%' or kullaniciAdi like '%" + txtAra.Text + "%'");
            string sql = "Select * from kullaniciKayit where kullaniciTipi like '%" + txtAra.Text + "%' or kullaniciAdi like '%" + txtAra.Text + "%'";
            DataTable tbl = new DataTable();
            using (SqlDataAdapter adtr = new SqlDataAdapter(sql, DbYonetimi.BaglantiTestEt()))
            {
                adtr.Fill(tbl);
            }
               
            dgv_Admin.DataSource = tbl;

        }
    }
}
