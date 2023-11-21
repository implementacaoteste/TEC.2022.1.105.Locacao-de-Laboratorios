using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class AtividadeBLL
    {
        public void Inserir(Atividade atividade)
        {
            new DisciplinaDAL().Inserir(atividade);
        }

        public List<Atividade> BuscarTodos()
        {
            return new DisciplinaDAL().BuscarTodos();
        }

        public Atividade BuscarPorId(int id)
        {
            return new DisciplinaDAL().BuscarPorId(id);
        }
        public void Alterar(Atividade atividade)
        {
            new DisciplinaDAL().Alterar(atividade);
        }

        public void Excluir(int id)
        {
            new DisciplinaDAL().Excluir(id);
        }
        public List<Atividade> BuscarPorNome(string _nome)
        {
            return new DisciplinaDAL().BuscarPorNome(_nome);
        }

    }
}