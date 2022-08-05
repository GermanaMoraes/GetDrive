using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDrive
{
    public class Cartao
    {
        public string Bandeira { get; set; }
        public string Id { get; set; }
        public string Titular { get; set; }
        public int CVV { get; set; }

        public string DigitarDados()
        {

            Console.WriteLine("Digite os seguintes dados");
            Console.WriteLine("Bandeira");
            string bandeira = Console.ReadLine();
            Console.WriteLine("Número do Cartão");
            string id = Console.ReadLine();
            Console.WriteLine("Titular do Cartão");
            string titular = Console.ReadLine();
            Console.WriteLine("CVV ");
            int cvv = Convert.ToInt16(Console.ReadLine());

            return "Dados cadastrados com sucesso.";
        }

        public void AutorizarPagamento()
        {
            Console.WriteLine("Transação aceita.");
        }
    }

    
    }

