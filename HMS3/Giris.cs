using HMS.Classes;
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
    public partial class Giris : Form
    {
        public static int kullaniciID = 0;

        public Giris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM kullaniciKayit WHERE kullaniciAdi = @KullaniciAdi AND kullaniciSifre = @Sifre";

            using (SqlCommand cmd = new SqlCommand(sql,DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = txtUsername.Text;
                cmd.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = txtSifre.Text;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        var persType = dr["kullaniciTipi"].ToString();

                        if(persType == "Admin")
                        {
                            admin adminForm = new admin();
                            adminForm.Show();
                            this.Hide();
                        }
                        else if(persType == "Doktor")
                        {
                            kullaniciID = Convert.ToInt32(dr["kullaniciId"]);
                            doktor doktorForm = new doktor();
                            doktorForm.Show();
                            this.Hide();
                        }
                        else
                        {

                            kullaniciID = Convert.ToInt32(dr["kullaniciId"]);
                            StsPer SatisForm = new StsPer();
                            SatisForm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        txtUsername.Text = "";
                        txtSifre.Text = "";
                        MessageBox.Show("Kullanıcı adınız veya şifreniz yanlış", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           
        }
        private void Giris_Load(object sender, EventArgs e)
        {
           
        }

        private void btnIptalet_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtSifre.Text = "";
        }
    }
}
