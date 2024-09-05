using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia22_08
{
    internal class ProfHorista : Professor
    {
        public double valorHora { get; set; }
        public ProfHorista(string Nome, int Matricula, int CargaHorária, double Beneficio, double valorHora)
        {
            this.Nome = Nome;
            this.Matricula = Matricula;
            this.CargaHorária = CargaHorária;
            this.Beneficio = Beneficio;
            this.valorHora = valorHora;
        }

        public override void calcularBenefício()
        {
            double beneficioFinal = Beneficio * valorHora;
            Console.WriteLine("Meu benefício é de" + beneficioFinal);
        }
    }
}
