using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetDrive.Enuns;


namespace GetDrive
{
    abstract  class Usuario
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public CategoriaUsuario categoria { get; set; }

        public Usuario(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
            
                      
        }
 
                

       
    
    }

}


