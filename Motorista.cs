using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDrive
{
    internal class Motorista: Usuario
    {
        public string ModeloVeiculo { get; set; }
        public string PlacadoVeiculo { set; get; }


        public Motorista(string nome, string telefone, string modeloVeiculo, string placaVeiculo):
            base(nome,telefone)
        {
            ModeloVeiculo = modeloVeiculo;
            PlacadoVeiculo = placaVeiculo;
            
        }
        
         public  void SolicitarCorrida()
        {
            Console.WriteLine("Buscando passageiro"); ;
         }

        public void ObterDados()
        {
            Console.WriteLine("Busque Robinson na Lapa,123 e leve ao Centro,534.");
            
        }
        
            
    }
}
