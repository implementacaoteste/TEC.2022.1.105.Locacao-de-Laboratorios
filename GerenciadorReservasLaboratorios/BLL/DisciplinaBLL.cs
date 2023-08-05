using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class DisciplinaBLL
    {
        private DisciplinaDAL disciplinaDAL;

        public DisciplinaBLL()
        {
            disciplinaDAL = new DisciplinaDAL();
        }

        public void Inserir(Disciplina _disciplina)
        {
            try
            {
                disciplinaDAL.Inserir(_disciplina);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir a disciplina.", ex);
            }
        }

        public List<Disciplina> BuscarTodos()
        {
            try
            {
                return disciplinaDAL.BuscarTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as disciplinas.", ex);
            }
        }

        public Disciplina BuscarPorId(int _id)
        {
            try
            {
                return disciplinaDAL.BuscarPorId(_id);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar a disciplina por ID.", ex);
            }
        }

        public List<Disciplina> BuscarPorNome(string _nome)
        {
            try
            {
                return new DisciplinaDAL().BuscarPorNome(_nome);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar a disciplina por nome.", ex);
            }
        }

        public void Alterar(Disciplina _disciplina)
        {
            try
            {
                disciplinaDAL.Alterar(_disciplina);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar a disciplina.", ex);
            }
        }

        public void Excluir(int _id)
        {
            try
            {
                disciplinaDAL.Excluir(_id);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a disciplina.", ex);
            }
        }
    }
}