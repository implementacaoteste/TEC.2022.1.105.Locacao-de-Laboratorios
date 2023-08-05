using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class SaidasAntecipadasBLL
    {
        public void Inserir(SaidasAntecipadas saidasAntecipadas)
        {
            new SaidasAntecipadasDAL().Inserir(saidasAntecipadas);
        }

        public List<SaidasAntecipadas> BuscarTodos()
        {
           return new SaidasAntecipadasDAL().BuscarTodos();
        }

        public SaidasAntecipadas BuscarPorId(int _id)
        {
            return new SaidasAntecipadasDAL().BuscarPorId(_id);
        }

        public void Alterar(SaidasAntecipadas _saidasAntecipadas)
        {
            new SaidasAntecipadasDAL().Alterar(_saidasAntecipadas);
        }

        public void Excluir(int _id)
        {
            new SaidasAntecipadasDAL().Excluir(_id);
        }
    }
}


