﻿using Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico : Persona
    {
        public string Especialidad { get; set; }

        public int Matricula { get; set; }
    }
}
