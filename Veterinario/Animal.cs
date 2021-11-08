using System;
using System.Collections.Generic;
using System.Text;
using Clientes;

namespace Veterinario
{
    class Animal : Cliente
    {

        private string nomepet;
        private string tipo;
        private string raca;
        private double idade;
        private double peso;
        private double altura;
        private string alergia;

        public void cadastrarPet()
        {
            Console.WriteLine("Digite o nome do pet");
            nomepet = Console.ReadLine();
            Console.WriteLine("Digite o tipo de animal");
            tipo = Console.ReadLine();
            Console.WriteLine("Digite a raça");
            raca = Console.ReadLine();
            Console.WriteLine("Digite a idade");
            idade = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Possui alguma alergia? (s/n)");
            alergia = Console.ReadLine();
            if (alergia.ToLower().Equals("s"))
            {
                Console.WriteLine("Qual é a alergia?");
                alergia = Console.ReadLine();
            }
        }
        public void visualizarficha()
        {
            Console.WriteLine("--- Ficha Pet ---");
            Console.WriteLine("Nome Pet:{0}", nomepet);
            Console.WriteLine("Tipo de Animal:{0}", tipo);
            Console.WriteLine("Raça:{0}", raca);
            Console.WriteLine("Idade:{0}", idade);
            Console.WriteLine("Peso:{0}", peso);
            Console.WriteLine("Altura:{0}", altura);
            Console.WriteLine("Alergia:{0}", alergia);
        }
    }
}
