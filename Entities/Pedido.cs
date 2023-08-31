using Ler.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ler.Entities
{
    internal class Pedido
    {
        public DateTime Momento { get; private set; }
        public PedidoStatus Status { get; private set; }
        public Cliente Cliente { get; private set; }
        public List<ItemDoPedido> Items { get; private set; } = new List<ItemDoPedido>();

        public Pedido(DateTime momento, PedidoStatus status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AdItem(ItemDoPedido item)
        {
            Items.Add(item);
        }

        public void RemoverItem(ItemDoPedido item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double soma = 0.0;
            foreach (ItemDoPedido item in Items)
            {
                soma += item.SubTotal();
            }
            return soma;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Momento do pedido: {Momento}");
            sb.AppendLine($"Status do pedido: {Status}");
            sb.AppendLine($"Cliente: {Cliente.Nome} ({Cliente.DataNasc}) - {Cliente.Email}");
            sb.AppendLine("Itens do pedido:");

            foreach (ItemDoPedido item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Preço total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
