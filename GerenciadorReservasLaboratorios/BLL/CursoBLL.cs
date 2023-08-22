using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class CursoBLL
    {
        public void Inserir(Curso _curso)
        {
            new CursoDAL().Inserir(_curso);
        }

        public List<Curso> BuscarTodos()
        {
            return new CursoDAL().BuscarTodos();
        }
        public Curso BuscarPorId(int _id)
        {
            return new CursoDAL().BuscarPorId(_id);
        }
        public Curso BuscarPorNome(string _nome)
        {
            return new CursoDAL().BuscarPorNome(_nome);
        }
        public void Alterar(Curso _curso)
        {
            new CursoDAL().Alterar(_curso);
        }

        public void Excluir(int _id)
        {
            new CursoDAL().Excluir(_id);
        }
    }
}
