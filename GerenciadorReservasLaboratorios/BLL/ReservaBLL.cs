using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace BLL
{
    public class ReservaBLL
    {
        public void Inserir(Reserva reserva)
        {
            new ReservaDAL().Inserir(reserva);
        }

        public List<Reserva> BuscarTodos()
        {
            return new ReservaDAL().BuscarTodos();
        }

        public Reserva BuscarPorId(int id)
        {
            return new ReservaDAL().BuscarPorId(id);
        }
        public List<Reserva> BuscarPorSala(int idSala)
        {
            return new ReservaDAL().BuscarPorSala(idSala);
        }

        public List<Reserva> BuscarPorResponsavel(int idUsuario)
        {
            return new ReservaDAL().BuscarPorResponsavel(idUsuario);
        }

        public List<Reserva> BuscarPorDisciplina(int idDisciplina)
        {
            return new ReservaDAL().BuscarPorDisciplina(idDisciplina);
        }

        public List<Reserva> BuscarPorCurso(int idCurso)
        {
            return new ReservaDAL().BuscarPorCurso(idCurso);
        }

        public List<Reserva> BuscarPorSolicitante(int idSolicitante)
        {
            return new ReservaDAL().BuscarPorSolicitante(idSolicitante);
        }

        public List<Reserva> BuscarPorData(DateTime data)
        {
            return new ReservaDAL().BuscarPorData(data);
        }

        public List<Reserva> BuscarPorStatus(string status)
        {
            return new ReservaDAL().BuscarPorStatus(status);
        }

        public List<Reserva> BuscarPorTurno(string turno)
        {
            return new ReservaDAL().BuscarPorTurno(turno);
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

        public void Alterar(Reserva reserva)
        {
            new ReservaDAL().Alterar(reserva);
        }

        public void Excluir(int id)
        {
            new ReservaDAL().Excluir(id);
        }
    }
}
