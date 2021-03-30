using System;

namespace Lab1
{
    public class Person
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public float Altura { get; private set; }
        public float Peso { get; private set; }
        private string situacao_IMC = null;
        public string Situacao_IMC
        {
            get => situacao_IMC is null ? GetPersonIMC() : situacao_IMC;
            private set => situacao_IMC = value;
        }

        public Person(string nome, int idade, float peso, float altura) =>
            (Nome, Idade, Peso, Altura) = (nome, idade, peso, altura);

        private string GetPersonIMC()
        {
            float IMC = (Peso / (Altura * Altura));

            if (IMC > 18.5f && IMC < 24.9f)
                return Situacao_IMC = "Parabéns — você está em seu peso normal!";

            if (IMC > 25.0f && IMC < 29.9f)
                return Situacao_IMC = "Você está acima de seu peso (sobrepeso).";

            if (IMC > 30.0f && IMC < 34.9f)
                return Situacao_IMC = "Obesidade grau I.";

            if (IMC > 35.0f)
                return Situacao_IMC = "Obesidade grau II.";

            else
                return Situacao_IMC = "Obesidade graus III e IV.";
        }
    }
}