using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class SaidasAntecipadasDAL
    {
        public void Inserir(SaidasAntecipadas saidaAntecipada)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO SaidasAntecipadas (IdAluno, IdProfessor, IdCoordenacao, Motivo, Status, DataHoraSaida) 
                                    VALUES (@IdAluno, @IdProfessor, @IdCoordenacao, @Motivo, @Status, @DataHoraSaida)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdAluno", saidaAntecipada.IdAluno);
                cmd.Parameters.AddWithValue("@IdProfessor", saidaAntecipada.IdProfessor);
                cmd.Parameters.AddWithValue("@IdCoordenacao", saidaAntecipada.IdCoordenacao);
                cmd.Parameters.AddWithValue("@Motivo", saidaAntecipada.Motivo);
                cmd.Parameters.AddWithValue("@Status", saidaAntecipada.Status);
                cmd.Parameters.AddWithValue("@DataHoraSaida", saidaAntecipada.DataHoraSaida);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma saída antecipada no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<SaidasAntecipadas> BuscarTodos()
        {
            List<SaidasAntecipadas> saidasAntecipadas = new List<SaidasAntecipadas>();
            SaidasAntecipadas saidaAntecipada;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdAluno, IdProfessor, IdCoordenacao, Motivo, Status, DataHoraSaida FROM SaidasAntecipadas";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        saidaAntecipada = new SaidasAntecipadas();
                        saidaAntecipada.Id = Convert.ToInt32(rd["Id"]);
                        saidaAntecipada.IdAluno = Convert.ToInt32(rd["IdAluno"]);
                        saidaAntecipada.IdProfessor = Convert.ToInt32(rd["IdProfessor"]);
                        saidaAntecipada.IdCoordenacao = Convert.ToInt32(rd["IdCoordenacao"]);
                        saidaAntecipada.Motivo = rd["Motivo"].ToString();
                        saidaAntecipada.Status = rd["Status"].ToString();
                        saidaAntecipada.DataHoraSaida = Convert.ToDateTime(rd["DataHoraSaida"]);

                        saidasAntecipadas.Add(saidaAntecipada);
                    }
                }
                return saidasAntecipadas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as saídas antecipadas no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public SaidasAntecipadas BuscarPorId(int id)
        {
            SaidasAntecipadas saidaAntecipada = new SaidasAntecipadas();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdAluno, IdProfessor, IdCoordenacao, Motivo, Status, DataHoraSaida FROM SaidasAntecipadas WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        saidaAntecipada.Id = Convert.ToInt32(rd["Id"]);
                        saidaAntecipada.IdAluno = Convert.ToInt32(rd["IdAluno"]);
                        saidaAntecipada.IdProfessor = Convert.ToInt32(rd["IdProfessor"]);
                        saidaAntecipada.IdCoordenacao = Convert.ToInt32(rd["IdCoordenacao"]);
                        saidaAntecipada.Motivo = rd["Motivo"].ToString();
                        saidaAntecipada.Status = rd["Status"].ToString();
                        saidaAntecipada.DataHoraSaida = Convert.ToDateTime(rd["DataHoraSaida"]);
                    }
                }
                return saidaAntecipada;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma saída antecipada no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<SaidasAntecipadas> BuscarPorIdAluno(int idAluno)
        {
            List<SaidasAntecipadas> saidasAntecipadas = new List<SaidasAntecipadas>();
            SaidasAntecipadas saidaAntecipada;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdAluno, IdProfessor, IdCoordenacao, Motivo, Status, DataHoraSaida FROM SaidasAntecipadas WHERE IdAluno = @IdAluno";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdAluno", idAluno);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        saidaAntecipada = new SaidasAntecipadas();
                        saidaAntecipada.Id = Convert.ToInt32(rd["Id"]);
                        saidaAntecipada.IdAluno = Convert.ToInt32(rd["IdAluno"]);
                        saidaAntecipada.IdProfessor = Convert.ToInt32(rd["IdProfessor"]);
                        saidaAntecipada.IdCoordenacao = Convert.ToInt32(rd["IdCoordenacao"]);
                        saidaAntecipada.Motivo = rd["Motivo"].ToString();
                        saidaAntecipada.Status = rd["Status"].ToString();
                        saidaAntecipada.DataHoraSaida = Convert.ToDateTime(rd["DataHoraSaida"]);

                        saidasAntecipadas.Add(saidaAntecipada);
                    }
                }
                return saidasAntecipadas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as saídas antecipadas pelo Id do aluno no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<SaidasAntecipadas> BuscarPorIdProfessor(int idProfessor)
        {
            List<SaidasAntecipadas> saidasAntecipadas = new List<SaidasAntecipadas>();
            SaidasAntecipadas saidaAntecipada;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdAluno, IdProfessor, IdCoordenacao, Motivo, Status, DataHoraSaida FROM SaidasAntecipadas WHERE IdProfessor = @IdProfessor";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdProfessor", idProfessor);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        saidaAntecipada = new SaidasAntecipadas();
                        saidaAntecipada.Id = Convert.ToInt32(rd["Id"]);
                        saidaAntecipada.IdAluno = Convert.ToInt32(rd["IdAluno"]);
                        saidaAntecipada.IdProfessor = Convert.ToInt32(rd["IdProfessor"]);
                        saidaAntecipada.IdCoordenacao = Convert.ToInt32(rd["IdCoordenacao"]);
                        saidaAntecipada.Motivo = rd["Motivo"].ToString();
                        saidaAntecipada.Status = rd["Status"].ToString();
                        saidaAntecipada.DataHoraSaida = Convert.ToDateTime(rd["DataHoraSaida"]);

                        saidasAntecipadas.Add(saidaAntecipada);
                    }
                }
                return saidasAntecipadas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as saídas antecipadas pelo Id do professor no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<SaidasAntecipadas> BuscarPorIdCoordenacao(int idCoordenacao)
        {
            List<SaidasAntecipadas> saidasAntecipadas = new List<SaidasAntecipadas>();
            SaidasAntecipadas saidaAntecipada;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdAluno, IdProfessor, IdCoordenacao, Motivo, Status, DataHoraSaida FROM SaidasAntecipadas WHERE IdCoordenacao = @IdCoordenacao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdCoordenacao", idCoordenacao);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        saidaAntecipada = new SaidasAntecipadas();
                        saidaAntecipada.Id = Convert.ToInt32(rd["Id"]);
                        saidaAntecipada.IdAluno = Convert.ToInt32(rd["IdAluno"]);
                        saidaAntecipada.IdProfessor = Convert.ToInt32(rd["IdProfessor"]);
                        saidaAntecipada.IdCoordenacao = Convert.ToInt32(rd["IdCoordenacao"]);
                        saidaAntecipada.Motivo = rd["Motivo"].ToString();
                        saidaAntecipada.Status = rd["Status"].ToString();
                        saidaAntecipada.DataHoraSaida = Convert.ToDateTime(rd["DataHoraSaida"]);

                        saidasAntecipadas.Add(saidaAntecipada);
                    }
                }
                return saidasAntecipadas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as saídas antecipadas pelo Id da coordenação no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(SaidasAntecipadas saidaAntecipada)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE SaidasAntecipadas SET IdAluno = @IdAluno, IdProfessor = @IdProfessor, 
                                    IdCoordenacao = @IdCoordenacao, Motivo = @Motivo, Status = @Status, DataHoraSaida = @DataHoraSaida
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdAluno", saidaAntecipada.IdAluno);
                cmd.Parameters.AddWithValue("@IdProfessor", saidaAntecipada.IdProfessor);
                cmd.Parameters.AddWithValue("@IdCoordenacao", saidaAntecipada.IdCoordenacao);
                cmd.Parameters.AddWithValue("@Motivo", saidaAntecipada.Motivo);
                cmd.Parameters.AddWithValue("@Status", saidaAntecipada.Status);
                cmd.Parameters.AddWithValue("@DataHoraSaida", saidaAntecipada.DataHoraSaida);
                cmd.Parameters.AddWithValue("@Id", saidaAntecipada.Id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar uma saída antecipada no banco de dados.", ex);
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
                cmd.CommandText = "DELETE FROM SaidasAntecipadas WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma saída antecipada do banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}