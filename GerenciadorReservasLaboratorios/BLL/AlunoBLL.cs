using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class AlunoBLL
    {
        private AlunoDAL alunoDAL;

        public AlunoBLL()
        {
            alunoDAL = new AlunoDAL();
        }

        public void Inserir(Aluno aluno)
        {
            try
            {
                alunoDAL.Inserir(aluno);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o aluno.", ex);
            }
        }

        public List<Aluno> BuscarTodos()
        {
            try
            {
                return alunoDAL.BuscarTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os alunos.", ex);
            }
        }

        public Aluno BuscarPorId(int id)
        {
            try
            {
                return alunoDAL.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o aluno por ID.", ex);
            }
        }

        public List<Aluno> BuscarPorNome(string nome)
        {
            try
            {
                return alunoDAL.BuscarPorNome(nome);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o aluno por nome.", ex);
            }
        }

        public void Alterar(Aluno aluno)
        {
            try
            {
                alunoDAL.Alterar(aluno);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar o aluno.", ex);
            }
        }

        public void Excluir(int id)
        {
            try
            {
                alunoDAL.Excluir(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir o aluno.", ex);
            }
        }
    }
}

