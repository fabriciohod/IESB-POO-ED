using System;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemMenu[] menu =
            {
                new Bebida("Guarana Antarctica",4, 5, 6),
                new Bebida("Suco de Laranja",7, 8, 9),
                new Bebida("Suco de Secreto",25, 40, 100),
                new Aperitivo("Peixe Frito", 15),
                new Aperitivo("Batata Frita", 10)
            };

            foreach (var item in menu)
            {
                Console.WriteLine("\n" + item);
            }
        }
    }
}
