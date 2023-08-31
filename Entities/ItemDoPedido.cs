using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ler.Entities
{
    internal class ItemDoPedido
    {
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }
        public Produto Produto { get; private set; }

        public ItemDoPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Produto.Nome}, ${Preco.ToString("F2", CultureInfo.InvariantCulture)}, Quantidade: {Quantidade}, Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)} ");
            return sb.ToString();
        }
    }
}
