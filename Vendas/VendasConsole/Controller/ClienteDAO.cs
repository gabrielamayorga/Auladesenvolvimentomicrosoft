using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Controller
{
    class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public static List<Cliente> Listar()
        {
            return clientes;
        }

        public static Cliente BuscarPorCpf(string cpf)
        {
            foreach (Cliente clienteCadastrado in clientes)
            {
                if (clienteCadastrado.Cpf == cpf)
                {
                    return clienteCadastrado;
                }
            }
            return null;
        }

        public static bool Cadastrar(Cliente cliente)
        {
            if (BuscarPorCpf(cliente.Cpf) == null)
            {
                clientes.Add(cliente);
                return true;
            }
            return false;
        }

    }
}
