using Soares.Laurindo.Application;
using Soares.Laurindo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soares.Laurindo.CapturaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteApplication clienteApplication = new ClienteApplication();
            int idade = 18;

            List<Cliente> relacaoMaisVelhos = clienteApplication.ObterRelacaoClientesMaisVelhosQue(idade);
            List<Cliente> relacaoClientesIdadePar = clienteApplication.ObterRelacaoClientesIdadePar();

            Console.WriteLine($"Relação dos clientes mais velhos que { idade } anos");
            foreach (Cliente cliente in relacaoMaisVelhos)
            {
                Console.WriteLine(cliente.DadosCompletos());
            }

            Console.WriteLine("Relação dos clientes com idade PAR");
            foreach (Cliente cliente in relacaoClientesIdadePar)
            {
                Console.WriteLine(cliente.DadosCompletos());
            }

            Console.ReadLine();
        }
    }
}
