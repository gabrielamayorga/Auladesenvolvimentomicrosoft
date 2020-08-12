using System;

namespace VendasConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            int resposta;
            do
            {

                Console.WriteLine("1 – Cadastrar de Cliente");
                Console.WriteLine("2 – Listar de Clientes");
                Console.WriteLine("3 – Cadastrar de Vendedor");
                Console.WriteLine("4 – Listar de Vendedores");
                Console.WriteLine("5 – Cadastrar de Produto");
                Console.WriteLine("6 – Listar de Produtos");
                Console.WriteLine("7 – Registrar Venda");
                Console.WriteLine("8 – Listar Vendas");
                Console.WriteLine("9 – Listar Vendas por Cliente");
                Console.WriteLine("0 – Sair");

                Console.WriteLine("Digite a opção:");
                resposta = Convert.ToInt32(Console.ReadLine());
                Console.Clear();



                switch (resposta)
                {
                    case 1:
                        Console.WriteLine("Cadastrar cliente");
                        break;
                    case 2:
                        Console.WriteLine("Listar clientes");
                        break;
                    case 3:
                        Console.WriteLine("Cadastrar de Vendedor");
                        break;
                    case 4:
                        Console.WriteLine("Listar de Vendedores");
                        break;
                    case 5:
                        Console.WriteLine("Cadastrar de Produto");
                        break;
                    case 6:
                        Console.WriteLine("Listar de Produtos");
                        break;
                    case 7:
                        Console.WriteLine("Registrar Venda");
                        break;
                    case 8:
                        Console.WriteLine("Listar Vendas");
                        break;
                    case 9:
                        Console.WriteLine("Listar Vendas por Cliente");
                        break;
                    case 0:
                        Console.WriteLine("saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
                Console.WriteLine("Aperte uma tecla para continuar...");
                Console.ReadKey();

            } while (resposta != 0);
        }
    }
}
