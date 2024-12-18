﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Classes
{
    internal class Categoria
    {
        private string _Nome;
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public static List<Categoria> ListarTodos()
        {
            using (var oCn = Data.Conexao())
            {
                List<Categoria> Retorno = new List<Categoria>();
                string SQL = "select ID, Nome from Categorias";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Categoria oCategoria = new Categoria();
                    oCategoria.Id = oDr.GetInt32(oDr.GetOrdinal("ID"));
                    oCategoria.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));

                    Retorno.Add(oCategoria);
                }
                oDr.Close();
                return Retorno;
            }
        }

        public static Categoria? Seleciona(int Codigo)
        {

            using (var oCn = Data.Conexao())
            {
                Categoria? Retorno = null;
                string SQL = $"select ID, Nome from Categorias Where Id={Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Categoria();
                    Retorno.Id = oDr.GetInt32(oDr.GetOrdinal("ID"));
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                }
                oDr.Close();
                return Retorno;
            }
        }
        public void Incluir()
        {
        
            using (var oCn = Data.Conexao())
            {
                string SQL = $"insert into Categorias values ('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }

        public static void AlterarCategoria(Categoria oCategoria)
        {
            
            using (var oCn = Data.Conexao())
            {
                string SQL = $"Update Categorias Set Nome= '{oCategoria.Nome.Replace("'", "")}' where ID = {oCategoria.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = Data.Conexao())
            {
                string SQL = $"Delete from Categorias Where ID= {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

    }
}
