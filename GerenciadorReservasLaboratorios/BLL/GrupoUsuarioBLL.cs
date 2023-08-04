using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        private GrupoUsuarioDAL grupoUsuarioDAL;

        public GrupoUsuarioBLL()
        {
            grupoUsuarioDAL = new GrupoUsuarioDAL();
        }
        public void Inserir(GrupoUsuario grupoUsuario)
        {
            try
            {
                grupoUsuarioDAL.Inserir(grupoUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o grupo de usuário.", ex);
            }
        }
        public List<GrupoUsuario> BuscarTodos()
        {
            try
            {
                return grupoUsuarioDAL.BuscarTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os grupos de usuário.", ex);
            }
        }

        public List<GrupoUsuario> BuscarPorId(int id)
        {
            try
            {
                return grupoUsuarioDAL.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o grupo de usuário por ID.", ex);
            }
        }

    }
}
