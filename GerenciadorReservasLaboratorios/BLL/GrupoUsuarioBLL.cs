﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        private GrupoUsuarioDAL grupoUsuarioDAL;

        public GrupoUsuarioBLL()
        {
            grupoUsuarioDAL = new GrupoUsuarioDAL();
        }

    }
}
