using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinario
{
    class Veterinario
    {
        private string nome;
        private double cpf;
        private double cep;
        private double crv;
        private double telefone;
        private string email;
        private string especialidade;


        public void cadastrarVet()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CEP");
            cep = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua CRV");
            crv = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Telefone");
            telefone = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o email");
            email = Console.ReadLine();
            Console.WriteLine("Digite sua especialidade");
            especialidade = Console.ReadLine();
        }
    }
}
