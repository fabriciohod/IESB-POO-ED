using System;

namespace ClasseAbstrata
{
    class Program
    {
        static void Main()
        {
            FiguraGeometrica[] figuras =
            {
                new Circulo(4, "circulo"),
                new Quadrado(10, "quadrado"),
                new TrianguloEquilatero(3, "triangulo equilatero"),
                new Hexagono(9, "hexagono")
            };

            foreach (var figura in figuras)
            {
                Console.WriteLine($"{figura.descricao} | Area: {figura.CalcularArea():N2}");
                Console.WriteLine($"{figura.descricao} | Perimetro: {figura.CalcularPerimetro():N2}\n");
            }
        }
    }
}
