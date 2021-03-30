using System;
using Xunit;

namespace Lab1.Tests
{
    public class PersonTest
    {
        [Theory]
        [InlineData("Bob Nelson", 37, 78, 1.70f, "Você está acima de seu peso (sobrepeso).")]
        [InlineData("Testolfo Rocha", 47, 60, 1.65f, "Parabéns — você está em seu peso normal!")]
        [InlineData("Lisa Leite", 47, 92, 1.72f, "Obesidade grau I.")]
        public void Test_Person_IMC(string nome, int idade, int peso, float altura, string resultado)
        {
            Person person = new(nome, idade, peso, altura);

            Assert.Equal(resultado, person.Situacao_IMC);
        }
    }
}
