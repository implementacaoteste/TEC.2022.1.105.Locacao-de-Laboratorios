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
        public List<Aluno> BuscarTodosAlunos()
        {
            return new AlunoDAL().BuscarTodosAlunos();
        }
        public Aluno BuscarPorId(int id)
        {
            return new AlunoDAL().BuscarPorId(id);
        }
        public List<Aluno> BuscarPorNome(string _nome)
        {
            return new AlunoDAL().BuscarPorNome( _nome);
        }
        public Aluno BuscarPorMatricula(string _matricula )
        {
            return new AlunoDAL().BuscarPorMatricula(_matricula);
        }
        public string ObterNomePorId(int id)
        {
            return new AlunoDAL().ObterNomePorId(id);
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

