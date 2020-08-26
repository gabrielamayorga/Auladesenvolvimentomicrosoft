using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Controller;

namespace VendasConsole.Views
{
    class ListarCliente
    {
       public static void Renderizar()
        {
            Console.WriteLine(" --- LISTAR CLIENTES --- \n");
            foreach (Cliente clienteCadastrado in ClienteDAO.Listar())
            {
                Console.WriteLine(clienteCadastrado);
            }
        }
    }

}
