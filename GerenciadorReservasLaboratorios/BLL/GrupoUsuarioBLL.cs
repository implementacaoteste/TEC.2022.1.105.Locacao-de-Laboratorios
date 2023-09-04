using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario grupoUsuario)
        {
            new UsuarioBLL().ValidarPermissao(6);
            new GrupoUsuarioDAL().Inserir(grupoUsuario);
        }
        public List<GrupoUsuario> BuscarTodos()
        {
            return new GrupoUsuarioDAL().BuscarTodos();
        }
        public List<GrupoUsuario> BuscarPorNomeGrupo(string _nomeGrupo)
        {
            return new GrupoUsuarioDAL().BuscarGrupoPorNome(_nomeGrupo);
        }
        public GrupoUsuario BuscarPorId(int id)
        {
            return new GrupoUsuarioDAL().BuscarGrupoPorId(id);
        }
        public void Alterar(GrupoUsuario grupoUsuario)
        {
            new GrupoUsuarioDAL().Alterar(grupoUsuario);
        }
        public List<GrupoUsuario> BuscarGrupoPorIdUsuario(int idUsuario)
        {
            try
            {
                return new GrupoUsuarioDAL().BuscarGrupoPorIdUsuario(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar grupos de usuário por ID.", ex);
            }
        }
        public void Excluir(int id)
        {
            new GrupoUsuarioDAL().Excluir(id);
        }
        public void AdicionarPermissao(int _idGrupo, int _idPermissao)
        {
            if (!new GrupoUsuarioDAL().PermissaoVinculada(_idGrupo, _idPermissao))
                new GrupoUsuarioDAL().AdicionarPermissao(_idGrupo, _idPermissao);
        }
        public void RemoverPermissao(int _idGrupo, int _idPermissao)
        {
            new GrupoUsuarioDAL().RemoverPermissao(_idGrupo, _idPermissao);
        }
        public void RemoverVinculoGrupoPermissao(int _idGrupo, int _idPermissao)
        {
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            grupousuarioDAL.RemoverPermissao(_idGrupo, _idPermissao);
        }
    }
}
