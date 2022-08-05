using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetDrive.Enuns;

namespace GetDrive
{
     class Cliente:Usuario
    {
        public string EndPartida { get; set; }
        public string EndDestino { get; set; }
        
                      
               
        public Cliente(string nome, string telefone,
             string endPartida, string endDestino) : base(nome, telefone)
        {
            EndDestino = endDestino;
            EndPartida = endPartida;
            
            
        }

         public  void SolicitarVeiculo()
        {
            Console.WriteLine("Veiculo Solicitado."); 
        }
        
        

        public void AceitarCorrida()
        {
            Console.WriteLine("Corrida Aceita");
        }

        public void ObterDadosCorrida()
        {
            Console.WriteLine("O Motorista Paulo está a caminho na Ferrari com a Placa BLZ98I4");
        }

    }
}
