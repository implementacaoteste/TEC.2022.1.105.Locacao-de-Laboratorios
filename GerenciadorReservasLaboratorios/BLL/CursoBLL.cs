using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CursoBLL
    {
        private CursoDAL cursoDAL;

        public CursoBLL()
        {
            cursoDAL = new CursoDAL();
        }

        public void Inserir(Curso curso)
        {
            try
            {
                cursoDAL.Inserir(curso);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o curso.", ex);
            }
        }

        public List<Curso> BuscarTodos()
        {
            try
            {
                return cursoDAL.BuscarTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os cursos.", ex);
            }
        }

        public Curso BuscarPorId(int id)
        {
            try
            {
                return cursoDAL.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o curso por ID.", ex);
            }
        }
        public void Alterar(Curso curso)
        {
            try
            {
                cursoDAL.Alterar(curso);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar a reserva.", ex);
            }
        }
    }
}
