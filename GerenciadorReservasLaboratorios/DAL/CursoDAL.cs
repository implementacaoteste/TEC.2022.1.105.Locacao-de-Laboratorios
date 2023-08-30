using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CursoDAL
    {
        public void Inserir(Curso _curso)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Curso (Nome, Turno) VALUES (@Nome, @Turno)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _curso.Nome);
                cmd.Parameters.AddWithValue("@Turno", _curso.Turno); // Adiciona o turno aqui

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um curso no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Curso> BuscarTodos()
        {
            List<Curso> cursos = new List<Curso>();
            Curso curso;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Turno FROM Curso"; // Inclui o campo Turno aqui
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        curso = new Curso();
                        curso.Id = Convert.ToInt32(rd["Id"]);
                        curso.Nome = rd["Nome"].ToString();
                        curso.Turno = rd["Turno"].ToString(); // Pega o turno do banco de dados

                        cursos.Add(curso);
                    }
                }
                return cursos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os cursos no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Curso BuscarPorId(int id)
        {
            Curso curso = new Curso();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Turno FROM Curso WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        curso.Id = Convert.ToInt32(rd["Id"]);
                        curso.Nome = rd["Nome"].ToString();
                        curso.Turno = rd["Turno"].ToString();
                    }
                }
                return curso;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um curso no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Curso BuscarPorNome(string _nome)
        {
            Curso curso = new Curso();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Turno FROM Curso WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        curso.Id = Convert.ToInt32(rd["Id"]);
                        curso.Nome = rd["Nome"].ToString();
                        curso.Turno = rd["Turno"].ToString();
                    }
                }
                return curso;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um curso por nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Curso _curso)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Curso SET Nome = @Nome, Turno = @Turno WHERE Id = @Id"; // Inclui o campo Turno aqui
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _curso.Nome);
                cmd.Parameters.AddWithValue("@Turno", _curso.Turno); // Adiciona o campo Turno
                cmd.Parameters.AddWithValue("@Id", _curso.Id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar um curso no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Curso WHERE Id = @Id", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", _id);
                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;
                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir um curso no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
    }
}



