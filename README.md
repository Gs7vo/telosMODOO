# Simulator Télos - Nível#6

Este repositório contém o código C# para a implementação de um sistema de inimigos para um jogo de aventura em 2D. O sistema permite a criação de uma classe base **Enemy** com atributos e comportamentos comuns, além de subclasses específicas para tipos variados de inimigos com habilidades únicas.

Este projeto foi desenvolvido em colaboração com o mentor **Roberto** como parte do **programa Afro Digital da [Télos Conecta](https://www.telosconecta.com)**.

## Estrutura do Sistema

- **Classe Base Enemy**: Define atributos encapsulados de saúde e velocidade, além de métodos para receber dano, exibir status, movimentar-se e verificar se o inimigo está morto.
- **Subclasses Específicas**:
  - **EnemyWithAttack**: Inimigo que ataca o jogador, com atributo de força de ataque e método específico de ataque.
  - **FlyingEnemy**: Inimigo com capacidade de voo, com atributo de altitude e método de voo.
  - **StealthyEnemy**: Inimigo com habilidade de ficar invisível, possuindo método de furtividade.
  - **Boss**: Inimigo especial com habilidade de se enfurecer, tornando-se mais agressivo quando sua saúde está baixa.

## Funcionalidades Implementadas

- **Encapsulamento**: Atributos acessíveis apenas por métodos apropriados, garantindo controle de modificação.
- **Herança**: Estrutura que permite que subclasses herdem da classe **Enemy** e sobrescrevam métodos quando necessário.
- **Polimorfismo**: Métodos como `Mover` podem ser chamados para qualquer instância de **Enemy** ou suas subclasses, exibindo comportamentos específicos para cada tipo de inimigo.
- **Abstração**: A classe **Enemy** contém apenas métodos e atributos comuns, enquanto detalhes específicos são implementados nas subclasses.

## Tecnologias Utilizadas

- **C#**: Linguagem de programação principal para desenvolver o sistema.

## Autor

**Gustavo Martins**. Você pode entrar em contato comigo através do [LinkedIn](https://www.linkedin.com/in/gustavo-henrique-martins-1b031929b/).
