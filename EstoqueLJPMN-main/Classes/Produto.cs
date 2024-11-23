using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Classes
{
    internal class Produto
    {
        private string _Nome;
        private int _Id;
        private float _Preco;
        private double _Preco2;
        private int _Barra;
        private int _CatId;
        private int _MarcaId;
        private string _MarcaId2;
        private string _CatId2;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int CatId
        {
            get { return _CatId; }
            set { _CatId = value; }
        }
        public int MarcaId
        {
            get { return _MarcaId; }
            set { _MarcaId = value; }
        }

        public float Preco
        {
            get { return _Preco; }
            set { _Preco = value; }
        }

        public double Preco2
        {
            get { return _Preco2; }
            set { _Preco2 = value; }
        }
        public int Barra
        {
            get { return _Barra; }
            set { _Barra = value; }
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public string MarcaId2 { get => _MarcaId2; set => _MarcaId2 = value.Replace("'", ""); }

        public string CatId2 { get => _CatId2; set => _CatId2 = value.Replace("'", ""); }

        public static List<Produto> ListarTodos()
        {
            using (var oCn = Data.Conexao())
            {
                List<Produto> Retorno = new List<Produto>();
                string SQL = "select id, Nome, Categoria_id, Marca_id, Preco, CodigoBarra from Produto ";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Produto oProduto = new Produto();
                    oProduto.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oProduto.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oProduto.CatId = oDr.GetInt32(oDr.GetOrdinal("Categoria_id"));
                    oProduto.MarcaId = oDr.GetInt32(oDr.GetOrdinal("Marca_id"));
                    oProduto.Preco2 = oDr.GetDouble(oDr.GetOrdinal("Preco"));
                    oProduto.Barra = oDr.GetInt32(oDr.GetOrdinal("CodigoBarra"));

                    Retorno.Add(oProduto);
                }
                oDr.Close();
                return Retorno;
            }
        }

        public static Produto? Seleciona(int Codigo)
        {

            using (var oCn = Data.Conexao())
            {
                Produto? Retorno = null;
                string SQL = $"select id, Nome, Catid, Marcaid, Preco, CodigoBarra from Produto Where id={Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Produto();
                    Retorno.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.CatId = oDr.GetInt32(oDr.GetOrdinal("Catid"));
                    Retorno.MarcaId = oDr.GetInt32(oDr.GetOrdinal("Marcaid"));
                    Retorno.Preco = oDr.GetFloat(oDr.GetOrdinal("Preco"));
                    Retorno.Barra = oDr.GetInt32(oDr.GetOrdinal("CodigoBarra"));
                }
                oDr.Close();
                return Retorno;
            }
        }
        public void Incluir()
        {

            using (var oCn = Data.Conexao())
            {
                string SQL = $"insert into Produto (Nome, Categoria_id, Marca_id, Preco, CodigoBarra) values ('{this.Nome.Replace("'", "")}', {this.CatId2}, {this.MarcaId2}, @Valor, {this.Barra})";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.Parameters.AddWithValue("@Valor", Preco);
                comando.ExecuteNonQuery();
            }

        }

        public static void AlterarProduto(Produto oProduto)
        {

            using (var oCn = Data.Conexao())
            {
                string SQL = $"Update Produto Set Nome= '{oProduto.Nome.Replace("'", "")}', Categoria_id = {oProduto.CatId2}, Marca_id = {oProduto.MarcaId2}, Preco= {oProduto.Preco}, CodigoBarra= {oProduto.Barra} where id = {oProduto.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = Data.Conexao())
            {
                string SQL = $"Delete from Produto Where ID= {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}

