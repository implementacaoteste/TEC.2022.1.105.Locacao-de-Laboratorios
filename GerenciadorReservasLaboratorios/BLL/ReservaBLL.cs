using DAL;
using Models;
using System;
using System.Collections.Generic;
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
        public bool ExisteReservasDuplicadas(int iDSala, DateTime data, TimeSpan hora)
        {
            // Obtém todas as reservas do banco de dados
            var reservas = new ReservaDAL().BuscarTodos();

            // Cria uma lista de reservas em duplicidade
            var reservasDuplicadas = new List<Reserva>();

            // Itera sobre as reservas
            foreach (var reserva in reservas)
            {
                // Verifica se a reserva é em duplicidade
                if (reserva.IdSala == iDSala &&
                    reserva.ReservaData == data &&
                    reserva.ReservaHora == hora)
                {
                    // Adiciona a reserva à lista de reservas em duplicidade
                    reservasDuplicadas.Add(reserva);
                }
            }

            // Verifica se existe alguma reserva em duplicidade
            if (reservasDuplicadas.Any())
            {
                // Retorna true
                return true;
            }

            // Retorna false
            return false;
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
