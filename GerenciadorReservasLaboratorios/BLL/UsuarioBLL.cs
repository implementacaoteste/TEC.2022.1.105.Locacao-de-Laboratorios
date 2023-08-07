using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL usuarioDAL;

        public UsuarioBLL()
        {
            usuarioDAL = new UsuarioDAL();
        }

        public void Inserir(Usuario usuario)
        {
            usuarioDAL.Inserir(usuario);
        }

        public Usuario BuscarPorId(int id)
        {
            return usuarioDAL.BuscarPorId(id);
        }

        public Usuario BuscarPorNomeUsuario(string nomeUsuario)
        {
            return usuarioDAL.BuscarPorNomeUsuario(nomeUsuario);
        }

        public List<Usuario> BuscarTodos()
        {
            return usuarioDAL.BuscarTodos();
        }

        public void Alterar(Usuario usuario)
        {
            usuarioDAL.Alterar(usuario);
        }

        public void Excluir(int id)
        {
            usuarioDAL.Excluir(id);
        }
    }
}
