using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia22_08
{
    internal class Airport
    {
        FlyinhTransport Veiculo { get; set; }

        public Boolean aceitarVoo(FlyinhTransport transporte, String origem, String Destino, int Passageiros)
        {
            if (Veiculo != null) {
                Console.WriteLine("Aeroporto Cheio");
                return false;
            }
            Veiculo = transporte;
            Veiculo.Voar(origem, Destino, Passageiros);
            return true;
        }

        public void Limpar()
        {
            Console.WriteLine("Aeroporto Limpo!");
            Veiculo = null;
        }

    }
}
