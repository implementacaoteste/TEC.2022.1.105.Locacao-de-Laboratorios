using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(string _permissao, int _idPermissao)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_permissao, _idPermissao);
        }
        public List<Permissao> BuscarTodasPermissoes()
        {
            return new PermissaoDAL().BuscarTodasPermissoes();
        }
        public List<Permissao> BuscarPorDescricao(string _descricao)
        {
            return new PermissaoDAL().BuscarPermissaoPorDescricao(_descricao);
        }
        public List<Permissao> BuscarTodasPermissoesPorId(int _idPermissao)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            return permissaoDAL.BuscarTodasPermissoesPorId(_idPermissao);
        }
        public void Alterar(Permissao permissao)
        {
            new PermissaoDAL().Alterar(permissao);
        }
        public void Excluir(Permissao _id)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Excluir(_id);
        }
    }
}

