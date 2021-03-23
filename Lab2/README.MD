# Programação Orientada a Objetos e Estrutura de Dados
## Professor: Alexandre Roriz

### Laboratório 02
---
Você foi contratado para desenvolver um sistema para gerenciar as contas do Banco ACME. 
Nesse banco existem dois tipos de conta: conta-corrente ou poupança.
As contas devem armazenar os seguintes atributos:
- número de identificação;
- nome do correntista;
- saldo atual.

Deve ser oferecido ao usuário as seguintes funcionalidades:
- sacar dinheiro, caso haja saldo;
- depositar dinheiro;
- transferir dinheiro para outra conta;
- verificar o saldo.

Uma lei recentemente aprovada passou a efetuar a cobrança de imposto pela movimentação de dinheiro entre contas. Segue abaixo, as tarifas em vigor:

|  Tipo de Conta   |  Tarifa para saque |  Tarifa para transferência |
| :--------------: | :------------------| :--------------------------|
|   Conta-Corrente |        0.37%       |            0.10%           |
|   Conta-Poupança |        0.20%       |            0.15%           |


Um requisito importante é que o saldo das contas NUNCA deve estar negativo. Caso uma operação leve a essa situação, a operação deve ser cancelada e o usuário avisado.

Para validar o sistema considere que existam 3 clientes, com respetivos dados abaixo:

---
### Cliente 1
- Nome: Bob Nelson
- Número da conta: 12345-6
- Tipo da conta: Conta-corrente
---
### Cliente 2
- Nome: Testolfo Rocha
- Número da conta: 71717-1
- Tipo da conta: Conta-poupança
---
### Cliente 3
- Nome: Lisa Leite
- Número da conta: 65432-1
- Tipo da conta: Conta-corrente
---

Verifique qual o valor final do saldo de cada conta ao final das operações abaixo

|     Titular      |                 Ação                    |       Valor       |
| :--------------: | :-------------------------------------: | :---------------: |
|   Bob Nelson     |        Depositou na própria conta       |     R$ 5000,00    |
|   Lisa Leite     |        Depositou na própria conta       |     R$ 2000,00    |
|   Testolfo Rocha |        Depositou na própria conta       |     R$ 1500,00    |
|   Bob Nelson     |        Transferiu para Testolfo Rocha   |     R$ 600,00     |
|   Lisa Leite     |        Efetuou saque                    |     R$ 250,00     |
|   Lisa Leite     |        Transferiu para Testolfo Rocha   |     R$ 400,00     |
|   Testolfo Rocha |        Transferiu para Bob Nelson       |     R$ 1000,00    |
|   Bob Nelson     |        Efetuou saque                    |     R$ 900,000    |
|   Bob Nelson     |        Transferiu para Lisa Leite       |     R$ 1500,00    |
|   Testolfo Rocha |        Transferiu para Lisa Leite       |     R$ 1200,00    |
|   Bob Nelson     |        Efetuou saque                    |     R$ 2000,00    |
|   Lisa Leite     |        Depositou na própria conta       |     R$ 100,00     |
|   Testolfo Rocha |        Transferiu para Bob Nelson       |     R$ 700,00     |

> P.S.(1) Essas operações devem ser simuladas em uma classe de teste.

> P.S.(2) Deseja-se que sejam explorados todos pilares da POO além da utilização de construtores específicos.
