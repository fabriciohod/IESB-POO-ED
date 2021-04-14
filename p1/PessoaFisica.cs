using System;

namespace p1
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; private set; }
        public bool Vip { get; private set; }

        public PessoaFisica(long iD, string nome, Endereco endereco, string email, string cpf, bool vip) : base(iD, nome, endereco, email)
        {
            Cpf = cpf;
            Vip = vip;
        }
    }
}