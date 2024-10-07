# Caixa-Eletronico
Etapas Implementadas

1. Criação da Estrutura Inicial:

O programa foi estruturado com classes e métodos principais necessários para simular um caixa eletrônico. A classe Conta foi criada para representar uma conta bancária, e a classe Program foi utilizada para gerenciar a interação com o usuário.



2. Implementação das Funcionalidades:

Saque: Permite que o usuário faça saques da conta, com verificação do saldo e valor válido.

Depósito: O usuário pode fazer depósitos, que aumentam o saldo da conta.

Extrato: Mostra os detalhes da conta (titular, tipo de conta e saldo), além de ser salvo em um arquivo de texto.

Transferência: Simula a transferência de valores entre duas contas diferentes.



3. Estruturas de Decisão:

Foram usadas estruturas condicionais (if e else) para verificar saldo, valores e executar operações com segurança.



4. Laços de Repetição:

O programa utiliza um laço while para permitir que o usuário realize várias operações até escolher a opção de sair.



5. Salvar Extrato em Arquivo:

Implementação da funcionalidade que gera um arquivo .txt com o extrato da conta quando o usuário solicita.



6. Interação via Console:

A interface foi construída usando a entrada e saída de dados pelo console, permitindo fácil interação do usuário.





---

O que foi Utilizado (Ferramentas)

Visual Studio Code: Utilizado como ambiente de desenvolvimento integrado (IDE) para editar e compilar o código em C#.

.NET Core SDK: Para compilar e executar o programa.

Git: Utilizado para controle de versão e upload do código no GitHub.

GitHub: Plataforma para hospedagem do código e controle de versão.



---

Backlog

1. Versão Atual (MVP):

Criar uma conta com nome e tipo de conta.

Funcionalidade de saque.

Funcionalidade de depósito.

Visualização de extrato.

Transferência entre duas contas.

Salvar extrato em arquivo .txt.



2. Melhorias Futuras (Backlog):

Autenticação: Implementar um sistema de login com senha para os usuários.

Multiplas Contas: Permitir o cadastro e a manipulação de múltiplas contas dentro do mesmo programa.

Limites de Saque: Definir limites diários de saque por usuário.

Menu de Configurações: Permitir que o usuário ajuste detalhes da conta (como alterar a senha).

Histórico Completo de Transações: Guardar o histórico de todas as transações realizadas, e não apenas o saldo final.

Interface Gráfica: Substituir a interação via console por uma interface gráfica com botões e telas.





---

Conclusão

O projeto implementado cumpre os requisitos básicos de um simulador de caixa eletrônico, permitindo operações como saque, depósito, extrato e transferências entre contas. Além disso, foi acrescentada a funcionalidade de salvar o extrato da conta em um arquivo de texto, fornecendo uma experiência mais realista ao usuário.

As etapas de desenvolvimento incluíram o uso de estruturas de decisão para validações e laços de repetição para manter o sistema ativo até que o usuário escolha sair. A utilização de uma ferramenta leve como o Visual Studio Code, em conjunto com o .NET Core, permitiu um ambiente ágil de desenvolvimento.

Este projeto pode ser facilmente estendido, e o backlog definido aponta para diversas funcionalidades avançadas que podem ser implementadas para simular um caixa eletrônico mais completo.
