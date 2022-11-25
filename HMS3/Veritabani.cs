using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS3
{
    internal class Veritabani
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=hospitalDB;Integrated Security=True");
    }
}
