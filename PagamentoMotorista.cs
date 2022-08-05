using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDrive
{
    public class PagamentoMotorista
    {
        public double ValorTotal { get; set; }

        public PagamentoMotorista()
        {
            
        }

        public override string ToString()
        {
            return "R$ " + ValorTotal.ToString("N2");
        }
        public double CalcularTotal()
        {
            ValorTotal = 60;
            return ValorTotal;
        }

        
    }
}
