namespace ClasseAbstrata
{
    public class Quadrado : FiguraGeometrica
    {
        public Quadrado(double lado, string descricao) : base(_mediada: lado, descricao)
        {
        }

        public override double CalcularArea()
        {
            return mediada * mediada;
        }

        public override double CalcularPerimetro()
        {
            return mediada + mediada + mediada + mediada;
        }
    }
}