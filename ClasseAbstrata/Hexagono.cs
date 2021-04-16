using System;

namespace ClasseAbstrata
{
    public class Hexagono : FiguraGeometrica
    {
        public Hexagono(double lado, string descricao) : base(_mediada: lado, descricao)
        {
        }

        public override double CalcularArea()
        {
            return 3 * (mediada * mediada) * Math.Sqrt(3) / 2;
        }

        public override double CalcularPerimetro()
        {
            return mediada * 6;
        }
    }
}