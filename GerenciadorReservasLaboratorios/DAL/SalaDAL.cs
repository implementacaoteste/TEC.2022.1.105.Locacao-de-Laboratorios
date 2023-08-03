using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class SalaDAL
    {
        public void Inserir(Sala sala)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO Sala (Nome) VALUES (@Nome)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", sala.Nome);

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
                cmd.CommandText = "SELECT Id, Nome FROM Sala";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        sala = new Sala();
                        sala.Id = Convert.ToInt32(rd["Id"]);
                        sala.Nome = rd["Nome"].ToString();
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

        public Sala BuscarPorId(int id)
        {
            Sala sala = new Sala();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome FROM Sala WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        sala.Id = Convert.ToInt32(rd["Id"]);
                        sala.Nome = rd["Nome"].ToString();
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

        public void Alterar(Sala sala)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Sala SET Nome = @Nome WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", sala.Nome);
                cmd.Parameters.AddWithValue("@Id", sala.Id);

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

        public void Excluir(int id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "DELETE FROM Sala WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);

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
