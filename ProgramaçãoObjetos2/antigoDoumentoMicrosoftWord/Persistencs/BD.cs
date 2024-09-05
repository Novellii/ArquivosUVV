using antigoDoumentoMicrosoftWord.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antigoDoumentoMicrosoftWord.Persistencs
{
    internal class BD
    {
        public static List<IdeiaInovadora> mybd = new();

        public static void SalvarBD(IdeiaInovadora i) { 
            mybd.Add(i); 
        }

        public static List<IdeiaInovadora> RetomarBD() {
            return mybd;    
        }
    }
}
