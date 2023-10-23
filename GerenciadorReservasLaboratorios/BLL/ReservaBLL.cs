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
        public List<Reserva> BuscarPorSala(string nomeSala)
        {
            return new ReservaDAL().BuscarPorSala(nomeSala);
        }

        public List<Reserva> BuscarPorResponsavel(string nomeResponsavel)
        {
            return new ReservaDAL().BuscarPorResponsavel(nomeResponsavel);
        }

        public List<Reserva> BuscarPorDisciplina(string nomeDisciplina)
        {
            return new ReservaDAL().BuscarPorDisciplina(nomeDisciplina);
        }

        public List<Reserva> BuscarPorCurso(string nomeCurso)
        {
            return new ReservaDAL().BuscarPorCurso(nomeCurso);
        }

        public List<Reserva> BuscarPorSolicitante(string nomeSolicitante)
        {
            return new ReservaDAL().BuscarPorSolicitante(nomeSolicitante);
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
        public void VerConflitosDeReserva(int iDSala, DateTime dataSelecionada, TimeSpan horaInicial, TimeSpan horaFinal)
        {
            // Verifique se já existe uma reserva conflitante usando o método ExisteReservasDuplicadas
            bool reservaConflitante = new ReservaDAL().ExisteReservasDuplicadas(iDSala, dataSelecionada, horaInicial, horaFinal);
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
