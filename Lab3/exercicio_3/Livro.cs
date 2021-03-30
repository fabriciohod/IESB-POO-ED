using System;

namespace exercicio_3
{
    public class Livro : Produto
    {
        private string autor;

        public Livro(double _preco, string _titulo,string _autor , string _descricao = "Item da loja") : base(_preco, _titulo, _descricao)
        {
            autor = _autor;
        }
    }
}