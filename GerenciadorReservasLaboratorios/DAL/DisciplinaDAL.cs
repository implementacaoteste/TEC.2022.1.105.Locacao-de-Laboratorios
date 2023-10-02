using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class DisciplinaDAL
    {
        public void Inserir(Disciplina disciplina)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Disciplina (Nome) VALUES (@Nome)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", disciplina.Nome);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma disciplina no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Disciplina> BuscarTodos()
        {
            List<Disciplina> disciplinas = new List<Disciplina>();
            Disciplina disciplina = new Disciplina();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome FROM Disciplina";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        disciplina = new Disciplina();
                        disciplina.Id = Convert.ToInt32(rd["Id"]);
                        disciplina.Nome = rd["Nome"].ToString();

                        disciplinas.Add(disciplina);
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

        public Disciplina BuscarPorId(int id)
        {
            Disciplina disciplina = new Disciplina();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome FROM Disciplina WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        disciplina.Id = Convert.ToInt32(rd["Id"]);
                        disciplina.Nome = rd["Nome"].ToString();
                    }
                }
                return disciplina;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma disciplina no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Disciplina> BuscarPorNome(string _nome)
        {
            List<Disciplina> disciplinas = new List<Disciplina>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome FROM Disciplina WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read()) // Use um loop para ler todos os resultados
                    {
                        Disciplina disciplina = new Disciplina();
                        disciplina.Id = Convert.ToInt32(rd["Id"]);
                        disciplina.Nome = rd["Nome"].ToString();
                        disciplinas.Add(disciplina); // Adicione a disciplina à lista de disciplinas
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

        public void Alterar(Disciplina disciplina)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Disciplina SET Nome = @Nome WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", disciplina.Nome);
                cmd.Parameters.AddWithValue("@Id", disciplina.Id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar uma disciplina no banco de dados.", ex);
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
                cmd.CommandText = "DELETE FROM Disciplina WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma disciplina do banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

