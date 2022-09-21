using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Carro
    {
        public Engine motor { get; set; }
        public int cantidadDeRuedas { get; set; }

    }

    internal class Engine
    {
        public int vujias { get; set; }
    }
}
