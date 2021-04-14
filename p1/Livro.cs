using System;

namespace p1
{
    public class Livro : ItemLoja
    {
        public string Titulo { get; private set; }
        public EnumGenero Genero { get; private set; }
        public string Autor { get; private set; }
        public string Editora { get; private set; }
        public Livro(long iD, PessoaJuridica fornecedor, float precoCompra, float precoVenda, int qtdEstoque, string titulo, EnumGenero genero, string autor, string editora) : base(iD, fornecedor, precoCompra, precoVenda, qtdEstoque)
        {
            this.Titulo = titulo;
            this.Genero = genero;
            this.Autor = autor;
            this.Editora = editora;
        }

        public override void MostrarDescricao()
        {
            Console.WriteLine($"Titulo: {Titulo} | Genero: {Genero} | Autor: {Autor} | Editora: {Editora}");
        }
    }
}