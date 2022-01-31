using Soares.Laurindo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soares.Laurindo.Data
{
    public class ClienteRepository
    {
        public List<Cliente> ObterRelacaoClientes()
        {
            List<Cliente> relacaoCliente = new List<Cliente>();

            for (int i = 1; i <= 50; i++)
            {
                Cliente c = new Cliente();
                c.ClienteId = i;
                c.Nome = $"Nome do cliente {i}";
                c.DataNascimento = DateTime.Now.AddYears(-i);
                c.EnderecoCompleto = $"Av. Das Pedras, casa B BLoco {i} FavelaCity";
                c.DataAtual = DateTime.Now.Date;

                relacaoCliente.Add(c);
            }

            return relacaoCliente;
        }
    }
}
