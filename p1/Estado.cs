namespace p1
{
    public class Estado
    {
        public string Nome { get; private set; }
        public string Sigla { get; private set; }

        public Estado(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

    }
}