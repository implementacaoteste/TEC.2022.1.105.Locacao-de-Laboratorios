using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario grupoUsuario)
        {
            new GrupoUsuarioDAL().Inserir(grupoUsuario);
        }

        public List<GrupoUsuario> BuscarTodos()
        {
            return new GrupoUsuarioDAL().BuscarTodos();
        }

        public GrupoUsuario BuscarPorId(int id)
        {
            return new GrupoUsuarioDAL().BuscarPorId(id);
        }

        public void Alterar(GrupoUsuario grupoUsuario)
        {
            new GrupoUsuarioDAL().Alterar(grupoUsuario);
        }

        public void Excluir(int id)
        {
            new GrupoUsuarioDAL().Excluir(id);
        }
    }
}
