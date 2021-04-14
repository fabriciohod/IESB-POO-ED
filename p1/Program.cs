using System;
using System.Collections.Generic;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cadastro = new Cadastro();
            List<ItemLoja> produtos = new List<ItemLoja>()
            {
                new Livro
                (
                    100,
                    cadastro.RelacionarFornecedores(300),
                    19.99f,
                    31.99f,
                    10,
                    "Dom Casmurro",
                    EnumGenero.Ficcao,
                    "Machado de Assis",
                    "Universal"
                ),
                new Livro
                (
                    150,
                    cadastro.RelacionarFornecedores(300),
                    24.35f,
                    58.99f,
                    10,
                    "Unity: design e desenvolvimento de jogos",
                    EnumGenero.Games,
                    "William Pereira Alves",
                    "Universal"
                ),
                new Caderno
                (
                    170,
                    "Caderno Capa Dura - Jaspion",
                    cadastro.RelacionarFornecedores(300),
                    10.99f,
                    25.99f,
                    10,
                    100
                )

            };

            #region Clientes
                
            cadastro.AdicionarCliente(new PessoaFisica
            (
                100,
                "Bob Nelson",
                new Endereco
                (
                    23, 
                    "Rua das Classes", 
                    new Bairro("Jardim das Oliveiras"), 
                    new Cidade("Brasilia", 
                    new Estado("Distrito Federal", "DF"))
                ),
                "bobNelson@gmail.com",
                "111.222.333-99",
                false
            ));

            cadastro.AdicionarCliente(new PessoaFisica
            (
                200,
                "Testolfo Rocha",
                new Endereco
                (
                    4, 
                    "Avenida Abstrata", 
                    new Bairro("Operarios"), 
                    new Cidade("Rio Verde", 
                    new Estado("Goiais", "GO"))
                ),
                "testolfoRocha26@gmail.com",
                "444.555.666-11",
                true
            ));

            cadastro.AdicionarCliente(new PessoaFisica
            (
                300,
                "Belo Teste",
                new Endereco
                (
                    26, 
                    "Vale das Heranças", 
                    new Bairro("Monges Unidos"), 
                    new Cidade("Belo Horizonte", 
                    new Estado("Minas Gerais", "MG"))
                ),
                "Testebelo@gmail.com",
                "999.888.777-72",
                true
            ));

            #endregion

            #region Fornecedores

            cadastro.AdicionarFornecedor(new PessoaJuridica
            (
                400,
                "Livros Associados SA",
                new Endereco
                (
                    45,
                    "Edifício Gaveta",
                    new Bairro("Copacabana"),
                    new Cidade("Rio de Janeiro",
                    new Estado("Rio de Janeiro", "RJ"))
                ),
                "faleconosco@associados.com",
                "99.8888.7777-77"
            ));

            #endregion
        }
    }
}
