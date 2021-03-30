using System;

namespace Lab1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Bob Nelson", 37, 78, 1.70f);
            Person person2 = new Person("Testolfo Rocha", 47, 60, 1.65f);
            Person person3 = new Person("Lisa Leite", 47, 92, 1.72f);

            Console.WriteLine($"{person1.Nome} | {person1.Situacao_IMC}");
            Console.WriteLine($"{person2.Nome} | {person2.Situacao_IMC}");
            Console.WriteLine($"{person3.Nome} | {person3.Situacao_IMC}");
        }
    }
}
