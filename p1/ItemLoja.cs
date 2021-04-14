using System;

namespace p1
{
    public abstract class ItemLoja : IItemRelatorio
    {
        public long ID { get; protected set; }
        public PessoaJuridica Fornecedor { get; protected set; }
        public float PrecoCompra { get; protected set; }
        public float PrecoVenda { get; protected set; }
        public int QtdEstoque { get; protected set; }

        protected ItemLoja(long iD, PessoaJuridica fornecedor, float precoCompra, float precoVenda, int qtdEstoque)
        {
            ID = iD;
            this.Fornecedor = fornecedor;
            this.PrecoCompra = precoCompra;
            this.PrecoVenda = precoVenda;
            this.QtdEstoque = qtdEstoque;
        }

        public abstract void MostrarDescricao();

        public virtual void MostrarQuantidadeEstoque()
        {
            Console.WriteLine($"Quantidade em estoque: {QtdEstoque}");
        }
    }
}