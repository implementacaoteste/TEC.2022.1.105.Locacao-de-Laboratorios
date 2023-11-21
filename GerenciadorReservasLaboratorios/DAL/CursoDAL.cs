using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CursoDAL
    {
        public int Inserir(Turma _curso)
        {
            int novaId = 0;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Turma (Nome, Turno)
                                    VALUES (@Nome, @Turno); SELECT SCOPE_IDENTITY();";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _curso.Nome);
                cmd.Parameters.AddWithValue("@Turno", _curso.Turno);

                cmd.Connection = cn;
                cn.Open();

                novaId = Convert.ToInt32(cmd.ExecuteScalar());

                return novaId;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um turma no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Turma> BuscarTodos()
        {
            List<Turma> cursos = new List<Turma>();
            Turma turma;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Turno FROM Turma"; // Inclui o campo Turno aqui
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        turma = new Turma();
                        turma.Id = Convert.ToInt32(rd["Id"]);
                        turma.Nome = rd["Nome"].ToString();
                        turma.Turno = rd["Turno"].ToString(); // Pega o turno do banco de dados

                        cursos.Add(turma);
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
        public Turma BuscarPorId(int id)
        {
            Turma turma = new Turma();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Turno FROM Turma WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        turma.Id = Convert.ToInt32(rd["Id"]);
                        turma.Nome = rd["Nome"].ToString();
                        turma.Turno = rd["Turno"].ToString();
                    }
                }
                return turma;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um turma no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Turma> BuscarPorNome(string _nome)
        {
            List<Turma> cursos = new List<Turma>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Turno FROM Turma WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read()) // Use um loop para ler todos os resultados
                    {
                        Turma turma = new Turma();
                        turma.Id = Convert.ToInt32(rd["Id"]);
                        turma.Nome = rd["Nome"].ToString();
                        turma.Turno = rd["Turno"].ToString();
                        cursos.Add(turma); // Adicione o turma à lista de cursos
                    }
                }
                return cursos; // Retorne a lista de cursos
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar cursos por nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Turma _curso)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Turma SET Nome = @Nome, Turno = @Turno WHERE Id = @Id"; // Inclui o campo Turno aqui
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
                throw new Exception("Ocorreu um erro ao tentar alterar um turma no banco de dados.", ex);
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
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Turma WHERE Id = @Id", cn))
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

                        // Execute o comando SQL para excluir o registro
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir um turma no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
    }
}



