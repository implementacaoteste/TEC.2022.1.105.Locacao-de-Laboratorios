using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class AlunoBLL
    {
        public void Inserir(Aluno aluno)
        {
            new AlunoDAL().Inserir(aluno);
        }

        public List<Aluno> BuscarTodos()
        {
            return new AlunoDAL().BuscarTodos();
        }

        public Aluno BuscarPorId(int id)
        {
            return new AlunoDAL().BuscarPorId(id);
        }

        public void Alterar(Aluno aluno)
        {
            new AlunoDAL().Alterar(aluno);
        }

        public void Excluir(int id)
        {
            new AlunoDAL().Excluir(id);
        }
    }
}

