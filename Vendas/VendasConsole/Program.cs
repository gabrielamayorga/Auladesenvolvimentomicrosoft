//using System;
//using System.Collections.Generic;

//namespace VendasConsole.Views
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int resposta;
//            List<Cliente> clientes = new List<Cliente>();
//            bool clienteencontrado = false;
//            do
//            {

//                Console.WriteLine("1 – Cadastrar de Cliente");
//                Console.WriteLine("2 – Listar de Clientes");
//                Console.WriteLine("3 – Cadastrar de Vendedor");
//                Console.WriteLine("4 – Listar de Vendedores");
//                Console.WriteLine("5 – Cadastrar de Produto");
//                Console.WriteLine("6 – Listar de Produtos");
//                Console.WriteLine("7 – Registrar Venda");
//                Console.WriteLine("8 – Listar Vendas");
//                Console.WriteLine("9 – Listar Vendas por Cliente");
//                Console.WriteLine("0 – Sair");

//                Console.WriteLine("Digite a opção:");
//                resposta = Convert.ToInt32(Console.ReadLine());

//                Console.Clear();


//                switch (resposta)
//                {
//                    case 1:
//                        Console.WriteLine("Cadastrar cliente");

//                        var c = new Cliente();

//                        Console.WriteLine("Informe seu nome:");
//                        c.Nome = Console.ReadLine();

//                        Console.WriteLine("Informe seu CPF:");
//                        c.Cpf = Console.ReadLine();

//                        if (ValidarCpf(c.Cpf))
//                        {
//                            if (!clienteencontrado == true)
//                            {
//                                clientes.Add(c);
//                                Console.WriteLine("CPF cadastrado");
//                            }
//                        }

//                        foreach (Cliente cliente in clientes)
//                        {
//                            if (clientes.Count == 0)
//                            {
//                                clientes.Add(c);
//                                Console.WriteLine("CPF já existente, tente novamente");
//                            }

//                            else
//                            {
//                                clienteencontrado = false;
//                                foreach (Cliente clienteencontado in clientes)
//                                {
//                                    if (cliente.Cpf == c.Cpf)
//                                    {
//                                        Console.WriteLine("CPF já existente, tente novamente");
//                                        clienteencontrado = true;
//                                    }
//                                }
//                            }
//                            if (!clienteencontrado == true)
//                            {
//                                clientes.Add(c);
//                                Console.WriteLine("CPF cadastrado");
//                            }
//                            else
//                            {
//                                Console.WriteLine("CPF cadastrado");
//                            }
//                        }

//                        break;
//                    case 2:
//                        Console.WriteLine("Listar clientes");

//                        foreach (Cliente cliente in clientes)
//                        {
//                            Console.WriteLine(cliente);
//                        }
//                        break;
//                    case 3:
//                        Console.WriteLine("Cadastrar de Vendedor");
//                        break;
//                    case 4:
//                        Console.WriteLine("Listar de Vendedores");
//                        break;
//                    case 5:
//                        Console.WriteLine("Cadastrar de Produto");
//                        break;
//                    case 6:
//                        Console.WriteLine("Listar de Produtos");
//                        break;
//                    case 7:
//                        Console.WriteLine("Registrar Venda");
//                        break;
//                    case 8:
//                        Console.WriteLine("Listar Vendas");
//                        break;
//                    case 9:
//                        Console.WriteLine("Listar Vendas por Cliente");
//                        break;
//                    case 0:
//                        Console.WriteLine("saindo...");
//                        break;
//                    default:
//                        Console.WriteLine("Opção invalida");
//                        break;
//                }
//                Console.WriteLine("Aperte uma tecla para continuar...");
//                Console.ReadKey();

//            } while (resposta != 0);
//        }

//        private static bool ValidarCpf(string cpf)
//        {
//            int peso = 10, soma = 0, resto, digito1, digito2;

