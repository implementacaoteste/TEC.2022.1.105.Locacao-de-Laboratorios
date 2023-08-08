﻿using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class CursoBLL
    {
        public void Inserir(Curso curso)
        {
            new CursoDAL().Inserir(curso);
        }

        public List<Curso> BuscarTodos()
        {
            return new CursoDAL().BuscarTodos();
        }

        public Curso BuscarPorId(int id)
        {
            return new CursoDAL().BuscarPorId(id);
        }

        public void Alterar(Curso curso)
        {
            new CursoDAL().Alterar(curso);
        }

        public void Excluir(int id)
        {
            new CursoDAL().Excluir(id);
        }
    }
}