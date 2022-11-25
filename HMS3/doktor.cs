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
    public partial class doktor : Form
    {
        public static int hastaId = 0;
        public doktor()
        {
            InitializeComponent();

            List<Hasta> hastaList = new List<Hasta>();
            List<Doktor> doktorList = new List<Doktor>();

            foreach (var doktor in doktorList)
            {
                foreach (var hasta in hastaList.Where(x=>x.DoktorID == doktor.DoktorID).ToList()) //linq denir
                {
                   
                }
            }
        }

        /*void Yenile()
        {
            dgv_Doktor.DataSource = DbYonetimi.List("select hastaAd, hastaNo, hastaCinsiyet,hastaAdres,hastaAmeliyat from doktorKayit, kullaniciKayit where kullaniciKayit.kullaniciId=doktorKayit.doktorAd and kullaniciId='"+Giris.kullaniciID+"'");
            
        }*/
        void Temizle()
        {
            foreach (Control items in this.PnlDoktor.Controls)
            {
                if (items is TextBox)
                {
                    items.Text = "";
                    cmbxAmeliyat.Text = "";
                    cmbxCinsiyet.Text = "";

                }
            }
        }
        private void doktor_Load(object sender, EventArgs e)
        {
            dgv_Doktor.DataSource = null;
            dgv_Doktor.DataSource = HastalariGetir();
        }

        public List<HastaBilgileri> HastalariGetir()
        {
            List<HastaBilgileri> hastaList = new List<HastaBilgileri>();


            string sqlSorgusu = "select hastaId, hastaAd, hastaNo, hastaCinsiyet,hastaAdres,hastaAmeliyat from doktorKayit, kullaniciKayit where kullaniciKayit.kullaniciId=doktorKayit.doktorAd and kullaniciId=@KullaniciID";

            using (SqlCommand cmd = new SqlCommand(sqlSorgusu,DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = Giris.kullaniciID;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        HastaBilgileri hasta = new HastaBilgileri();

                        hasta.hastaId = dr["hastaId"].ToString();
                        hasta.hastaNo = dr["hastaNo"].ToString();
                        hasta.hastaCinsiyet = dr["hastaCinsiyet"].ToString();
                        hasta.hastaAd = dr["hastaAd"].ToString();
                        hasta.hastaAdres = dr["hastaAdres"].ToString();
                        hasta.hastaAmeliyat = dr["hastaAmeliyat"].ToString();
                    

                        hastaList.Add(hasta);
                    }
                }
            }
            
            return hastaList;
            
        }
        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
           
            string sql = "insert into doktorKayit (hastaAd,hastaNo,hastaCinsiyet,hastaAdres,hastaAmeliyat,doktorAd) values(@hastaAd,@hastaNo,@hastaCinsiyet,@hastaAdres,@hastaAmeliyat,@doktorAd)";
            using (SqlCommand cmd = new SqlCommand(sql, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@doktorAd", SqlDbType.Int).Value = Giris.kullaniciID;
                cmd.Parameters.Add("@hastaAd", SqlDbType.VarChar).Value = txtHstAdi.Text;
                cmd.Parameters.Add("@hastaNo", SqlDbType.VarChar).Value = txtHstTel.Text;
                cmd.Parameters.Add("@hastaCinsiyet", SqlDbType.VarChar).Value = cmbxCinsiyet.Text;
                cmd.Parameters.Add("@hastaAdres", SqlDbType.VarChar).Value = txtAdres.Text;
                cmd.Parameters.Add("@hastaAmeliyat", SqlDbType.VarChar).Value = cmbxAmeliyat.Text;

                cmd.ExecuteNonQuery();

            }
            //Yenile();
            doktor_Load(null, null);
            Temizle();
            MessageBox.Show("kayıt eklenmiştir!");
            //return;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //List<HastaBilgileri> hastaList = new List<HastaBilgileri>();

            string sql = "update doktorKayit set hastaAd=@hastaAd , hastaNo=@hastaNo,hastaCinsiyet=@hastaCinsiyet,hastaAdres=@hastaAdres,hastaAmeliyat=@hastaAmeliyat,doktorAd=@doktorAd where hastaId=@hastaId" ;
            using (SqlCommand cmd = new SqlCommand(sql, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@hastaId", SqlDbType.Int).Value =Convert.ToInt32(txtHstId.Text);
                cmd.Parameters.Add("@doktorAd", SqlDbType.Int).Value = Giris.kullaniciID;
                cmd.Parameters.Add("@hastaAd", SqlDbType.VarChar).Value = txtHstAdi.Text;
                cmd.Parameters.Add("@hastaNo", SqlDbType.VarChar).Value = txtHstTel.Text;
                cmd.Parameters.Add("@hastaCinsiyet", SqlDbType.VarChar).Value = cmbxCinsiyet.Text;
                cmd.Parameters.Add("@hastaAdres", SqlDbType.VarChar).Value = txtAdres.Text;
                cmd.Parameters.Add("@hastaAmeliyat", SqlDbType.VarChar).Value = cmbxAmeliyat.Text;

                cmd.ExecuteNonQuery();

            }
            dgv_Doktor.DataSource = null;
            dgv_Doktor.DataSource =  HastalariGetir();


            //diğer yöntem doktor_Load(null, null);
            //Yenile();
            Temizle();
            MessageBox.Show("Kayıt başarılı bir şekilde güncellenmiştir");
        }

        private void dgv_Doktor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHstId.Text = dgv_Doktor.CurrentRow.Cells[0].Value.ToString();
            txtHstAdi.Text = dgv_Doktor.CurrentRow.Cells[1].Value.ToString();
            txtHstTel.Text = dgv_Doktor.CurrentRow.Cells[2].Value.ToString();
            cmbxCinsiyet.Text = dgv_Doktor.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dgv_Doktor.CurrentRow.Cells[4].Value.ToString();
            cmbxAmeliyat.Text= dgv_Doktor.CurrentRow.Cells[5].Value.ToString();





        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Seçili kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {

                string sql = "delete from doktorKayit where hastaId=@hastaId";
                using (SqlCommand cmd = new SqlCommand(sql, DbYonetimi.BaglantiTestEt()))
                {
                    cmd.Parameters.Add("@hastaId",SqlDbType.Int).Value = dgv_Doktor.CurrentRow.Cells[0].Value.ToString();

                    cmd.ExecuteNonQuery();
                }
                doktor_Load(null, null);
                Temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select hastaId, hastaAd, hastaNo, hastaCinsiyet,hastaAdres,hastaAmeliyat from doktorKayit where hastaAd like '%" + txtAra.Text + "%'";
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, DbYonetimi.BaglantiTestEt());
            adtr.Fill(tbl);
            dgv_Doktor.DataSource = tbl;
        }
    }
}
