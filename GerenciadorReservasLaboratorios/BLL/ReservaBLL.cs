using DAL;
using Models;
using System.Collections.Generic;

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
