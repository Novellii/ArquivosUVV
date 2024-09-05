using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia22_08
{
    internal class Helicopter : FlyinhTransport
    {
        public void Voar(String Origem, String Destino, int Passageiros)
        {
            Console.WriteLine("Olá Camaradas! Em direção a " + Destino + "\nCom a contagem de " + Passageiros + " Passageiros");
        }
    }
}
