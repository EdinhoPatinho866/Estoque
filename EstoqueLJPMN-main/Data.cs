using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Dados
{
    internal class Data
    {
        public static SqlConnection Conexao()
        {
            string strconnection = "Data Source=DESKTOP-OGM7EIT\\SQLEXPRESS;Initial Catalog = LPJMN; Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection oCn = new SqlConnection(strconnection);
            oCn.Open();
            return oCn;
        }
    }

}
