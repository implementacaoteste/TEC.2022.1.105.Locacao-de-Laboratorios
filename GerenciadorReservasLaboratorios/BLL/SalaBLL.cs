using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class SalaBLL
    {
        public void Inserir(Sala sala)
        {
            new SalaDAL().Inserir(sala);
        }

        public List<Sala> BuscarTodos()
        {
            return new SalaDAL().BuscarTodos();
        }

        public Sala BuscarPorId(int id)
        {
            return new SalaDAL().BuscarPorId(id);
        }
        public List<Sala> BuscarPorNome(string _nome)
        {
            return new SalaDAL().BuscarPorNome(_nome);
        }
        public void Alterar(Sala sala)
        {
            new SalaDAL().Alterar(sala);
        }

        public void Excluir(int id)
        {
            new SalaDAL().Excluir(id);
        }
    }
}
