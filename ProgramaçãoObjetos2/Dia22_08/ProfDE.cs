using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia22_08
{
    internal class ProfDE : Professor
    {
        public ProfDE(string Nome, int Matricula, int CargaHorária, double Beneficio)
        {
            this.Nome = Nome;
            this.Matricula = Matricula;
            this.CargaHorária = CargaHorária;
            this.Beneficio = Beneficio;
        }
        public override void calcularBenefício()
        {
            double beneficioFinal = CargaHorária * Beneficio + 10000;
            Console.WriteLine("Meu benefício é de" + beneficioFinal);
        }
    }
}
