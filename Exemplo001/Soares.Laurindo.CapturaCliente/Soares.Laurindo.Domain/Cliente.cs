using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soares.Laurindo.Domain
{
    public class Cliente
    {
        // Atributo
        public int ClienteId { get; set; }
        // Atributo
        public string Nome { get; set; }
        // Atributo
        public DateTime DataNascimento { get; set; }
        // Atributo
        public string EnderecoCompleto { get; set; }

        // Atributo privado
        private DateTime _dataAtual;
        // Atributo
        public DateTime DataAtual
        {
            //set { _dataAtual = value; }
            set => _dataAtual = value;
        }

        // Atributo
        public int Idade
        {
            get { return _dataAtual.Year - DataNascimento.Year; }
        }

        // Função
        public string DadosCompletos()
        {
            return string.Format("ID: {0} Nome: {1} / Idade: {2}", ClienteId, Nome, Idade); 
        }
    }
}
