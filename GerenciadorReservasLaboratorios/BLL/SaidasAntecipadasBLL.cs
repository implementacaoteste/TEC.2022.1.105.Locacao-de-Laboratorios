using DAL;
using Models;
using System.Collections.Generic;

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

        public SaidasAntecipadas BuscarPorId(int id)
        {
            return new SaidasAntecipadasDAL().BuscarPorId(id);
        }

        public void Alterar(SaidasAntecipadas saidasAntecipadas)
        {
            new SaidasAntecipadasDAL().Alterar(saidasAntecipadas);
        }

        public void Excluir(int id)
        {
            new SaidasAntecipadasDAL().Excluir(id);
        }
    }
}