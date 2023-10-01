using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class PredioBLL
    {
        public void Inserir(Predio predio)
        {
            new PredioDAL().Inserir(predio);
        }
        public List<Predio> BuscarTodos()
        {
            return new PredioDAL().BuscarTodos();
        }
        public Predio BuscarPorId(int id)
        {
            return new PredioDAL().BuscarPorId(id);
        }
        public List<Predio> BuscarPorNome(string nome)
        {
            return new PredioDAL().BuscarPorNome(nome);
        }
        public void Alterar(Predio predio)
        {
            new PredioDAL().Alterar(predio);
        }
        public void Excluir(int id)
        {
            new PredioDAL().Excluir(id);
        }
    }
}
