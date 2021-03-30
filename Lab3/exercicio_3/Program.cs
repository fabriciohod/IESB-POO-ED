using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalDaCompra = 0;

            Produto[] carrinho =
            {
                new Livro(60,"Harry Potter","JK Rowling", "Uma historia de aventura e magia"),
                new JogoDigital(100, "Counter-Strike", "PC"),
                new Livro(60,"Solo Leveling - Volume 1","Chugog"),
            };

            foreach (var item in carrinho)
            {
                totalDaCompra += item.InformarPreco();

                Console.WriteLine($"{item}\n");
            }

            Console.WriteLine($"Total da sua compra e {totalDaCompra:C}");
        }
    }
}
