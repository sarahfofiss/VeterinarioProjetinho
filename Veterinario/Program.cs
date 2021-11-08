using System;
using Clientes;

namespace Veterinario
{
    class Program

    {
        static void Main(string[] args)
        {
            string opcao;
            Menu menu = new Menu();
            Cliente c = new Cliente();                        
            Consulta con = new Consulta();
            Animal p = new Animal();

            do
            {
                opcao = menu.modoMenu();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastrar Cliente");
                        c.cadastrarCliente();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Cadastrar Pet");
                        p.cadastrarPet();
                        break;
                    case "3":
                        Console.WriteLine("Cadastrar Consulta");
                        con.CadastrarConsulta();
                        break;
                    case "4":
                        Console.WriteLine("Cadastrar Veterinario");
                        Veterinario vet = new Veterinario();
                        vet.cadastrarVet();
                        break;
                    case "5":
                        con.mostrarConsulta();
                        Console.ReadKey();
                        break;
                    case "6":
                        p.visualizarficha();
                        Console.ReadKey();
                        break;
                    case "Q":
                        Console.WriteLine("Encerrando o programa");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
            } while (opcao != "Q");
        }
    }
}
