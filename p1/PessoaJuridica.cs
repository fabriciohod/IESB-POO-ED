namespace p1
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; protected set; }

        public PessoaJuridica(long iD, string nome, Endereco endereco, string email, string cnpj) : base(iD, nome, endereco, email)
        {
            Cnpj = cnpj;
        }
    }
}