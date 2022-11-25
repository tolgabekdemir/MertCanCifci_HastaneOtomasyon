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
    public partial class StsPer : Form
    {


        public StsPer()
        {
            InitializeComponent();

        }

        void Temizle()
        {
            foreach (Control items in this.PnlStsPer.Controls)
            {
                if (items is TextBox)
                {
                    items.Text = "";

                }
            }
        }

        private void StsPer_Load(object sender, EventArgs e)
        {
            //dgv_StsPer.DataSource = null;
            dgv_StsPer.DataSource = HastalariGetir();
            dgvStsPerMain.DataSource = null;
            dgvStsPerMain.DataSource = HastalariGoster();
            

        }
        public List<StsPerBilgileri> HastalariGoster()
        {
            List<StsPerBilgileri> hastaList = new List<StsPerBilgileri>();

            string sqlSorgusu = "select * from doktorKayit, kullaniciKayit where kullaniciKayit.kullaniciId=doktorKayit.satisPersoneli and kullaniciId=@KullaniciID";

            using (SqlCommand cmd = new SqlCommand(sqlSorgusu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = Giris.kullaniciID;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        StsPerBilgileri hasta = new StsPerBilgileri();

                        hasta.hastaId = dr["hastaId"].ToString();
                        hasta.hastaNo = dr["hastaNo"].ToString();
                        hasta.hastaCinsiyet = dr["hastaCinsiyet"].ToString();
                        hasta.hastaAd = dr["hastaAd"].ToString();
                        hasta.hastaAdres = dr["hastaAdres"].ToString();
                        hasta.hastaAmeliyat = dr["hastaAmeliyat"].ToString();
                        hasta.tarih = dr["tarih"].ToString();
                        hasta.fiyat = dr["fiyat"].ToString();

                        hastaList.Add(hasta);
                    }
                }
            }

            return hastaList;

        }
        public List<StsPerBilgileri> HastalariGetir() 
        {
            List<StsPerBilgileri> hastaList = new List<StsPerBilgileri>();

            string sqlSorgusu = "select * from doktorKayit where satisPersoneli is null";

            using (SqlCommand cmd = new SqlCommand(sqlSorgusu, DbYonetimi.BaglantiTestEt()))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        StsPerBilgileri hasta = new StsPerBilgileri();

                        hasta.hastaId = dr["hastaId"].ToString();
                        hasta.hastaNo = dr["hastaNo"].ToString();
                        hasta.hastaCinsiyet = dr["hastaCinsiyet"].ToString();
                        hasta.hastaAd = dr["hastaAd"].ToString();
                        hasta.hastaAdres = dr["hastaAdres"].ToString();
                        hasta.hastaAmeliyat = dr["hastaAmeliyat"].ToString();
                        hasta.tarih = dr["tarih"].ToString();
                        hasta.fiyat = dr["fiyat"].ToString();



                        hastaList.Add(hasta);
                    }
                }
            }

            return hastaList;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFiyat.Text == "")
            {
                MessageBox.Show("Fiyat alanı boş geçilemez");
            }
            else
            { 
                string sql = "update doktorKayit set SatisPersoneli=@StsPer, fiyat=@fiyat,tarih=@tarih where hastaId=@hastaId";
                using (SqlCommand cmd = new SqlCommand(sql, DbYonetimi.BaglantiTestEt()))
                {
                    cmd.Parameters.Add("@hastaId", SqlDbType.Int).Value = txtHstId.Text == "" || txtHstId.Text == null ? default(int) : Convert.ToInt32(txtHstId.Text);
                    cmd.Parameters.Add("@StsPer", SqlDbType.Int).Value = Giris.kullaniciID;
                    cmd.Parameters.Add("@fiyat", SqlDbType.Decimal).Value = decimal.Parse(txtFiyat.Text);
                    cmd.Parameters.Add("@Tarih", SqlDbType.Date).Value = dateTimePicker1.Value;


                    cmd.ExecuteNonQuery();

                }
                //dgv_StsPer.DataSource = null;
                //dgv_StsPer.DataBindings.Clear();
                //dgv_StsPer.DataSource = HastalariGetir();
                //dgvStsPerMain.DataSource = null;
                //dgvStsPerMain.DataSource = HastalariGoster();

                StsPer_Load(null,null);
                //diğer yöntem doktor_Load(null, null);
            
                Temizle();
                HastalariGetir();
                MessageBox.Show("Kayıt başarılı bir şekilde eklenmiştir");
            }
    }

        private void dgv_StsPer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHstId.Text = dgv_StsPer.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dgv_StsPer.CurrentRow.Cells[6].Value.ToString();
            txtFiyat.Text = dgv_StsPer.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sql = "update doktorKayit set SatisPersoneli=@StsPer, fiyat=@fiyat,tarih=@tarih where hastaId=@hastaId";
            using (SqlCommand cmd = new SqlCommand(sql, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@hastaId", SqlDbType.Int).Value = Convert.ToInt32(txtHstId.Text);
                cmd.Parameters.Add("@StsPer", SqlDbType.Int).Value = Giris.kullaniciID;
                cmd.Parameters.Add("@fiyat", SqlDbType.Decimal).Value = decimal.Parse(txtFiyat.Text);
                cmd.Parameters.Add("@Tarih", SqlDbType.Date).Value = dateTimePicker1.Value;


                cmd.ExecuteNonQuery();

            }
            //dgv_StsPer.DataSource = null;
            //dgv_StsPer.DataBindings.Clear();
            //dgv_StsPer.DataSource = HastalariGetir();
            dgvStsPerMain.DataSource = null;
            dgvStsPerMain.DataSource = HastalariGoster();


            //diğer yöntem doktor_Load(null, null);
            //Yenile();
            Temizle();
            MessageBox.Show("Kayıt başarılı bir şekilde güncellenmiştir");
        }

        private void dgvStsPerMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
      
            txtHstId.Text = dgvStsPerMain.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dgvStsPerMain.CurrentRow.Cells[6].Value.ToString();
            txtFiyat.Text = dgvStsPerMain.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Seçili kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                for (int i = 0; i < dgvStsPerMain.SelectedRows.Count; i++)
                {
                    string sql = "delete from doktorKayit where hastaId=@hastaId";
                    using (SqlCommand cmd = new SqlCommand(sql, DbYonetimi.BaglantiTestEt()))
                    {
                        cmd.Parameters.Add("@hastaId", SqlDbType.Int).Value = dgvStsPerMain.CurrentRow.Cells[0].Value.ToString();

                        cmd.ExecuteNonQuery();
                    }
                    dgvStsPerMain.DataSource = null;
                    dgvStsPerMain.DataSource = HastalariGoster();
                    Temizle();
                }
            }
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select hastaId, hastaAd, hastaNo, hastaCinsiyet,hastaAdres,hastaAmeliyat,tarih,fiyat from doktorKayit where hastaAd like '%" + txtAra.Text + "%'";
            DataTable tbl = new DataTable();
            using (SqlDataAdapter adtr = new SqlDataAdapter(sql, DbYonetimi.BaglantiTestEt()))
            {
                adtr.Fill(tbl);
            }
                
            dgv_StsPer.DataSource = tbl;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select hastaId, hastaAd, hastaNo, hastaCinsiyet,hastaAdres,hastaAmeliyat,tarih,fiyat from doktorKayit where hastaAd like '%" + txtAra2.Text + "%'";
            DataTable tbl = new DataTable();
            using (SqlDataAdapter adtr = new SqlDataAdapter(sql, DbYonetimi.BaglantiTestEt()))
            {

                adtr.Fill(tbl);
            }   
            
            dgvStsPerMain.DataSource = tbl;
        }

        private void dgvStsPerMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_StsPer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
