﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFipe.Models
{
    public class ModeloFabricante
    {
        public List<Modelos> Modelos { get; set; }

    }

    public class Modelos
    {
        public string nome { get; set; }
        public string codigo { get; set;}

    }
}
