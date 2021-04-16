namespace ClasseAbstrata
{
    public class Circulo : FiguraGeometrica
    {
        public Circulo(double raio, string descricao) : base(_mediada: raio, descricao)
        {
        }

        public override double CalcularArea()
        {
            return 3.14 * (mediada * mediada);
        }

        public override double CalcularPerimetro()
        {
            return 3.14 * 2 * mediada;
        }
    }
}