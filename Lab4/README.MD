## Programação Orientada a Objetos e Estrutura de Dados
### Professor Alexandre Roriz
### Laboratório 04
---
Você foi contratado para participar do desenvolvimento do SpaceGame II, mais um jogo
sobre o aclamado herói Bob Nelson, que reencontrará os ‘piratas do espaço’ para a batalha
final!!! 

Bob Nelson utilizará uma nave de guerra para combater inimigos. Tanto a nave de guerra de
Bob, quanto as dos seus adversários podem dar tiros que causam danos (redução de
energia) quando o alvo é acertado. 
Em outro momento do jogo, Bob Nelson utilizará uma nave de transporte com uma carga
preciosa a ser protegida dos piratas. Essa nave não possui a capacidade de atirar. 

As naves deverão possuir as seguintes características:
No jogo, as classes que representarão as naves deverão possuir os seguintes atributos e
respectivos tipos: 

- Nome: string;
- Nível de Combustível: int;
- Energia: int;
- Velocidade: int;
- Posição: int;
- Potência do Tiro: int;
- Velocidade do Tiro: int. 

Os atributos devem estar devidamente encapsulados. 

O comportamento deverá ser expresso nos métodos “mover” e “atirar”. 

Dica: Utilize a classe Nave como virtual. 

A nave do tipo transporte deverá apresentar uma propriedade que reflita a carga que ela
está transportando. Sendo que isso influenciará no gasto de combustível. 

Cabe destacar que o atributo “Posição” deverá conter duas dimensões (x e y), visto que se
trata de um jogo 2D. 

No ataque de uma das naves, o tiro deve ser modelado para conter as propriedades: 
posição, velocidade e potência. 

Outros objetos importantes no jogo são os Asteróides. Eles ficam orbitando pelo espaço, levando as naves a desviarem-se deles. 
Os asteróides possuem os atributos:energia e posição.

As naves e asteróides devem verificar a quantidade de dano ocorrida quando um ataque ou um objeto os atinge. 
E todos devem separar os danos em 3 tipos (dano pequeno, dano médio e dano grave) a depender do impacto sofrido. 

Dica: Criar interfaces para verificar o dano e para o movimento dos objetos. Para testar o código crie dois cenários de teste: 

- Nave de ataque do Bob Nelson enfrenta 3 piratas do espaço e deve desviar de 2
asteróides. Bob Nelson deve efetuar disparos até que os 3 adversários sejam
destruídos.
- Bob Nelson precisa entregar a carga preciosa no destino. Serão 2 piratas do espaço
buscando acertar o alvo. Bob Nelson deve receber alguns ataques, mas não o
suficientes para ser destruído