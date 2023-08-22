using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class DisciplinaBLL
    {
        public void Inserir(Disciplina disciplina)
        {
            new DisciplinaDAL().Inserir(disciplina);
        }

        public List<Disciplina> BuscarTodos()
        {
            return new DisciplinaDAL().BuscarTodos();
        }

        public Disciplina BuscarPorId(int id)
        {
            return new DisciplinaDAL().BuscarPorId(id);
        }

        public void Alterar(Disciplina disciplina)
        {
            new DisciplinaDAL().Alterar(disciplina);
        }

        public void Excluir(int id)
        {
            new DisciplinaDAL().Excluir(id);
        }
        public List<Disciplina> BuscarPorNome(string _nome)
        {
            return new DisciplinaDAL().BuscarPorNome(_nome);
        }

    }
}