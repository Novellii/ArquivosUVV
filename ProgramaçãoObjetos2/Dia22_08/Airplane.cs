using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia22_08
{
    internal class Airplane : FlyinhTransport
    {

        public void Voar(String Origem, String Destino, int Passageiros)
        {
            Console.WriteLine("Senhores passageiros\nEstamos partindo de " + Origem + "\nEm direção a " + Destino + "\nCom a contagem de " + Passageiros + " Passageiros");
        }
    }
}
