using System;

namespace exercicio_3
{
    public class Produto
    {
        private string titulo;
        private string descricao;
        private double preco;

        protected Produto(double _preco, string _titulo, string _descricao = "Item da loja")
        {
            preco = _preco;
            titulo = _titulo;
            descricao = _descricao;
        }

        public string InformarDescricao()
        {
            return descricao;
        }

        public double InformarPreco()
        {
            return preco;
        }

        public override string ToString()
        {
            return $"Titulo: {titulo}\nDescricoa: {InformarDescricao()}\nPreco: {InformarPreco():C}";
        }
    }
}