using System;

namespace exercicio_5
{
    partial struct TabelaDePreco
    {
        public double Pequeno { get; private set; }
        public double Medio { get; private set; }
        public double Grande { get; private set; }

        public TabelaDePreco(double pequeno, double medio, double grande)
        {
            Pequeno = pequeno;
            Medio = medio;
            Grande = grande;
        }
    }

    public class Bebida : ItemMenu
    {
        TabelaDePreco precos;
        public Bebida(string _nome, double precoPequeno, double precoMedio, double precoGrande) : base(_nome)
        {
            precos = new(precoPequeno, precoMedio, precoGrande);
        }

        public override string ImprimirPreco()
        {
            return String.Join(
                $"Pequena: {precos.Pequeno:C}\n"
                , $"Media: {precos.Medio:C}\n"
                , $"Grande: {precos.Grande:C}"
            );
        }

        public override string ToString()
        {
            return $"{nome}\n{ImprimirPreco()}";
        }
    }
}