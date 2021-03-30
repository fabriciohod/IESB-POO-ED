using System;

namespace exercicio_5
{
    public class ItemMenu
    {
        protected string nome;
        private double preco;

        public ItemMenu(string _nome, double _preco)
        {
            nome = _nome;
            preco = _preco;
        }

        public ItemMenu(string _nome)
        {
            nome = _nome;
        }

        public string ImprimirNome()
        {
            return "";
        }

        public virtual string ImprimirPreco()
        {
            return "";
        }

        public override string ToString()
        {
            return $"{nome}\nPreço: {preco:C}";
        }
    }
}