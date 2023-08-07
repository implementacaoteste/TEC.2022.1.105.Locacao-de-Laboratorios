using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(Permissao permissao)
        {
            new PermissaoDAL().Inserir(permissao);
        }

        public List<Permissao> BuscarTodos()
        {
            return new PermissaoDAL().BuscarTodos();
        }
        public Permissao BuscarPorId(int id)
        {
            return new PermissaoDAL().BuscarPorId(id);
        }

        public void Alterar(Permissao permissao)
        {
            new PermissaoDAL().Alterar(permissao);
        }

        public void Excluir(int id)
        {
            new PermissaoDAL().Excluir(id);
        }
    }
}

