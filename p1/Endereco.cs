namespace p1
{
    public class Endereco
    {
        public long Numero { get; private set; }
        public string Rua { get; private set; }
        public Bairro Bairro { get; private set; }
        public Cidade Cidade { get; private set; }

        public Endereco(long numero, string rua, Bairro bairro, Cidade cidade)
        {
            Numero = numero;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
        }

    }
}