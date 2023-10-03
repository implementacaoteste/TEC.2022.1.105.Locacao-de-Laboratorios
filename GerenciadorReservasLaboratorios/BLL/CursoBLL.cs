using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class CursoBLL
    {
        public int Inserir(Curso _curso)
        {
            return new CursoDAL().Inserir(_curso);
        }

        public List<Curso> BuscarTodos()
        {
            return new CursoDAL().BuscarTodos();
        }
        public Curso BuscarPorId(int _id)
        {
            return new CursoDAL().BuscarPorId(_id);
        }
        public List<Curso> BuscarPorNome(string _nome)
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
