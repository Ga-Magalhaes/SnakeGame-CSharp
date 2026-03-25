# Snake Game | Desenvolvimento de Lógica em C#

<p align="center">
  <img src="https://raw.githubusercontent.com/dotnet/brand/main/logo/dotnet-logo.png" alt="C# .NET Logo" width="100px">
</p>

## Visão Geral
Este projeto é uma aplicação de console que simula o jogo Snake. A implementação foca em algoritmos de colisão, manipulação de coleções para o corpo da serpente e um sistema de coordenadas customizado.

---

## Explicação Detalhada do Código

### 1. O Sistema de Coordenadas (`coordenada.cs`)
A classe `coordenada` é a base de toda a lógica espacial do jogo. 
* **Atributos e Propriedades**: Ela armazena inteiros `x` e `y`. Note que as propriedades `X` e `Y` facilitam o acesso controlado a esses valores.
* **Método ApplyMovimentDirection**: Este método é o motor de movimento. Ele recebe um `enum` de direção e altera os valores de `x` ou `y`. Por exemplo, no sistema de coordenadas do console, para ir para baixo, incrementamos o `y`, e para ir para cima, decrementamos o `y`.
* **Sobrescrita de Equals**: Essencial para a lógica de colisão. O método foi reescrito para que, ao comparar duas coordenadas, o C# verifique se os valores de X e Y são iguais, em vez de verificar se são o mesmo objeto na memória.

### 2. Definição de Estados (`direcao.cs`)
Utilizou-se um `enum` para tipar as direções (up, down, left, right). Isso evita o uso de "strings mágicas" ou números soltos no código, tornando a lógica de controle no `Program.cs` muito mais legível e menos propensa a erros.

### 3. O Ciclo de Execução (`Program.cs`)
O arquivo principal gerencia o estado do jogo através de um loop `while (true)`.

#### Gerenciamento da Serpente e Cauda
A lógica da cauda utiliza uma `List<coordenada>` chamada `snakePosHistory`:
1.  **Movimento**: A cada ciclo, a posição atual da cabeça é adicionada a essa lista.
2.  **Manutenção do Tamanho**: Se a quantidade de itens na lista for maior que o tamanho permitido da cauda (`taillength`), removemos o item mais antigo (`RemoveAt(0)`). Isso cria o efeito visual de movimento, onde a "cauda" segue a "cabeça".

#### Lógica de Renderização (O Grid)
O desenho na tela é feito através de dois laços `for` aninhados que percorrem a largura e altura definidas em `gridDimensions`:
* **Prioridade 1**: Se a coordenada atual for igual à posição da cabeça ou estiver contida no histórico da cauda, desenha-se o corpo (`■`).
* **Prioridade 2**: Se coincidir com a posição da maçã, desenha-se o alvo (`a`).
* **Prioridade 3**: Se X ou Y estiverem nos limites (0 ou máximo), desenha-se a borda (`#`).

#### Processamento de Input e Delay
O jogo utiliza um loop secundário para controlar o tempo de cada quadro (`frameDalayMilli`). Dentro dele, o comando `Console.KeyAvailable` verifica se o usuário pressionou uma tecla sem interromper a execução do jogo. Se uma seta for pressionada, a variável `MovimentoDirecao` é atualizada, alterando o rumo da serpente no próximo ciclo.

#### Detecção de Colisão e Reset
Existem duas verificações críticas de colisão:
1.  **Objetivo**: Se a
