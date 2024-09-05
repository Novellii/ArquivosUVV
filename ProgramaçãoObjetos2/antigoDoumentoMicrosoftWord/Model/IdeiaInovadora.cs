using antigoDoumentoMicrosoftWord.Persistencs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antigoDoumentoMicrosoftWord.Model
{
    internal class IdeiaInovadora
    {
        public string Area { get; set; }
        public string Ideia { get; set; }
        public float Custo { get; set; }

        public IdeiaInovadora(string area, string ideia, float custo)
        {
            Area = area;
            Ideia = ideia;
            Custo = custo;
        }

        public Boolean CadastrarIdeiaInovacao(IdeiaInovadora i) 
        {
            BD.SalvarBD(i);
            return true; 
        }
    }
}
