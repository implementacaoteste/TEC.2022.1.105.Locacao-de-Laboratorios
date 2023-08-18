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
        public List<SaidasAntecipadas> BuscarPorIdAluno(int idAluno)
        {
            return new SaidasAntecipadasDAL().BuscarPorIdAluno(idAluno);
        }
        public List<SaidasAntecipadas> BuscarPorIdProfessor(int idProfessor)
        {
            return new SaidasAntecipadasDAL().BuscarPorIdProfessor(idProfessor);
        }
        public List<SaidasAntecipadas> BuscarPorIdCoordenacao(int idCoordenacao)
        {
            return new SaidasAntecipadasDAL().BuscarPorIdCoordenacao(idCoordenacao);
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