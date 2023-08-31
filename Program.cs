using Ler.Entities;
using Ler.Entities.Enums;
using System.Globalization;

namespace Ler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do cliente: ");
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Email: ");
            string emailCliente = Console.ReadLine();
            Console.Write("Data de nasc (DD/MM/YYYY): ");
            DateTime dataNascCliente = DateTime.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nomeCliente, emailCliente, dataNascCliente);

            Console.WriteLine("Dados do pedido: ");
            Console.Write("Status: ");
            PedidoStatus status = Enum.Parse<PedidoStatus>(Console.ReadLine());

            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.Write("Quantos itens para este pedido: ");
            int nItens = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nItens; i++)
            {
                Console.WriteLine($"Dados do item #{i}: ");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                Produto produto = new Produto(nomeProduto, precoProduto);
                ItemDoPedido item = new ItemDoPedido(quantidade, precoProduto, produto);
                pedido.AdItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("Resumo do pedido:");
            Console.WriteLine(pedido);

        }
    }
}