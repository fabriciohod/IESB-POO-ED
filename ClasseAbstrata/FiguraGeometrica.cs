namespace ClasseAbstrata
{
    public abstract class FiguraGeometrica : ICalcularArea, ICalcularPerimetro
    {
        public double mediada { get; protected set; }
        public string descricao { get; protected set; }

        protected FiguraGeometrica(double _mediada, string _descricao)
        {
            mediada = _mediada;
            descricao = _descricao;
        }

        protected FiguraGeometrica(double _mediada)
        {
            mediada = _mediada;
        }

        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();
    }
}