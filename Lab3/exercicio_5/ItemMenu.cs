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
            return nome;
        }

        public virtual string ImprimirPreco()
        {
            return preco.ToString();
        }

        public override string ToString()
        {
            return $"{nome}\nPreço: {preco:C}";
        }
    }
}
