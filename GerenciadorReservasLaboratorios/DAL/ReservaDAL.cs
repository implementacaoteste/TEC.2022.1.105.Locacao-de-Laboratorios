using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class ReservaDAL
    {
        public void Inserir(Reserva reserva)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Reserva (IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaData, ReservaHora, DataRetirada, DataDevolucao, Status, Observacoes, Turno)
                                    VALUES (@IdSala, @IdResponsavel, @IdDisciplina, @IdCurso, @Solicitante, @ReservaData, @ReservaHora, @DataRetirada, @DataDevolucao, @Status, @Observacoes, @Turno)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdSala", reserva.IdSala);
                cmd.Parameters.AddWithValue("@IdResponsavel", reserva.IdResponsavel);
                cmd.Parameters.AddWithValue("@IdDisciplina", reserva.IdDisciplina);
                cmd.Parameters.AddWithValue("@IdCurso", reserva.IdCurso);
                cmd.Parameters.AddWithValue("@IdSolicitante", reserva.IdSolicitante);
                cmd.Parameters.AddWithValue("@ReservaData", reserva.ReservaData);
                cmd.Parameters.AddWithValue("@ReservaHora", reserva.ReservaHora);
                cmd.Parameters.AddWithValue("@DataRetirada", reserva.DataRetirada);
                cmd.Parameters.AddWithValue("@DataDevolucao", reserva.DataDevolucao);
                cmd.Parameters.AddWithValue("@Status", reserva.Status);
                cmd.Parameters.AddWithValue("@Observacoes", reserva.Observacoes);
                cmd.Parameters.AddWithValue("@Turno", reserva.Turno);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma reserva no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Reserva> BuscarTodos()
        {
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaData, ReservaHora, DataRetirada, DataDevolucao, Status, Observacoes, Turno FROM Reserva";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["Id"]);
                        reserva.IdSala = Convert.ToInt32(rd["IdSala"]);
                        reserva.IdResponsavel = Convert.ToInt32(rd["IdResponsavel"]);
                        reserva.IdDisciplina = Convert.ToInt32(rd["IdDisciplina"]);
                        reserva.IdCurso = Convert.ToInt32(rd["IdCurso"]);
                        reserva.IdSolicitante = Convert.ToInt32(rd["IdSolicitante"]);
                        reserva.ReservaData = Convert.ToDateTime(rd["ReservaData"]);
                        reserva.ReservaHora = Convert.ToDateTime(rd["ReservaHora"]);
                        reserva.DataRetirada = Convert.ToDateTime(rd["DataRetirada"]);
                        reserva.DataDevolucao = Convert.ToDateTime(rd["DataDevolucao"]);
                        reserva.Status = rd["Status"].ToString();
                        reserva.Observacoes = rd["Observacoes"].ToString();
                        reserva.Turno = rd["Turno"].ToString();

                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as reservas no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Reserva BuscarPorId(int id)
        {
            Reserva reserva = new Reserva();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaData, ReservaHora, DataRetirada, DataDevolucao, Status, Observacoes, Turno FROM Reserva WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        reserva.Id = Convert.ToInt32(rd["Id"]);
                        reserva.IdSala = Convert.ToInt32(rd["IdSala"]);
                        reserva.IdResponsavel = Convert.ToInt32(rd["IdResponsavel"]);
                        reserva.IdDisciplina = Convert.ToInt32(rd["IdDisciplina"]);
                        reserva.IdCurso = Convert.ToInt32(rd["IdCurso"]);
                        reserva.IdSolicitante = Convert.ToInt32(rd["IdSolicitante"]);
                        reserva.ReservaData = Convert.ToDateTime(rd["ReservaData"]);
                        reserva.ReservaHora = Convert.ToDateTime(rd["ReservaHora"]);
                        reserva.DataRetirada = Convert.ToDateTime(rd["DataRetirada"]);
                        reserva.DataDevolucao = Convert.ToDateTime(rd["DataDevolucao"]);
                        reserva.Status = rd["Status"].ToString();
                        reserva.Observacoes = rd["Observacoes"].ToString();
                        reserva.Turno = rd["Turno"].ToString();
                    }
                }
                return reserva;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma reserva no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Reserva> BuscarPorSala(int idSala)
        {
            List<Reserva> reservas = new List<Reserva>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaData, ReservaHora, DataRetirada, DataDevolucao, Status, Observacoes, Turno FROM Reserva WHERE IdSala = @IdSala";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdSala", idSala);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Reserva reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["Id"]);
                        reserva.IdSala = Convert.ToInt32(rd["IdSala"]);
                        reserva.IdResponsavel = Convert.ToInt32(rd["IdResponsavel"]);
                        reserva.IdDisciplina = Convert.ToInt32(rd["IdDisciplina"]);
                        reserva.IdCurso = Convert.ToInt32(rd["IdCurso"]);
                        reserva.IdSolicitante = Convert.ToInt32(rd["IdSolicitante"]);
                        reserva.ReservaData = Convert.ToDateTime(rd["ReservaData"]);
                        reserva.ReservaHora = Convert.ToDateTime(rd["ReservaHora"]);
                        reserva.DataRetirada = Convert.ToDateTime(rd["DataRetirada"]);
                        reserva.DataDevolucao = Convert.ToDateTime(rd["DataDevolucao"]);
                        reserva.Status = rd["Status"].ToString();
                        reserva.Observacoes = rd["Observacoes"].ToString();
                        reserva.Turno = rd["Turno"].ToString();
                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar reservas por Sala no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Reserva> BuscarPorResponsavel(int IdResponsavel)
        {
            List<Reserva> reservas = new List<Reserva>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaData, ReservaHora, DataRetirada, DataDevolucao, Status, Observacoes, Turno FROM Reserva WHERE IdResponsavel = @IdResponsavel";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdResponsavel", IdResponsavel);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Reserva reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["Id"]);
                        reserva.IdSala = Convert.ToInt32(rd["IdSala"]);
                        reserva.IdResponsavel = Convert.ToInt32(rd["IdResponsavel"]);
                        reserva.IdDisciplina = Convert.ToInt32(rd["IdDisciplina"]);
                        reserva.IdCurso = Convert.ToInt32(rd["IdCurso"]);
                        reserva.IdSolicitante = Convert.ToInt32(rd["IdSolicitante"]);
                        reserva.ReservaData = Convert.ToDateTime(rd["ReservaData"]);
                        reserva.ReservaHora = Convert.ToDateTime(rd["ReservaHora"]);
                        reserva.DataRetirada = Convert.ToDateTime(rd["DataRetirada"]);
                        reserva.DataDevolucao = Convert.ToDateTime(rd["DataDevolucao"]);
                        reserva.Status = rd["Status"].ToString();
                        reserva.Observacoes = rd["Observacoes"].ToString();
                        reserva.Turno = rd["Turno"].ToString();
                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar reservas por Usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Reserva> BuscarPorSolicitante(int idSolicitante)
        {
            List<Reserva> reservas = new List<Reserva>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, Solicitante, ReservaData, ReservaHora, DataRetirada, DataDevolucao, Status, Observacoes, Turno FROM Reserva WHERE IdSolicitante = @IdSolicitante";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdSolicitante", idSolicitante);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Reserva reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["Id"]);
                        reserva.IdSala = Convert.ToInt32(rd["IdSala"]);
                        reserva.IdResponsavel = Convert.ToInt32(rd["IdResponsavel"]);
                        reserva.IdDisciplina = Convert.ToInt32(rd["IdDisciplina"]);
                        reserva.IdCurso = Convert.ToInt32(rd["IdCurso"]);
                        reserva.IdSolicitante = Convert.ToInt32(rd["IdSolicitante"]);
                        reserva.ReservaData = Convert.ToDateTime(rd["ReservaData"]);
                        reserva.ReservaHora = Convert.ToDateTime(rd["ReservaHora"]);
                        reserva.DataRetirada = Convert.ToDateTime(rd["DataRetirada"]);
                        reserva.DataDevolucao = Convert.ToDateTime(rd["DataDevolucao"]);
                        reserva.Status = rd["Status"].ToString();
                        reserva.Observacoes = rd["Observacoes"].ToString();
                        reserva.Turno = rd["Turno"].ToString();
                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as reservas por solicitante no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Reserva> BuscarPorDisciplina(int idDisciplina)
        {
            List<Reserva> reservas = new List<Reserva>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaData, ReservaHora, DataRetirada, DataDevolucao, Status, Observacoes, Turno FROM Reserva WHERE IdDisciplina = @IdDisciplina";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdDisciplina", idDisciplina);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Reserva reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["Id"]);
                        reserva.IdSala = Convert.ToInt32(rd["IdSala"]);
                        reserva.IdResponsavel = Convert.ToInt32(rd["IdResponsavel"]);
                        reserva.IdDisciplina = Convert.ToInt32(rd["IdDisciplina"]);
                        reserva.IdCurso = Convert.ToInt32(rd["IdCurso"]);
                        reserva.IdSolicitante = Convert.ToInt32(rd["IdSolicitante"]);
                        reserva.ReservaData = Convert.ToDateTime(rd["ReservaData"]);
                        reserva.ReservaHora = Convert.ToDateTime(rd["ReservaHora"]);
                        reserva.DataRetirada = Convert.ToDateTime(rd["DataRetirada"]);
                        reserva.DataDevolucao = Convert.ToDateTime(rd["DataDevolucao"]);
                        reserva.Status = rd["Status"].ToString();
                        reserva.Observacoes = rd["Observacoes"].ToString();
                        reserva.Turno = rd["Turno"].ToString();
                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar reservas por Disciplina no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Reserva> BuscarPorCurso(int idCurso)
        {
            List<Reserva> reservas = new List<Reserva>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaData, ReservaHora, DataRetirada, DataDevolucao, Status, Observacoes, Turno FROM Reserva WHERE IdCurso = @IdCurso";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdCurso", idCurso);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Reserva reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["Id"]);
                        reserva.IdSala = Convert.ToInt32(rd["IdSala"]);
                        reserva.IdResponsavel = Convert.ToInt32(rd["IdResponsavel"]);
                        reserva.IdDisciplina = Convert.ToInt32(rd["IdDisciplina"]);
                        reserva.IdCurso = Convert.ToInt32(rd["IdCurso"]);
                        reserva.IdSolicitante = Convert.ToInt32(rd["IdSolicitante"]);
                        reserva.ReservaData = Convert.ToDateTime(rd["ReservaData"]);
                        reserva.ReservaHora = Convert.ToDateTime(rd["ReservaHora"]);
                        reserva.DataRetirada = Convert.ToDateTime(rd["DataRetirada"]);
                        reserva.DataDevolucao = Convert.ToDateTime(rd["DataDevolucao"]);
                        reserva.Status = rd["Status"].ToString();
                        reserva.Observacoes = rd["Observacoes"].ToString();
                        reserva.Turno = rd["Turno"].ToString();
                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as reservas por curso no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Reserva> BuscarPorData(DateTime data)
        {
            List<Reserva> reservas = new List<Reserva>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaData, ReservaHora, DataRetirada, DataDevolucao, Status, Observacoes, Turno FROM Reserva WHERE ReservaData = @Data";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Data", data);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Reserva reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["Id"]);
                        reserva.IdSala = Convert.ToInt32(rd["IdSala"]);
                        reserva.IdResponsavel = Convert.ToInt32(rd["IdResponsavel"]);
                        reserva.IdDisciplina = Convert.ToInt32(rd["IdDisciplina"]);
                        reserva.IdCurso = Convert.ToInt32(rd["IdCurso"]);
                        reserva.IdSolicitante = Convert.ToInt32(rd["IdSolicitante"]);
                        reserva.ReservaData = Convert.ToDateTime(rd["ReservaData"]);
                        reserva.ReservaHora = Convert.ToDateTime(rd["ReservaHora"]);
                        reserva.DataRetirada = Convert.ToDateTime(rd["DataRetirada"]);
                        reserva.DataDevolucao = Convert.ToDateTime(rd["DataDevolucao"]);
                        reserva.Status = rd["Status"].ToString();
                        reserva.Observacoes = rd["Observacoes"].ToString();
                        reserva.Turno = rd["Turno"].ToString();
                        reservas.Add(reserva);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as reservas por Data no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
            return reservas;
        }
        public List<Reserva> BuscarPorStatus(string status)
        {
            List<Reserva> reservas = new List<Reserva>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaData, ReservaHora, DataRetirada, DataDevolucao, Status, Observacoes, Turno FROM Reserva WHERE Status = @Status";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Status", status);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Reserva reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["Id"]);
                        reserva.IdSala = Convert.ToInt32(rd["IdSala"]);
                        reserva.IdResponsavel = Convert.ToInt32(rd["IdResponsavel"]);
                        reserva.IdDisciplina = Convert.ToInt32(rd["IdDisciplina"]);
                        reserva.IdCurso = Convert.ToInt32(rd["IdCurso"]);
                        reserva.IdSolicitante = Convert.ToInt32(rd["IdSolicitante"]);
                        reserva.ReservaData = Convert.ToDateTime(rd["ReservaData"]);
                        reserva.ReservaHora = Convert.ToDateTime(rd["ReservaHora"]);
                        reserva.DataRetirada = Convert.ToDateTime(rd["DataRetirada"]);
                        reserva.DataDevolucao = Convert.ToDateTime(rd["DataDevolucao"]);
                        reserva.Status = rd["Status"].ToString();
                        reserva.Observacoes = rd["Observacoes"].ToString();
                        reserva.Turno = rd["Turno"].ToString();
                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as reservas por Status no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Reserva> BuscarPorTurno(string turno)
        {
            List<Reserva> reservas = new List<Reserva>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaData, ReservaHora, DataRetirada, DataDevolucao, Status, Observacoes, Turno FROM Reserva WHERE Turno = @Turno";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Turno", turno);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Reserva reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["Id"]);
                        reserva.IdSala = Convert.ToInt32(rd["IdSala"]);
                        reserva.IdResponsavel = Convert.ToInt32(rd["IdResponsavel"]);
                        reserva.IdDisciplina = Convert.ToInt32(rd["IdDisciplina"]);
                        reserva.IdCurso = Convert.ToInt32(rd["IdCurso"]);
                        reserva.IdSolicitante = Convert.ToInt32(rd["IdSolicitante"]);
                        reserva.ReservaData = Convert.ToDateTime(rd["ReservaData"]);
                        reserva.ReservaHora = Convert.ToDateTime(rd["ReservaHora"]);
                        reserva.DataRetirada = Convert.ToDateTime(rd["DataRetirada"]);
                        reserva.DataDevolucao = Convert.ToDateTime(rd["DataDevolucao"]);
                        reserva.Status = rd["Status"].ToString();
                        reserva.Observacoes = rd["Observacoes"].ToString();
                        reserva.Turno = rd["Turno"].ToString();
                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as reservas por Turno no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Reserva reserva)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Reserva SET IdSala = @IdSala, IdResponsavel = @IdResponsavel, IdDisciplina = @IdDisciplina, IdCurso = @IdCurso, 
                                    IdSolicitante = @IdSolicitante, ReservaData = @ReservaData, ReservaHora = @ReservaHora, DataRetirada = @DataRetirada, 
                                    DataDevolucao = @DataDevolucao, Status = @Status, Observacoes = @Observacoes, Turno = @Turno 
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdSala", reserva.IdSala);
                cmd.Parameters.AddWithValue("@IdResponsavel", reserva.IdResponsavel);
                cmd.Parameters.AddWithValue("@IdDisciplina", reserva.IdDisciplina);
                cmd.Parameters.AddWithValue("@IdCurso", reserva.IdCurso);
                cmd.Parameters.AddWithValue("@IdSolicitante", reserva.IdSolicitante);
                cmd.Parameters.AddWithValue("@ReservaData", reserva.ReservaData);
                cmd.Parameters.AddWithValue("@ReservaHora", reserva.ReservaHora);
                cmd.Parameters.AddWithValue("@DataRetirada", reserva.DataRetirada);
                cmd.Parameters.AddWithValue("@DataDevolucao", reserva.DataDevolucao);
                cmd.Parameters.AddWithValue("@Status", reserva.Status);
                cmd.Parameters.AddWithValue("@Observacoes", reserva.Observacoes);
                cmd.Parameters.AddWithValue("@Turno", reserva.Turno);
                cmd.Parameters.AddWithValue("@Id", reserva.Id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar uma reserva no banco de dados.", ex);
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
                cmd.CommandText = "DELETE FROM Reserva WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a reserva do banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

