using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class SalaBLL
    {
        public void Inserir(Sala _sala)
        {
            new SalaDAL().Inserir(_sala);
        }
        public List<Sala> BuscarTodos()
        {
            return new SalaDAL().BuscarTodos();
        }
        public Sala BuscarPorId(int _id)
        {
            return new SalaDAL().BuscarPorId(_id);
        }
        public void Alterar(Sala _sala)
        {
            new SalaDAL().Alterar(_sala);
        }
        public void Excluir(int _id)
        {
            new SalaDAL().Excluir(_id);
        }
    }
}
