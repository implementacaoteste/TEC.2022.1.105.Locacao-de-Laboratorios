using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class ReservaBLL
    {
        private ReservaDAL reservaDAL;

        public ReservaBLL()
        {
            reservaDAL = new ReservaDAL();
        }

        public void Inserir(Reserva reserva)
        {
            try
            {
                reservaDAL.Inserir(reserva);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir a reserva.", ex);
            }
        }

        public List<Reserva> BuscarTodos()
        {
            try
            {
                return reservaDAL.BuscarTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as reservas.", ex);
            }
        }

        public Reserva BuscarPorId(int id)
        {
            try
            {
                return reservaDAL.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar a reserva por ID.", ex);
            }
        }

        public void Alterar(Reserva reserva)
        {
            try
            {
                reservaDAL.Alterar(reserva);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar a reserva.", ex);
            }
        }

        public void Excluir(int id)
        {
            try
            {
                reservaDAL.Excluir(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a reserva.", ex);
            }
        }
    }
}

