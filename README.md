# Simulador de Chat - Design Pattern Mediator 

Este projeto é uma implementação prática do padrão de projeto comportamental **Mediator**, desenvolvido em C# para demonstrar como centralizar a comunicação entre múltiplos objetos de forma desacoplada.

## Objetivo do Projeto
O objetivo principal é simular uma sala de chat (estilo WhatsApp ou Slack) onde os usuários não possuem referência direta uns para os outros. Toda a troca de mensagens é gerida por um **Mediador Central**, que decide o destino das informações, facilitando a manutenção e a escalabilidade do sistema.

## O Padrão Mediator nesta Solução

No contexto deste chat, os componentes do padrão foram aplicados da seguinte forma:

1.  **Mediator (IChatMediator):** Interface que define o contrato de comunicação (enviar mensagens e registrar usuários).
2.  **Mediator Concreto (SalaDeChat):** A "torre de controle" que armazena a lista de usuários e coordena para quem cada mensagem deve ser enviada, garantindo que o remetente não receba a sua própria mensagem.
3.  **Colleague (Usuario):** Classe abstrata que define a base para os participantes. Ela possui uma referência para o Mediador, mas "não sabe" que os outros usuários existem.
4.  **Concrete Colleague (Participante):** Implementação real do utilizador que envia e recebe notificações através do Mediador.

## Vantagens Observadas
- **Baixo Acoplamento:** Adicionar um novo participante não exige alteração em nenhum outro participante já existente.
- **Lógica Centralizada:** Se quisermos adicionar um filtro de palavras ou um log de mensagens, basta alterar a classe `SalaDeChat`.

## Como rodar o código:
O repositório já contém o arquivo de projeto (`.csproj`). Para executar, basta abrir a pasta no terminal e digitar:

```bash
dotnet run
