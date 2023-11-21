using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class DisciplinaDAL
    {
        public void Inserir(Atividade atividade)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Atividade (Nome) VALUES (@Nome)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", atividade.Nome);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma atividade no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Atividade> BuscarTodos()
        {
            List<Atividade> disciplinas = new List<Atividade>();
            Atividade atividade = new Atividade();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome FROM Atividade";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        atividade = new Atividade();
                        atividade.Id = Convert.ToInt32(rd["Id"]);
                        atividade.Nome = rd["Nome"].ToString();

                        disciplinas.Add(atividade);
                    }
                }
                return disciplinas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as disciplinas no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Atividade BuscarPorId(int id)
        {
            Atividade atividade = new Atividade();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome FROM Atividade WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        atividade.Id = Convert.ToInt32(rd["Id"]);
                        atividade.Nome = rd["Nome"].ToString();
                    }
                }
                return atividade;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma atividade no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Atividade> BuscarPorNome(string _nome)
        {
            List<Atividade> disciplinas = new List<Atividade>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome FROM Atividade WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read()) // Use um loop para ler todos os resultados
                    {
                        Atividade atividade = new Atividade();
                        atividade.Id = Convert.ToInt32(rd["Id"]);
                        atividade.Nome = rd["Nome"].ToString();
                        disciplinas.Add(atividade); // Adicione a atividade à lista de disciplinas
                    }
                }
                return disciplinas; // Retorne a lista de disciplinas
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar disciplinas por nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Atividade atividade)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Atividade SET Nome = @Nome WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", atividade.Nome);
                cmd.Parameters.AddWithValue("@Id", atividade.Id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar uma atividade no banco de dados.", ex);
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
                cmd.CommandText = "DELETE FROM Atividade WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma atividade do banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

