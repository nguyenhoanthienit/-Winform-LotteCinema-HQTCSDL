using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim_Thinh
{
    class Connection
    {
        public static SqlConnection ConnectionData()
        {
            string _connectionString = @"Data Source=.\sqlexpress;Initial Catalog=HQTCSDL;Integrated Security=True";
            SqlConnection cn = new SqlConnection(_connectionString);
            cn.Open();
            return cn;
        }
    }
}
