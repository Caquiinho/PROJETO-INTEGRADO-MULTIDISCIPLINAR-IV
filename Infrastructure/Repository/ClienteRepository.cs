using Domain.Entities;
using Infrastructure.Factory;
using Infrastructure.Interface;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace Repository.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IDbConnection _connection;

        public ClienteRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }

        public bool IncluirCliente(Cliente cliente)
        {
            bool incluirCliente = false;

            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("InserirCliente", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomeEmpresa", cliente.NomeEmpresa);
                    command.Parameters.AddWithValue("@Cnpj", cliente.Cnpj);
                    command.Parameters.AddWithValue("@Cep", cliente.Cep);
                    command.Parameters.AddWithValue("@Email", cliente.Email);
                    command.Parameters.AddWithValue("@Contato", cliente.Contato);
                    command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                    command.Parameters.AddWithValue("@Numero", cliente.Numero);
                    command.Parameters.AddWithValue("@Complemento", cliente.Complemento);
                    command.Parameters.AddWithValue("@Agrotoxico", cliente.Agrotoxico);
                    command.Parameters.AddWithValue("@Adubo", cliente.Adubo);
                    

                    if (command.ExecuteNonQuery() > 0)
                    {
                        incluirCliente = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
            return incluirCliente;
        }

        public List<Cliente> ConsultarCliente(string nomeCliente)
        {
            List<Cliente> lstClientes = new List<Cliente>();
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ConsultarCliente", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomeEmpresa", nomeCliente);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente
                            {
                                Id = (int)reader["Id"],
                                NomeEmpresa = reader["NomeEmpresa"].ToString(),
                                Cnpj = reader["Cnpj"].ToString(),
                                Email = reader["Email"].ToString(),
                                Contato = reader["Contato"].ToString(),
                                Cep = reader["Cep"].ToString(),
                                Endereco = reader["Endereco"].ToString(),
                                Numero = reader["Numero"].ToString(),
                                Complemento = reader["Complemento"].ToString(),
                                Agrotoxico = reader["Agrotoxico"].ToString(),
                                Adubo = reader["Adubo"].ToString(),
                                
                                
                            };

                            lstClientes.Add(cliente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar cliente: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return lstClientes;
        }

        public bool AlterarCliente(Cliente cliente)
        {
            bool alterarCliente = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("AlterarCliente", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomeEmpresa", cliente.NomeEmpresa);
                    command.Parameters.AddWithValue("@Cnpj", cliente.Cnpj);
                    command.Parameters.AddWithValue("@Cep", cliente.Cep);
                    command.Parameters.AddWithValue("@Email", cliente.Email);
                    command.Parameters.AddWithValue("@Contato", cliente.Contato);
                    command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                    command.Parameters.AddWithValue("@Numero", cliente.Numero);
                    command.Parameters.AddWithValue("@Complemento", cliente.Complemento);
                    command.Parameters.AddWithValue("@Agrotoxico", cliente.Agrotoxico);
                    command.Parameters.AddWithValue("@Adubo", cliente.Adubo);
                   

                    if (command.ExecuteNonQuery() > 0)
                    {
                        alterarCliente = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar cliente: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return alterarCliente;
        }

        public bool ExcluirCliente(int id)
        {
            bool excluirCliente = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ExcluirCliente", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", id);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        excluirCliente = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir cliente: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return excluirCliente;
        }

    }
}
