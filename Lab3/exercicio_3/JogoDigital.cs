using System;

namespace exercicio_3
{
    public class JogoDigital : Produto
    {
        private string plataforma;

        public JogoDigital(double _preco, string _titulo, string _plataforma, string _descricao = "Item da loja") : base(_preco, _titulo, _descricao)
        {
            plataforma = _plataforma;
        }
    }
}