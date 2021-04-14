using System;
using System.Collections.Generic;

namespace p1
{
    public class Cadastro
    {
        public List<PessoaFisica> Clientes { get; private set; } = new List<PessoaFisica>();
        public List<PessoaJuridica> Fornecedores { get; private set; } = new List<PessoaJuridica>();

        public PessoaFisica RelacionarClientes(long id)
        {
            var temp = Clientes.Find(cliente => cliente.ID == id);

            return temp;
        }

        public PessoaJuridica RelacionarFornecedores(long id)
        {
            var temp = Fornecedores.Find(fornecedor => fornecedor.ID == id);

            return temp;
        }

        public void AdicionarCliente(PessoaFisica novoCliente)
        {
            Clientes.Add(novoCliente);
        }

        public void RemoverCliente(PessoaFisica cliente)
        {
            Clientes.Remove(cliente);
        }

        public void AdicionarFornecedor(PessoaJuridica novoFornecedor)
        {
            Fornecedores.Add(novoFornecedor);
        }

        public void RemoverFornecedor(PessoaJuridica fornecedor)
        {
            Fornecedores.Remove(fornecedor);
        }
    }
}