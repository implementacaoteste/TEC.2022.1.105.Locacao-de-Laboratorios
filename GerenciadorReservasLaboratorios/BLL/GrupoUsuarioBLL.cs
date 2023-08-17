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
    }
}
