using System;
using GetDrive.Enuns;
using System.Collections.Generic;
namespace GetDrive
{
    internal class Program
    {
        //Enumerar Tipos de Veiculos e Formas de Pagamento
        public CategoriaUsuario categoriaUsuario { get; set; }
        public FormadePagamento formadePagamento { get; set; }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu telefone: ");
            string telefone = Console.ReadLine();
            
            //Categoria de Clientes
            int _categorianum;
            Console.WriteLine("Digite 1 para Motorista ou 2 para Cliente");
            string categoria_string = Console.ReadLine();
            _categorianum = Convert.ToInt16(categoria_string);

            switch (_categorianum)
            {
                case 1:
                    //Caso para Motorista
                    Console.WriteLine("Bem Vindo Motorista");
                    Console.WriteLine("Digite os dados a seguir: ");
                    Console.WriteLine("Modelo do Veículo:");
                    string modelo = Console.ReadLine();
                    Console.WriteLine("Placa do Veículo");
                    string placa = Console.ReadLine().ToUpper();
                    
                    Motorista motorista= new Motorista(nome,telefone,modelo,placa);

                    PagamentoMotorista pagamentoMotorista = new PagamentoMotorista();

                    pagamentoMotorista.CalcularTotal();

                    Console.WriteLine("O valor a receber pela corrida é de ");
                    Console.WriteLine(pagamentoMotorista);
                    
                    ContaMotorista contaMotorista = new ContaMotorista();
                    contaMotorista.CadastrarConta();
                    contaMotorista.ReceberPagamento();
                    

                    break;

                case 2:
                    //Caso para Cliente
                    Console.WriteLine("Adicione endereço de Partida");
                    string _endPartida = Console.ReadLine();
                    Console.WriteLine("Adicione endereço de Destino");
                    string _endDestino = Console.ReadLine();
                    Console.WriteLine("Digite a quantidade de Km Percorrido");
                    double _kmPercorrido = Convert.ToDouble(Console.ReadLine());

                    //Formas de Pagamento
                    Console.WriteLine("Digite:");
                    Console.WriteLine("1- Cartão");
                    Console.WriteLine("2- PIX");
                    Console.WriteLine("3- Dinheiro");
                    int formadepag_num;
                    string formadepag_string = Console.ReadLine();
                    formadepag_num = Convert.ToInt16(formadepag_string);

                    Cliente cliente = new Cliente(nome, telefone, _endPartida,
                        _endDestino);

                    cliente.SolicitarVeiculo();
                    cliente.AceitarCorrida();
                    cliente.ObterDadosCorrida();
                    
                    //Pagamentos

                    Pagamentos pagamentos = new Pagamentos();
                    
                    Console.WriteLine(pagamentos.ValorTotal());
                    Console.WriteLine(pagamentos.AdicionarCupom());


                    //Para formas de pagamento

                    switch (formadepag_num)
                    {
                        case 1: 
                            //cartão
                            Cartao cartao = new Cartao();
                            cartao.DigitarDados();
                            cartao.AutorizarPagamento();

                            break;
                            case 2:
                            Pix pix = new Pix();
                            pix.InformarPix();
                            pix.AnexarComprovante();
                            break;


                        case 3:
                            Dinheiro dinheiro = new Dinheiro();
                            dinheiro.EntregarDinheiro();

                                break;
                            
                    }
                     break;



            }


        }







    }
}



