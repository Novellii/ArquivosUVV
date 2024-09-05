using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia22_08
{
    internal abstract class Professor
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public int CargaHorária { get; set; }
        public double Beneficio { get; set; }

        public abstract void calcularBenefício();



        

    }
}
