using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class ReservaDAL
    {
        public void Inserir(Reserva reserva)
        {
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"INSERT INTO Reserva (IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaDataInicial, ReservaDataFinal, HoraInicial, HoraFinal, DataRetirada, DataDevolucao, StatusReserva, Observacoes, Turno)
                                    VALUES (@IdSala, @IdResponsavel, @IdDisciplina, @IdCurso, @IdSolicitante, @ReservaDataInicial, @ReservaDataFinal, @HoraInicial, @HoraFinal, @DataRetirada, @DataDevolucao, @StatusReserva, @Observacoes, @Turno)";

                        cmd.Parameters.AddWithValue("@IdSala", reserva.IdSala);
                        cmd.Parameters.AddWithValue("@IdResponsavel", (object)reserva.IdResponsavel ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IdDisciplina", reserva.IdDisciplina);
                        cmd.Parameters.AddWithValue("@IdCurso", reserva.IdCurso);
                        cmd.Parameters.AddWithValue("@IdSolicitante", reserva.IdSolicitante);
                        cmd.Parameters.AddWithValue("@ReservaDataInicial", reserva.ReservaDataInicial);
                        cmd.Parameters.AddWithValue("@ReservaDataFinal", reserva.ReservaDataFinal);
                        cmd.Parameters.AddWithValue("@HoraInicial", reserva.HoraInicial);
                        cmd.Parameters.AddWithValue("@HoraFinal", reserva.HoraFinal);
                        cmd.Parameters.AddWithValue("@DataRetirada", (object)reserva.DataRetirada ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DataDevolucao", (object)reserva.DataDevolucao ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@StatusReserva", reserva.StatusReserva);
                        cmd.Parameters.AddWithValue("@Observacoes", reserva.Observacoes);
                        cmd.Parameters.AddWithValue("@Turno", reserva.Turno);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar inserir uma reserva no banco de dados.", ex);
                }
            }
        }

        public List<Reserva> BuscarTodos()
        {
            List<Reserva> reservas = new List<Reserva>();

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaDataInicial, ReservaDataFinal, HoraInicial, HoraFinal, DataRetirada, DataDevolucao, StatusReserva, Observacoes, Turno FROM Reserva";

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
                                reserva.ReservaDataInicial = Convert.ToDateTime(rd["ReservaDataInicial"]);
                                reserva.ReservaDataFinal = Convert.ToDateTime(rd["ReservaDataFinal"]);
                                reserva.HoraInicial = (TimeSpan)rd["HoraInicial"];
                                reserva.HoraFinal = (TimeSpan)rd["HoraFinal"];
                                reserva.DataRetirada = rd["DataRetirada"] as DateTime?;
                                reserva.DataDevolucao = rd["DataDevolucao"] as DateTime?;
                                reserva.StatusReserva = rd["StatusReserva"].ToString();
                                reserva.Observacoes = rd["Observacoes"].ToString();
                                reserva.Turno = rd["Turno"].ToString();

                                reserva.Sala = new SalaDAL().BuscarPorId(Convert.ToInt32(rd["IdSala"]));
                                reserva.Atividade = new DisciplinaDAL().BuscarPorId(Convert.ToInt32(rd["IdDisciplina"]));
                                reserva.Turma = new CursoDAL().BuscarPorId(Convert.ToInt32(rd["IdCurso"]));
                                reserva.Solicitante = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdSolicitante"]));
                                reserva.Responsavel = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdResponsavel"]));

                                reservas.Add(reserva);
                            }
                        }
                    }

                    return reservas;
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar buscar todas as reservas no banco de dados.", ex);
                }
            }
        }

        public Reserva BuscarPorId(int id)
        {
            Reserva reserva = new Reserva();

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaDataInicial, ReservaDataFinal, HoraInicial, HoraFinal, DataRetirada, DataDevolucao, StatusReserva, Observacoes, Turno FROM Reserva WHERE Id = @Id";
                        cmd.Parameters.AddWithValue("@Id", id);

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
                                reserva.ReservaDataInicial = Convert.ToDateTime(rd["ReservaDataInicial"]);
                                reserva.ReservaDataFinal = Convert.ToDateTime(rd["ReservaDataFinal"]);
                                reserva.HoraInicial = (TimeSpan)rd["HoraInicial"];
                                reserva.HoraFinal = (TimeSpan)rd["HoraFinal"];
                                reserva.DataRetirada = rd["DataRetirada"] as DateTime?;
                                reserva.DataDevolucao = rd["DataDevolucao"] as DateTime?;
                                reserva.StatusReserva = rd["StatusReserva"].ToString();
                                reserva.Observacoes = rd["Observacoes"].ToString();
                                reserva.Turno = rd["Turno"].ToString();

                                reserva.Sala = new SalaDAL().BuscarPorId(Convert.ToInt32(rd["IdSala"]));
                                reserva.Atividade = new DisciplinaDAL().BuscarPorId(Convert.ToInt32(rd["IdDisciplina"]));
                                reserva.Turma = new CursoDAL().BuscarPorId(Convert.ToInt32(rd["IdCurso"]));
                                reserva.Solicitante = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdSolicitante"]));
                                reserva.Responsavel = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdResponsavel"]));
                            }
                        }
                    }

                    return reserva;
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar buscar uma reserva no banco de dados.", ex);
                }
            }
        }

        public List<Reserva> BuscarPorSala(string nomeSala)
        {
            // Use o método BuscarTodos para obter todas as Reservas
            List<Reserva> _todasReservas = BuscarTodos();

            // Use LINQ para filtrar as saídas antecipadas com base no nome do aluno
            List<Reserva> listaReservasFiltradas = _todasReservas
                .Where(s => s.Sala != null && s.Sala.Nome.Equals(nomeSala, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return listaReservasFiltradas;
        }

        public List<Reserva> BuscarPorResponsavel(string nomeResponsavel)
        {
            // Use o método BuscarTodos para obter todas as Reservas
            List<Reserva> _todasReservas = BuscarTodos();

            // Use LINQ para filtrar as saídas antecipadas com base no nome do aluno
            List<Reserva> listaReservasFiltradas = _todasReservas
                .Where(s => s.Responsavel != null && s.Responsavel.Nome.Equals(nomeResponsavel, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return listaReservasFiltradas;
        }

        public List<Reserva> BuscarPorSolicitante(string nomeSolicitante)
        {
            // Use o método BuscarTodos para obter todas as Reservas
            List<Reserva> _todasReservas = BuscarTodos();

            // Use LINQ para filtrar as saídas antecipadas com base no nome do aluno
            List<Reserva> listaReservasFiltradas = _todasReservas
                .Where(s => s.Solicitante != null && s.Solicitante.Nome.Equals(nomeSolicitante, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return listaReservasFiltradas;
        }
        public List<Reserva> BuscarPorDisciplina(string nomeDisciplina)
        {
            // Use o método BuscarTodos para obter todas as Reservas
            List<Reserva> _todasReservas = BuscarTodos();

            // Use LINQ para filtrar as saídas antecipadas com base no nome do aluno
            List<Reserva> listaReservasFiltradas = _todasReservas
                .Where(s => s.Atividade != null && s.Atividade.Nome.Equals(nomeDisciplina, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return listaReservasFiltradas;
        }

        public List<Reserva> BuscarPorCurso(string nomeCurso)
        {
            // Use o método BuscarTodos para obter todas as Reservas
            List<Reserva> _todasReservas = BuscarTodos();

            // Use LINQ para filtrar as saídas antecipadas com base no nome do aluno
            List<Reserva> listaReservasFiltradas = _todasReservas
                .Where(s => s.Turma != null && s.Turma.Nome.Equals(nomeCurso, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return listaReservasFiltradas;
        }

        public List<Reserva> BuscarPorData(DateTime data)
        {
            List<Reserva> reservas = new List<Reserva>();

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaDataInicial, ReservaDataFinal, HoraInicial, HoraFinal, DataRetirada, DataDevolucao, StatusReserva, Observacoes, Turno FROM Reserva WHERE ReservaDataInicial <= @Data AND ReservaDataFinal >= @Data";
                        cmd.Parameters.AddWithValue("@Data", data);

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
                                reserva.ReservaDataInicial = Convert.ToDateTime(rd["ReservaDataInicial"]);
                                reserva.ReservaDataFinal = Convert.ToDateTime(rd["ReservaDataFinal"]);
                                reserva.HoraInicial = (TimeSpan)rd["HoraInicial"];
                                reserva.HoraFinal = (TimeSpan)rd["HoraFinal"];
                                reserva.DataRetirada = rd["DataRetirada"] as DateTime?;
                                reserva.DataDevolucao = rd["DataDevolucao"] as DateTime?;
                                reserva.StatusReserva = rd["StatusReserva"].ToString();
                                reserva.Observacoes = rd["Observacoes"].ToString();
                                reserva.Turno = rd["Turno"].ToString();

                                reserva.Sala = new SalaDAL().BuscarPorId(Convert.ToInt32(rd["IdSala"]));
                                reserva.Atividade = new DisciplinaDAL().BuscarPorId(Convert.ToInt32(rd["IdDisciplina"]));
                                reserva.Turma = new CursoDAL().BuscarPorId(Convert.ToInt32(rd["IdCurso"]));
                                reserva.Solicitante = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdSolicitante"]));
                                reserva.Responsavel = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdResponsavel"]));

                                reservas.Add(reserva);
                            }
                        }
                    }

                    return reservas;
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar buscar as reservas por Data no banco de dados.", ex);
                }
            }
        }

        public List<Reserva> BuscarPorStatus(string status)
        {
            List<Reserva> reservas = new List<Reserva>();

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaDataInicial, ReservaDataFinal, HoraInicial, HoraFinal, DataRetirada, DataDevolucao, StatusReserva, Observacoes, Turno FROM Reserva WHERE StatusReserva = @Status";
                        cmd.Parameters.AddWithValue("@Status", status);

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
                                reserva.ReservaDataInicial = Convert.ToDateTime(rd["ReservaDataInicial"]);
                                reserva.ReservaDataFinal = Convert.ToDateTime(rd["ReservaDataFinal"]);
                                reserva.HoraInicial = (TimeSpan)rd["HoraInicial"];
                                reserva.HoraFinal = (TimeSpan)rd["HoraFinal"];
                                reserva.DataRetirada = rd["DataRetirada"] as DateTime?;
                                reserva.DataDevolucao = rd["DataDevolucao"] as DateTime?;
                                reserva.StatusReserva = rd["StatusReserva"].ToString();
                                reserva.Observacoes = rd["Observacoes"].ToString();
                                reserva.Turno = rd["Turno"].ToString();

                                reserva.Sala = new SalaDAL().BuscarPorId(Convert.ToInt32(rd["IdSala"]));
                                reserva.Atividade = new DisciplinaDAL().BuscarPorId(Convert.ToInt32(rd["IdDisciplina"]));
                                reserva.Turma = new CursoDAL().BuscarPorId(Convert.ToInt32(rd["IdCurso"]));
                                reserva.Solicitante = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdSolicitante"]));
                                reserva.Responsavel = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdResponsavel"]));

                                reservas.Add(reserva);
                            }
                        }
                    }

                    return reservas;
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar buscar as reservas por Status no banco de dados.", ex);
                }
            }
        }

        public List<Reserva> BuscarPorTurno(string turno)
        {
            List<Reserva> reservas = new List<Reserva>();

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT Id, IdSala, IdResponsavel, IdDisciplina, IdCurso, IdSolicitante, ReservaDataInicial, ReservaDataFinal, HoraInicial, HoraFinal, DataRetirada, DataDevolucao, StatusReserva, Observacoes, Turno FROM Reserva WHERE Turno = @Turno";
                        cmd.Parameters.AddWithValue("@Turno", turno);

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
                                reserva.ReservaDataInicial = Convert.ToDateTime(rd["ReservaDataInicial"]);
                                reserva.ReservaDataFinal = Convert.ToDateTime(rd["ReservaDataFinal"]);
                                reserva.HoraInicial = (TimeSpan)rd["HoraInicial"];
                                reserva.HoraFinal = (TimeSpan)rd["HoraFinal"];
                                reserva.DataRetirada = rd["DataRetirada"] as DateTime?;
                                reserva.DataDevolucao = rd["DataDevolucao"] as DateTime?;
                                reserva.StatusReserva = rd["StatusReserva"].ToString();
                                reserva.Observacoes = rd["Observacoes"].ToString();
                                reserva.Turno = rd["Turno"].ToString();

                                reserva.Sala = new SalaDAL().BuscarPorId(Convert.ToInt32(rd["IdSala"]));
                                reserva.Atividade = new DisciplinaDAL().BuscarPorId(Convert.ToInt32(rd["IdDisciplina"]));
                                reserva.Turma = new CursoDAL().BuscarPorId(Convert.ToInt32(rd["IdCurso"]));
                                reserva.Solicitante = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdSolicitante"]));
                                reserva.Responsavel = new UsuarioDAL().BuscarPorId(Convert.ToInt32(rd["IdResponsavel"]));

                                reservas.Add(reserva);
                            }
                        }
                    }

                    return reservas;
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar buscar as reservas por Turno no banco de dados.", ex);
                }
            }
        }

        public void Alterar(Reserva reserva)
        {
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"UPDATE Reserva 
                                   SET IdSala = @IdSala, IdResponsavel = @IdResponsavel, IdDisciplina = @IdDisciplina, IdCurso = @IdCurso, 
                                       IdSolicitante = @IdSolicitante, ReservaDataInicial = @ReservaDataInicial, ReservaDataFinal = @ReservaDataFinal, 
                                       HoraInicial = @HoraInicial, HoraFinal = @HoraFinal, DataRetirada = @DataRetirada, DataDevolucao = @DataDevolucao, 
                                       StatusReserva = @StatusReserva, Observacoes = @Observacoes, Turno = @Turno 
                                   WHERE Id = @Id";

                        cmd.Parameters.AddWithValue("@IdSala", reserva.IdSala);
                        cmd.Parameters.AddWithValue("@IdResponsavel", (object)reserva.IdResponsavel ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IdDisciplina", reserva.IdDisciplina);
                        cmd.Parameters.AddWithValue("@IdCurso", reserva.IdCurso);
                        cmd.Parameters.AddWithValue("@IdSolicitante", reserva.IdSolicitante);
                        cmd.Parameters.AddWithValue("@ReservaDataInicial", reserva.ReservaDataInicial);
                        cmd.Parameters.AddWithValue("@ReservaDataFinal", reserva.ReservaDataFinal);
                        cmd.Parameters.AddWithValue("@HoraInicial", reserva.HoraInicial);
                        cmd.Parameters.AddWithValue("@HoraFinal", reserva.HoraFinal);
                        cmd.Parameters.AddWithValue("@DataRetirada", (object)reserva.DataRetirada ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DataDevolucao", (object)reserva.DataDevolucao ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@StatusReserva", reserva.StatusReserva);
                        cmd.Parameters.AddWithValue("@Observacoes", reserva.Observacoes);
                        cmd.Parameters.AddWithValue("@Turno", reserva.Turno);
                        cmd.Parameters.AddWithValue("@Id", reserva.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar alterar uma reserva no banco de dados.", ex);
                }
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

        public bool ExisteReservasDuplicadas(int iDSala, DateTime data, TimeSpan horaInicial, TimeSpan horaFinal)
        {
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT COUNT(*) FROM Reserva WHERE IdSala = @IdSala AND ReservaDataInicial <= @Data AND ReservaDataFinal >= @Data AND ((HoraInicial <= @HoraInicial AND HoraFinal >= @HoraFinal) OR (HoraInicial >= @HoraInicial AND HoraFinal <= @HoraFinal) OR (HoraInicial <= @HoraInicial AND HoraFinal >= @HoraInicial) OR (HoraInicial <= @HoraFinal AND HoraFinal >= @HoraFinal)) AND (StatusReserva = 'Aprovada' OR StatusReserva = 'Remarcada')";
                        cmd.Parameters.AddWithValue("@IdSala", iDSala);
                        cmd.Parameters.AddWithValue("@Data", data);
                        cmd.Parameters.AddWithValue("@HoraInicial", horaInicial);
                        cmd.Parameters.AddWithValue("@HoraFinal", horaFinal);

                        int count = (int)cmd.ExecuteScalar();

                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar verificar reservas duplicadas no banco de dados.", ex);
                }
            }
        }
    }
}

