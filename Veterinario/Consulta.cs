using System;
using System.Collections.Generic;
using System.Text;
using Clientes;

namespace Veterinario
{
    class Consulta : Cliente
    {
        Cliente c = new Cliente();

        private DateTime data_consulta;
        private DateTime hora_consulta;
        private string tipo_consulta;
        private double valor;
        private string nomeCliente;
        private string nomepet;

        public void CadastrarConsulta()
        {
            Console.WriteLine("Cadastrar Consulta");
            Console.WriteLine("Digite o tipo da consulta");
            tipo_consulta = Console.ReadLine();
            data_consulta = DateTime.Now;
            Console.WriteLine(data_consulta.Date);
        }

        public void mostrarConsulta()
        {
            Console.WriteLine("--- Consulta ---");
            Console.WriteLine("Nome:{0}", c.nome);
            Console.WriteLine("Cpf:{0}", c.cpf);
            Console.WriteLine("Pet:{0}", nomepet);
            Console.WriteLine("Tipo:{0}", tipo_consulta);
            Console.WriteLine("Data:{0}", data_consulta);
        }
    }
}
