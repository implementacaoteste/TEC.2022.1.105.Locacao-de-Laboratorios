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
        public List<SaidasAntecipadas> BuscarPorNomeAluno(string nomeAluno)
        {
            return new SaidasAntecipadasDAL().BuscarPorNomeAluno(nomeAluno);
        }
        public List<SaidasAntecipadas> BuscarPorNomeProfessor(string nomeProfessor)
        {
            return new SaidasAntecipadasDAL().BuscarPorNomeProfessor(nomeProfessor);
        }
        public List<SaidasAntecipadas> BuscarPorNomeCoordenacao(string nomeCoordenacao)
        {
            return new SaidasAntecipadasDAL().BuscarPorNomeCoordenacao(nomeCoordenacao);
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