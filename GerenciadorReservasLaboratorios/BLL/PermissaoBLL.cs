using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class PermissaoBLL
    {
        private readonly PermissaoDAL permissaoDAL;

        public PermissaoBLL()
        {
            permissaoDAL = new PermissaoDAL();
        }

        public void Inserir(string permissao, int idPermissao)
        {
            try
            {
                permissaoDAL.Inserir(permissao, idPermissao);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir permissão: " + ex.Message);
            }
        }

        public List<Permissao> BuscarTodasPermissoes()
        {
            try
            {
                return permissaoDAL.BuscarTodasPermissoes();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar todas as permissões: " + ex.Message);
            }
        }

        public List<Permissao> BuscarPermissoesPorIdGrupo(int idGrupo)
        {
            try
            {
                return permissaoDAL.BuscarPermissoesPorIdGrupo(idGrupo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar permissões por ID de grupo: " + ex.Message);
            }
        }

        public List<Permissao> BuscarPermissaoPorDescricao(string nomePermissao)
        {
            try
            {
                return permissaoDAL.BuscarPermissaoPorDescricao(nomePermissao);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar permissões por descrição: " + ex.Message);
            }
        }

        public List<Permissao> BuscarTodasPermissoesPorId(int idPermissao)
        {
            try
            {
                return permissaoDAL.BuscarTodasPermissoesPorId(idPermissao);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar todas as permissões por ID: " + ex.Message);
            }
        }

        public void Alterar(Permissao permissao)
        {
            try
            {
                permissaoDAL.Alterar(permissao);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar permissão: " + ex.Message);
            }
        }

        public void Excluir(Permissao idPermissao)
        {
            try
            {
                permissaoDAL.Excluir(idPermissao);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir permissão: " + ex.Message);
            }
        }
    }
}
