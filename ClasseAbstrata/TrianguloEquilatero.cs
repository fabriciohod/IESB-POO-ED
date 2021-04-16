using System;

namespace ClasseAbstrata
{
    public class TrianguloEquilatero : FiguraGeometrica
    {
        public TrianguloEquilatero(double lado, string descricao) : base(_mediada: lado, descricao)
        {
        }

        public override double CalcularArea()
        {
            return mediada * mediada * Math.Sqrt(3f) / 4;
        }

        public override double CalcularPerimetro()
        {
            return mediada * 3;
        }
    }
}