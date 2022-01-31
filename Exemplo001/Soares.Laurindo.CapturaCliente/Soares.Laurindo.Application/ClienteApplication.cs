using Soares.Laurindo.Data;
using Soares.Laurindo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soares.Laurindo.Application
{
    public class ClienteApplication
    {
        public List<Cliente> ObterRelacaoClientesMaisVelhosQue(int idadeAnos)
        {
            List<Cliente> relacaoCliente = new ClienteRepository().ObterRelacaoClientes();
            return relacaoCliente.Where(x => x.Idade >= idadeAnos).ToList();
        }

        public List<Cliente> ObterRelacaoClientesIdadePar()
        {
            List<Cliente> relacaoCliente = new ClienteRepository().ObterRelacaoClientes();
            return relacaoCliente.Where(x => (x.Idade % 2) == 0).ToList();
        }
    }
}