//            cpf = cpf.Replace(".", "").Replace("-", "");
//            if (cpf.Length != 11)
//            {
//                return false;
//            }
//            switch (cpf)
//            {
//                case "11111111111": return false;
//                case "22222222222": return false;
//                case "33333333333": return false;
//                case "44444444444": return false;
//                case "55555555555": return false;
//                case "66666666666": return false;
//                case "77777777777": return false;
//                case "88888888888": return false;
//                case "99999999999": return false;
//                case "00000000000": return false;
//            }
//            //Digito 1
//            //olhar tabela ascii
//            for (int i = 0; i < 9; i++)
//            {
//                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
//                //Console.WriteLine($"{cpf[i]} x {peso} = {multiplicacao}");
//                peso --;
//            }
//            resto = soma % 11;
//            if(resto < 2)
//            {
//                digito1 = 0;
//            }
//            else
//            {
//                digito1 = 11 - resto;
//            }
//            if(Convert.ToInt32(cpf[9].ToString()) != digito1)
//            {
//                return false;
//            }

//            //Digito 2
//            soma = 0;
//            peso = 11;

//            for (int i = 0; i < 10; i++)
//            {
//                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
//                peso--;
//            }
//            resto = soma % 11;
//            if (resto < 2)
//            {
//                digito2 = 0;
//            }
//            else
//            {
//                digito2 = 11 - resto;
//            }
//            if (Convert.ToInt32(cpf[10].ToString()) != digito2)
//            {
//                return false;
//            }

//            return true;
//        }
//    }
//}
using System;
using System.Collections.Generic;

namespace VendasConsole.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Cliente c = new Cliente();
            List<Cliente> clientes = new List<Cliente>();
            bool clienteEncontrado = false;

            do
            {
                Console.Clear();
                Console.WriteLine("PROJETO DE VENDAS\n");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("0 - Sair\n");
                Console.WriteLine("Escolha uma opção:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        c = new Cliente();
                        Console.WriteLine("CADASTRAR CLIENTE\n");
                        Console.WriteLine("Digite o nome do cliente:");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente:");
                        c.Cpf = Console.ReadLine();

                        if (ValidarCpf(c.Cpf))
                        {
                            if (clientes.Count == 0)
                            {
                                clientes.Add(c);
                                Console.WriteLine("\nCliente cadastrado como sucesso!!!");
                            }
                            else
                            {
                                clienteEncontrado = false;
                                foreach (Cliente clienteCadastrado in clientes)
                                {
                                    if (clienteCadastrado.Cpf == c.Cpf)
                                    {
                                        Console.WriteLine("Esse cliente já existe!");
                                        clienteEncontrado = true;
                                    }
                                }
                                if (!clienteEncontrado)
                                {
                                    clientes.Add(c);
                                    Console.WriteLine("\nCliente cadastrado como sucesso!!!");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nCPF inválido!!!");
                        }
                        break;
                    case 2:
                        Console.WriteLine(" --- LISTAR CLIENTES --- \n");
                        foreach (Cliente clienteCadastrado in clientes)
                        {
                            Console.WriteLine(clienteCadastrado);
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saindo...\n");
                        break;
                    default:
                        Console.WriteLine(" --- OPÇÃO INVÁLIDA!!! --- \n");
                        break;
                }
                Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        private static bool ValidarCpf(string cpf)
        {
            int peso = 10, soma = 0, resto, digito1, digito2;

            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
            }
            switch (cpf)
            {
                case "11111111111": return false;
                case "22222222222": return false;
                case "33333333333": return false;
                case "44444444444": return false;
                case "55555555555": return false;
                case "66666666666": return false;
                case "77777777777": return false;
                case "88888888888": return false;
                case "99999999999": return false;
                case "00000000000": return false;
            }

            //Digito1
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - resto;
            }
            if (Convert.ToInt32(cpf[9].ToString()) != digito1)
            {
                return false;
            }

            //Digito2
            soma = 0;
            peso = 11;
            for (int i = 0; i < 10; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - resto;
            }
            if (Convert.ToInt32(cpf[10].ToString()) != digito2)
            {
                return false;
            }
            return true;
        }
    }
}