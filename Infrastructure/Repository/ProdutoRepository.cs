using Domain.Entities;
using Infrastructure.Factory;
using Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infrastructure.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly IDbConnection _connection;

        public ProdutoRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }

        public bool IncluirProduto(Produto produto)
        {
            bool incluirProduto = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("InserirProduto", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
                    command.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                    command.Parameters.AddWithValue("@Preco", produto.Preco);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        incluirProduto = true;
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
            return incluirProduto;
        }

        public List<Produto> ConsultarProduto(string nomeProduto)
        {
            List<Produto> lstProdutos = new List<Produto>();
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ConsultarProduto", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NomeProduto", nomeProduto);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produto produto = new Produto
                            {
                                Id = (int)reader["Id"],
                                NomeProduto = reader["NomeProduto"].ToString(),
                                Quantidade = (int)reader["Quantidade"],
                                Preco = (decimal)reader["Preco"]
                            };
                            lstProdutos.Add(produto);
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
            return lstProdutos;
        }

        public bool AlterarProduto(Produto produto)
        {
            bool alterarproduto = false;

            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("AlterarProduto", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@Id", produto.Id);
                    command.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
                    command.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                    command.Parameters.AddWithValue("@Preco", produto.Preco);



                    if (command.ExecuteNonQuery() > 0)
                    {
                        alterarproduto = true;
                    }
                }
            }
            catch
            {
                
            }
            finally
            {
                _connection.Close();
            }
            return alterarproduto;
        }

        public bool ExcluirProduto(int id)
        {
            bool excluirProduto = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ExcluirProduto", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        excluirProduto = true;
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
            return excluirProduto;
        }
    }
}
