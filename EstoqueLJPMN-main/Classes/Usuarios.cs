using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Classes
{
    internal class Usuarios
    {
        private string _Nome;
        private string _Senha;
        private int _Id;
        private Boolean _ADM;
        private Boolean _CadPro;
        private Boolean _CadCat;
        private Boolean _PAddPro;
        private Boolean _CadMarca;
        private Boolean _CadFor;
        private Boolean _CadUsuario;
        public int CadPro2;
        public int CadCat2;
        public int PAddPro2;
        public int CadUsuario2;
        public int CadMarca2;
        public int CadFor2;
        public int PADM2;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public Boolean PADM
        {
            get { return _ADM; }
            set { _ADM = value; }
        }
        public Boolean CadPro
        {
            get { return _CadPro; }
            set { _CadPro = value; }
        }

        public Boolean CadCat
        {
            get { return _CadCat; }
            set { _CadCat = value; }
        }
        public Boolean CadUsuario
        {
            get { return _CadUsuario; }
            set { _CadUsuario = value; }
        }
        public Boolean CadFor
        {
            get { return _CadFor; }
            set { _CadFor = value; }
        }
        public Boolean CadMarca
        {
            get { return _CadMarca; }
            set { _CadMarca = value; }
        }
        public Boolean PAddPro
         {
            get { return _PAddPro; }
            set { _PAddPro = value; }
        }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public string Senha { get => _Senha; set => _Senha = value.Replace("'", ""); }

        public static List<Usuarios> ListarTodosUsuarios()
        {
            using (var oCn = Data.Conexao())
            {
                List<Usuarios> Retorno = new List<Usuarios>();
                string SQL = "select cod, Nome, Senha, PermissaoCadProduto, PermissaoCategoria, PermissaoAddRemProduto, PermissaoUsuario, PermissaoADM, PermissaoMarca, PermissaoFornecedor from Usuarios";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Usuarios oUsuario = new Usuarios();
                    oUsuario.Id = oDr.GetInt32(oDr.GetOrdinal("cod"));
                    oUsuario.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oUsuario.Senha = oDr.GetString(oDr.GetOrdinal("Senha"));
                    oUsuario.PADM = oDr.GetBoolean(oDr.GetOrdinal("PermissaoADM"));
                    oUsuario.CadPro = oDr.GetBoolean(oDr.GetOrdinal("PermissaoCadProduto"));
                    oUsuario.CadCat = oDr.GetBoolean(oDr.GetOrdinal("PermissaoCategoria"));
                    oUsuario.CadUsuario = oDr.GetBoolean(oDr.GetOrdinal("PermissaoUsuario"));
                    oUsuario.CadFor = oDr.GetBoolean(oDr.GetOrdinal("PermissaoFornecedor"));
                    oUsuario.CadMarca = oDr.GetBoolean(oDr.GetOrdinal("PermissaoMarca"));
                    oUsuario.PAddPro = oDr.GetBoolean(oDr.GetOrdinal("PermissaoAddRemProduto"));

                    Retorno.Add(oUsuario);
                }
                oDr.Close();
                return Retorno;
            }
        }
        public static Usuarios? Seleciona(int Codigo)
        {
            using (var oCn = Data.Conexao())
            {
                Usuarios? Retorno = null;
                string SQL = $"select cod, Nome, Senha, PermissaoCadProduto, PermissaoCategoria, PermissaoAddRemProduto, PermissaoUsuario, PermissaoADM, PermissaoMarca, PermissaoFornecedor from Usuarios Where Id={Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Usuarios();
                    Retorno.Id = oDr.GetInt32(oDr.GetOrdinal("cod"));
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Senha = oDr.GetString(oDr.GetOrdinal("Senha"));
                    Retorno.PADM = oDr.GetBoolean(oDr.GetOrdinal("PermissaoADM"));
                    Retorno.CadPro = oDr.GetBoolean(oDr.GetOrdinal("PermissaoCadProduto"));
                    Retorno.CadCat = oDr.GetBoolean(oDr.GetOrdinal("PermissaoCategoria"));
                    Retorno.CadUsuario = oDr.GetBoolean(oDr.GetOrdinal("PermissaoUsuario"));
                    Retorno.CadFor = oDr.GetBoolean(oDr.GetOrdinal("PermissaoFornecedor"));
                    Retorno.CadMarca = oDr.GetBoolean(oDr.GetOrdinal("PermissaoMarca"));
                    Retorno.PAddPro = oDr.GetBoolean(oDr.GetOrdinal("PermissaoAddRemProduto"));
                }
                oDr.Close();
                return Retorno;
            }
        }

        public void Incluir()
        {
            using (var oCn = Data.Conexao())
            {
                string SQL = $"insert into Usuarios (Nome, Senha, PermissaoCadProduto, PermissaoCategoria, PermissaoAddRemProduto, PermissaoUsuario, PermissaoADM, PermissaoMarca, PermissaoFornecedor) values ('{this.Nome.Replace("'", "")}','{this.Senha.Replace("'", "")}', {this.CadPro2}, {this.CadCat2}, {this.PAddPro2}, {this.CadUsuario2}, {this.PADM2}, {this.CadMarca2}, {this.CadFor2})";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }

        public static void AlterarUsuario(Usuarios oUsuario)
        {
            using (var oCn = Data.Conexao())
            {
                string SQL = $"Update Usuarios Set Nome= '{oUsuario.Nome.Replace("'", "")}', Senha='{oUsuario.Senha}', PermissaoCadProduto ={oUsuario.CadPro2}, PermissaoCategoria = {oUsuario.CadCat2}, PermissaoAddRemProduto= {oUsuario.PAddPro2}, PermissaoUsuario= {oUsuario.CadUsuario2}, PermissaoADM= {oUsuario.PADM2}, PermissaoMarca= {oUsuario.CadMarca2}, PermissaoFornecedor= {oUsuario.CadFor2} where cod = {oUsuario.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = Data.Conexao())
            {
                string SQL = $"Delete from Usuarios Where cod= {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}
