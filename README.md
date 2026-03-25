# Snake Game | C# .NET Console Application

<p align="center">
  <img src="https://raw.githubusercontent.com/dotnet/brand/main/logo/dotnet-logo.png" alt="C# .NET Logo" width="120px">
</p>

## Visão Geral do Projeto

Este repositório apresenta uma implementação técnica do clássico jogo **Snake**, desenvolvida inteiramente em C#. O projeto foi concebido para demonstrar proficiência em lógica de programação orientada a objetos, manipulação de coleções genéricas e o gerenciamento de ciclos de execução (Game Loop) dentro de um ambiente de console.

---

## Arquitetura de Software

A solução é fundamentada na separação de responsabilidades, dividindo o domínio do sistema em três componentes principais:

| Componente | Função Técnica |
| :--- | :--- |
| **Program.cs** | Orquestrador global do sistema. Gerencia o estado do jogo, o processamento de entradas assíncronas e o pipeline de renderização. |
| **coordenada.cs** | Abstração geométrica que define o posicionamento espacial (X, Y) e encapsula a lógica de translação vetorial. |
| **direcao.cs** | Definição tipada (Enum) dos estados de movimento, garantindo a integr
