using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class SalaDAL
    {
        public void Inserir(Sala _sala)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO Sala (Nome, IdPredio, Tipo, Descricao, Estado, Capacidade) VALUES (@Nome, @IdPredio, @Tipo, @Descricao, @Estado, @Capacidade)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _sala.Nome);
                cmd.Parameters.AddWithValue("@IdPredio", _sala.IdPredio);
                cmd.Parameters.AddWithValue("@Tipo", _sala.Tipo);
                cmd.Parameters.AddWithValue("@Descricao", _sala.Descricao);
                cmd.Parameters.AddWithValue("@Estado", _sala.Estado);
                cmd.Parameters.AddWithValue("@Capacidade", _sala.Capacidade);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma sala no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Sala> BuscarTodos()
        {
            List<Sala> salas = new List<Sala>();
            Sala sala;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, IdPredio, Tipo, Descricao, Estado, Capacidade FROM Sala";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        sala = new Sala();
                        sala.Id = Convert.ToInt32(rd["Id"]);
                        sala.Nome = rd["Nome"].ToString();
                        sala.IdPredio = Convert.ToInt32(rd["IdPredio"]);
                        sala.Tipo = rd["Tipo"].ToString();
                        sala.Descricao = rd["Descricao"].ToString();
                        sala.Estado = rd["Estado"].ToString();
                        sala.Capacidade = Convert.ToInt32(rd["Capacidade"]);
                        sala.Predio = new PredioDAL().BuscarPorId(Convert.ToInt32(rd["IdPredio"]));
                        salas.Add(sala);
                    }
                }
                return salas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as salas no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Sala BuscarPorId(int _id)
        {
            Sala sala = new Sala();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, IdPredio, Tipo, Descricao, Estado, Capacidade FROM Sala WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        sala.Id = Convert.ToInt32(rd["Id"]);
                        sala.Nome = rd["Nome"].ToString();
                        sala.IdPredio = Convert.ToInt32(rd["IdPredio"]);
                        sala.Tipo = rd["Tipo"].ToString();
                        sala.Descricao = rd["Descricao"].ToString();
                        sala.Estado = rd["Estado"].ToString();
                        sala.Capacidade = Convert.ToInt32(rd["Capacidade"]);
                        sala.Predio = new PredioDAL().BuscarPorId(Convert.ToInt32(rd["IdPredio"]));
                    }
                }
                return sala;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma sala no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Sala> BuscarPorNome(string nome)
        {
            List<Sala> salas = new List<Sala>(); // Crie uma lista de salas para armazenar os resultados
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, IdPredio, Tipo, Descricao, Estado, Capacidade FROM Sala WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read()) // Use um loop para ler todos os resultados
                    {
                        Sala sala = new Sala();
                        sala.Id = Convert.ToInt32(rd["Id"]);
                        sala.Nome = rd["Nome"].ToString();
                        sala.IdPredio = Convert.ToInt32(rd["IdPredio"]);
                        sala.Tipo = rd["Tipo"].ToString();
                        sala.Descricao = rd["Descricao"].ToString();
                        sala.Estado = rd["Estado"].ToString();
                        sala.Capacidade = Convert.ToInt32(rd["Capacidade"]);
                        sala.Predio = new PredioDAL().BuscarPorId(Convert.ToInt32(rd["IdPredio"]));
                        salas.Add(sala); // Adicione a sala à lista de salas
                    }
                }
                return salas; // Retorne a lista de salas
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar salas por nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Sala _sala)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Sala SET Nome = @Nome, IdPredio = @IdPredio, Tipo = @Tipo, Descricao = @Descricao, Estado = @Estado, Capacidade = @Capacidade WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _sala.Nome);
                cmd.Parameters.AddWithValue("@IdPredio", _sala.IdPredio);
                cmd.Parameters.AddWithValue("@Tipo", _sala.Tipo);
                cmd.Parameters.AddWithValue("@Descricao", _sala.Descricao);
                cmd.Parameters.AddWithValue("@Estado", _sala.Estado);
                cmd.Parameters.AddWithValue("@Capacidade", _sala.Capacidade);
                cmd.Parameters.AddWithValue("@Id", _sala.Id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar uma sala no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "DELETE FROM Sala WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma sala do banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
