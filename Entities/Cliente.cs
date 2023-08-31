using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ler.Entities
{
    internal class Cliente
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNasc { get; private set; }

        public Cliente(string nome, string email, DateTime dataNasc)
        {
            Nome = nome;
            Email = email;
            DataNasc = dataNasc;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Nome}, ({DataNasc}) - {Email}");
            return sb.ToString();
        }
    }
}
