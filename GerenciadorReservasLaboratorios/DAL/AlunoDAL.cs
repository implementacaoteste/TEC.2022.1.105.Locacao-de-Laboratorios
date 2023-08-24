using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class AlunoDAL
    {
        public void Inserir(Aluno aluno)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Aluno (Nome, Matricula, Email)
                                    VALUES (@Nome, @Matricula, @Email)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
                cmd.Parameters.AddWithValue("@Matricula", aluno.Matricula);
                cmd.Parameters.AddWithValue("@Email", aluno.Email);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um aluno no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Aluno> BuscarTodosAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();
            Aluno aluno;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Matricula, Email FROM Aluno";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        aluno = new Aluno();
                        aluno.Id = Convert.ToInt32(rd["Id"]);
                        aluno.Nome = rd["Nome"].ToString();
                        aluno.Matricula = rd["Matricula"].ToString();
                        aluno.Email = rd["Email"].ToString();

                        alunos.Add(aluno);
                    }
                }
                return alunos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os alunos no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Aluno BuscarPorId(int id)
        {
            Aluno aluno = new Aluno();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Matricula, Email FROM Aluno WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        aluno.Id = Convert.ToInt32(rd["Id"]);
                        aluno.Nome = rd["Nome"].ToString();
                        aluno.Matricula = rd["Matricula"].ToString();
                        aluno.Email = rd["Email"].ToString();
                    }
                }
                return aluno;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um aluno no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Aluno BuscarPorMatricula(string matricula)
        {
            Aluno aluno = new Aluno();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Matricula, Email FROM Aluno WHERE Matricula = @Matricula";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Matricula", matricula);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        aluno.Id = Convert.ToInt32(rd["Id"]);
                        aluno.Nome = rd["Nome"].ToString();
                        aluno.Matricula = rd["Matricula"].ToString();
                        aluno.Email = rd["Email"].ToString();
                    }
                }
                return aluno;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um aluno por matrícula no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Aluno> BuscarPorNome(string nome)
        {
            List<Aluno> alunos = new List<Aluno>();
            Aluno aluno;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Matricula, Email FROM Aluno WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        aluno = new Aluno();
                        aluno.Id = Convert.ToInt32(rd["Id"]);
                        aluno.Nome = rd["Nome"].ToString();
                        aluno.Matricula = rd["Matricula"].ToString();
                        aluno.Email = rd["Email"].ToString();
                        alunos.Add(aluno);
                    }
                }
                return alunos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar alunos por nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public string ObterNomePorId(int id)
        {
            string nome = null;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Nome FROM Aluno WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();

                nome = cmd.ExecuteScalar() as string;
                return nome;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o nome do aluno pelo ID no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Aluno aluno)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Aluno SET Nome = @Nome, Matricula = @Matricula, Email = @Email WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
                cmd.Parameters.AddWithValue("@Matricula", aluno.Matricula);
                cmd.Parameters.AddWithValue("@Email", aluno.Email);
                cmd.Parameters.AddWithValue("@Id", aluno.Id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar um aluno no banco de dados.", ex);
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
                cmd.CommandText = "DELETE FROM Aluno WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um aluno do banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

