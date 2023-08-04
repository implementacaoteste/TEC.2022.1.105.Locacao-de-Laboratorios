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

        public GrupoUsuarioBLL()
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
                throw new Exception("Ocorreu um erro ao tentar inserir Curso.", ex);
            }
        }
    }
}
