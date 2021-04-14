using System;

namespace p1
{
    public class Caderno : ItemLoja
    {
        public int QtdFolhas { get; private set; }
        public string Nome {get; private set;}

        public Caderno(long iD,string nome ,PessoaJuridica fornecedor, float precoCompra, float precoVenda,int qtdFolhas ,int qtdEstoque) : base(iD, fornecedor, precoCompra, precoVenda, qtdEstoque)
        {
            this.Nome = nome;
            this.QtdFolhas = qtdFolhas;
        }


        public override void MostrarDescricao()
        {
            Console.WriteLine($"Um caderno com {QtdFolhas} paginas");
        }
    }
}