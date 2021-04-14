namespace p1
{
    public class Cidade
    {
        public string Nome { get; private set; }
        public Estado Estado { get; private set; }

        public Cidade(string nome, Estado estado)
        {
            Nome = nome;
            Estado = estado;
        }

    }
}