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
        private void ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (_usuario.Senha != _confirmacaoDeSenha)
                throw new Exception("A senha e a confirmação da senha devem ser iguais.");

            if (_usuario.Senha.Length <= 3)
                throw new Exception("A senha deve ter mais de 3 caracteres.") { Data = { { "Id", 123 } } };

            if (_usuario.Nome.Length <= 2)
                throw new Exception("A nome deve ter mais de 2 caracteres.");
        }
        public void ValidarPermissao(int _idPermissao)
        {
            if (!new UsuarioDAL().ValidarPermissao(Constantes.IdUsuarioLogado, _idPermissao))
                throw new Exception("Você não tem permissão de realizar essa operação. Procure o administrador do sistema.");
        }
        public void AdicionarGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            if (!new UsuarioDAL().UsuarioPertenceAoGrupo(_idUsuario, _idGrupoUsuario))
                new UsuarioDAL().AdicionarGrupoUsuario(_idUsuario, _idGrupoUsuario);
        }
        public void RemoverGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            new UsuarioDAL().RemoverGrupoUsuario(_idUsuario, _idGrupoUsuario);
        }
        public void Altenticar(string _nomeUsuario, string _senha)
        {
            Usuario usuario = new UsuarioDAL().BuscarPorNomeUsuario(_nomeUsuario);
            if (_senha == usuario.Senha && usuario.Ativo)
                Constantes.IdUsuarioLogado = usuario.Id;
            else
                throw new Exception("Usuario ou senha inválido.");
        }
    }
}
