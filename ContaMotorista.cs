using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDrive
{
    public class ContaMotorista
    {
        public string Banco { get; set; }
        public string ContaCorrente { get; set; }
        public string CPF { get; set; }

        public void CadastrarConta()
        {
            Console.WriteLine("Digite os seguintes dados:");
            Console.WriteLine("Nome do Banco:");
           string banco = Console.ReadLine();
            Console.WriteLine("Conta Corrente");
            string contaCorrente = Console.ReadLine();
            Console.WriteLine("CPF");
            string cpf = Console.ReadLine();
                        
        }
        public void ReceberPagamento()
        {
            Console.WriteLine("A quantia foi depositada em sua conta");
        }
    }
}
