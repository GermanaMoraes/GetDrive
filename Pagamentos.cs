using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetDrive.Enuns;

namespace GetDrive
{
    public class Pagamentos
    {
        public double ValordaCorrida { get; set; }
        public double KmPercorrido { get; set; }

        public FormadePagamento formadePagamento { get; set; }

        public Pagamentos()
        {
            
        }

        public string ValorTotal()
        {
            ValordaCorrida = (KmPercorrido * 0.67) + 6;
            return $"O Preço total da viagem é de R$ {ValordaCorrida.ToString("N2")}";
         }

        public  string AdicionarCupom()
        {
            Console.WriteLine("Adicione seu cupom de desconto.");
            string _cupom = Console.ReadLine();
            ValordaCorrida = ValordaCorrida * 0.85;
            return $"O preço total com desconto é de R$ {ValordaCorrida.ToString("N2")}";        
        }
    }
}
