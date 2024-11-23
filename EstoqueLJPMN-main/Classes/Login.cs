using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Classes
{
    internal class Login
    {
        public static string? loginUsuario;

        private string Nome;
        private string Senha;

        public static string Nome2;
        public static string Senha2;

        public static Login? Logar()
        {
            using (var oCn = Data.Conexao())
            {
                Login? Retorno = null;
                string SQL = $"select Nome, Senha from Usuarios Where Nome='{loginUsuario}'";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Login();
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Senha = oDr.GetString(oDr.GetOrdinal("Senha"));
                    Nome2 = Retorno.Nome;
                    Senha2 = Retorno.Senha;
                }
                oDr.Close();
                return Retorno;
            }
        }
    }
}
