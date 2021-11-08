using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinario
{
    class Menu
    {

        public string modoMenu()
        {
            Console.Clear();
            Console.WriteLine("1 -Cadastrar Cliente");
            Console.WriteLine("2 -Cadastrar Pet");
            Console.WriteLine("3 -Cadastrar Consulta");
            Console.WriteLine("4 -Cadastrar Veterinario");
            Console.WriteLine("5 -Mostrar Consulta");
            Console.WriteLine("6 -Visualizar ficha do pet");
            Console.WriteLine("Q -Sair");
            Console.WriteLine("Escolha uma opcao:");
            string opcao;
            opcao = Console.ReadLine();
            return opcao.ToUpper();

        }

    }
}