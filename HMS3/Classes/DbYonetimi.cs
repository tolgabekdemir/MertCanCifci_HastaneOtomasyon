using HMS3;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Classes
{
    public class DbYonetimi
    {

        public static SqlConnection BaglantiTestEt()
        {
            string dataSource = ConfigurationManager.AppSettings["DataSource"].ToString();
            string InitialCatalog = ConfigurationManager.AppSettings["InitialCatalog"].ToString();
            string UserID = ConfigurationManager.AppSettings["UserID"].ToString();
           // string Password = ConfigurationManager.AppSettings["Password"].ToString();

            SqlConnection baglanti = new SqlConnection();
            {


                baglanti.ConnectionString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;Integrated Security=SSPI;", dataSource, InitialCatalog, UserID);


                if (baglanti != null)
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    SqlConnection.ClearPool(baglanti);
                    SqlConnection.ClearAllPools();
                }
                //baglanti.Database = "";


                return baglanti;
            }
        }
    }
}
