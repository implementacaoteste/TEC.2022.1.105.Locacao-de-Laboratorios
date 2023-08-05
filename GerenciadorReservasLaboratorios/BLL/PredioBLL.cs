using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class PredioBLL
    {
        public void Inserir(Predio _predio)
        {
            new PredioDAL().Inserir(_predio);
        }
        public List<Predio> BuscarTodos()
        {
                return new PredioDAL().BuscarTodos();   
        }
        public Predio BuscarPorId(int _id)
        {
            return new PredioDAL().BuscarPorId(_id);
        }
        public void Alterar(Predio _predio)
        {
            new PredioDAL().Alterar(_predio);
        }

        public void Excluir(int _id)
        {
            new PredioDAL().Excluir(_id);
        }
    }
}

