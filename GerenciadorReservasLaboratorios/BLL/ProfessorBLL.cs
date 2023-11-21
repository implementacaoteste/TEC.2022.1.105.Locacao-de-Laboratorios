﻿using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Models;

namespace BLL
{
    public class ProfessorBLL
    {
        private UsuarioDAL usuarioDAL;

        public ProfessorBLL()
        {
            usuarioDAL = new UsuarioDAL();
        }
        public void Inserir(Professor _usuario, string _confirmacaoDeSenha)
        {
            ValidarPermissao(2);
            ValidarDados(_usuario, _confirmacaoDeSenha);
            usuarioDAL.Inserir(_usuario);
        }
        public Professor BuscarPorId(int _id)
        {
            ValidarPermissao(1);
            return usuarioDAL.BuscarPorId(_id);
        }
        public Professor BuscarPorNomeUsuario(string _nomeUsuario)
        {
            ValidarPermissao(1);
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);
        }
        public List<Professor> BuscarTodos()
        {
            ValidarPermissao(1);
            return usuarioDAL.BuscarTodos();
        }
        public int ContarUsuarios()
        {
            List<Professor> usuarios = new UsuarioDAL().BuscarTodos();
            return usuarios.Count();
        }

        public void Alterar(Professor _usuario, string _confirmacaoDeSenha)
        {
            ValidarPermissao(3);
            usuarioDAL.Alterar(_usuario);
        }
        public void Excluir(int _id)
        {
            ValidarPermissao(4);
            usuarioDAL.Excluir(_id);
        }
        private void ValidarDados(Professor _usuario, string _confirmacaoDeSenha)
        {
            if (_usuario.Senha != _confirmacaoDeSenha)
                throw new Exception("A senha e a confirmação da senha devem ser iguais.");

            if (_usuario.Senha.Length <= 5)
                throw new Exception("A senha deve ter mais de 5 caracteres.") { Data = { { "Id", 123 } } };

            if (string.IsNullOrWhiteSpace(_usuario.Nome))
                throw new Exception("O campo Nome é obrigatório.");
 
            if (!_usuario.Nome.Contains(" "))
                throw new Exception("O campo Nome deve conter pelo menos um nome e um sobrenome.");

            if (_usuario.NomeUsuario.Length < 4)
                throw new Exception("O campo Nome de Usuário deve ter pelo menos 4 caracteres.");

            if (_usuario.Matricula.Length < 6)
                throw new Exception("O campo Matrícula deve ter pelo menos 6 caracteres.");

            if (!IsValidEmail(_usuario.Email))
                throw new Exception("O campo E-mail não está em um formato válido.");

        }
        public static bool IsValidEmail(string _email)
        {
            try
            {
                var enderecoEmail = new System.Net.Mail.MailAddress(_email);
                return enderecoEmail.Address == _email;
            }
            catch (Exception)
            {

                return false;
            }
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
        public void Autenticar(string _nomeUsuario, string _senha)
        {
            Professor atividade = new UsuarioDAL().BuscarPorNomeUsuario(_nomeUsuario);
            
            if (atividade.Ativo && !String.IsNullOrEmpty(atividade.Senha) && _senha == atividade.Senha)
                Constantes.IdUsuarioLogado = atividade.Id;
            else
                throw new Exception("Professor ou senha inválido.");
        }
        public Professor ObterUsuarioLogado()
        {
            if (Constantes.IdUsuarioLogado == 0)
            {
                // Nenhum usuário está logado, retorna null ou um valor padrão
                return null;
            }
            // Se um usuário está logado, busque as informações do usuário no DAL
            return usuarioDAL.BuscarPorId(Constantes.IdUsuarioLogado);
        }
    }
}