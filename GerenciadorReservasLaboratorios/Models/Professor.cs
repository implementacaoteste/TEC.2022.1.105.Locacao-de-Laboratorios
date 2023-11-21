﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Matricula { get; set; }
        public bool Ativo { get; set; }
        public List<GrupoUsuario> GrupoUsuarios { get; set; }

    }
}
