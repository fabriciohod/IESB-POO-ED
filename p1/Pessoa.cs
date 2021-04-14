namespace p1
{
    public abstract class Pessoa
    {
        public long ID { get; protected set; }
        public string Nome { get; protected set; }
        public Endereco Endereco { get; protected set; }
        public string Email { get; protected set; }

        protected Pessoa(long iD, string nome, Endereco endereco, string email)
        {
            ID = iD;
            Nome = nome;
            Endereco = endereco;
            Email = email;
        }

    }
}