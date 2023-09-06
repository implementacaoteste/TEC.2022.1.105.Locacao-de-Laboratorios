﻿using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            GrupoUsuarioDAL dal = new GrupoUsuarioDAL();
            dal.Inserir(_grupoUsuario);
        }

        public List<GrupoUsuario> BuscarTodos()
        {
            GrupoUsuarioDAL dal = new GrupoUsuarioDAL();
            return dal.BuscarTodos();
        }

        public List<GrupoUsuario> BuscarGrupoPorNome(string _nomeGrupo)
        {
            GrupoUsuarioDAL dal = new GrupoUsuarioDAL();
            return dal.BuscarGrupoPorNome(_nomeGrupo);
        }

        public GrupoUsuario BuscarGrupoPorId(int _id)
        {
            GrupoUsuarioDAL dal = new GrupoUsuarioDAL();
            return dal.BuscarGrupoPorId(_id);
        }

        public List<GrupoUsuario> BuscarGrupoPorIdUsuario(int _idUsuario)
        {
            GrupoUsuarioDAL dal = new GrupoUsuarioDAL();
            return dal.BuscarGrupoPorIdUsuario(_idUsuario);
        }

        public List<GrupoUsuario> BuscarGrupoPor_IdPermissao(int _idPermissao)
        {
            GrupoUsuarioDAL dal = new GrupoUsuarioDAL();
            return dal.BuscarGrupoPor_IdPermissao(_idPermissao);
        }

        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            GrupoUsuarioDAL dal = new GrupoUsuarioDAL();
            dal.Alterar(_grupoUsuario);
        }

        public void Excluir(int _idGrupoUsuario)
        {
            GrupoUsuarioDAL dal = new GrupoUsuarioDAL();
            dal.Excluir(_idGrupoUsuario);
        }

        public bool PermissaoVinculada(int _idGrupo, int _idPermissao)
        {
            GrupoUsuarioDAL dal = new GrupoUsuarioDAL();
            return dal.PermissaoVinculada(_idGrupo, _idPermissao);
        }

        public void AdicionarPermissao(int _idGrupo, int _idPermissao)
        {
            GrupoUsuarioDAL dal = new GrupoUsuarioDAL();
            dal.AdicionarPermissao(_idGrupo, _idPermissao);
        }

        public void RemoverPermissao(int _idGrupo, int _idPermissao)
        {
            GrupoUsuarioDAL dal = new GrupoUsuarioDAL();
            dal.RemoverPermissao(_idGrupo, _idPermissao);
        }
    }
}
