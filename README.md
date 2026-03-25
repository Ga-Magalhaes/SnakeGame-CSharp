<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            line-height: 1.6;
            color: #333;
            max-width: 800px;
            margin: auto;
            padding: 20px;
            background-color: #f4f4f9;
        }
        .container {
            background: white;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
        }
        h1 { color: #2c3e50; border-bottom: 2px solid #27ae60; padding-bottom: 10px; }
        h2 { color: #27ae60; margin-top: 25px; }
        .logic-card {
            background: #f8f9fa;
            border-left: 5px solid #27ae60;
            padding: 15px;
            margin: 15px 0;
        }
        .code-explanation {
            display: flex;
            align-items: center;
            gap: 20px;
            background: #eef2f3;
            padding: 15px;
            border-radius: 5px;
        }
        .image-placeholder {
            width: 100%;
            height: auto;
            border-radius: 5px;
            border: 1px solid #ddd;
        }
        strong { color: #2c3e50; }
    </style>
</head>
<body>

<div class="container">
    <h1>Entendendo o Snake Game (C#)</h1>
    
    <p>O projeto é dividido em três partes principais que trabalham juntas para criar a ilusão de movimento e as regras do jogo.</p>

    <h2>1. O Sistema de Coordenadas (O Plano)</h2>
    <div class="logic-card">
        <p>Imagine o terminal como um papel quadriculado. O arquivo <strong>coordenada.cs</strong> define os pontos <strong>X</strong> (horizontal) e <strong>Y</strong> (vertical). </p>
        <ul>
            <li><strong>ApplyMovimentDirection:</strong> Esta função é o motor. Se a direção for "Up", ela subtrai 1 de Y. Se for "Right", soma 1 em X.</li>
        </ul>
    </div>

    

    <h2>2. O Loop Principal (O Coração)</h2>
    <div class="logic-card">
        <p>No <strong>Program.cs</strong>, tudo acontece dentro de um <code>while (true)</code>. A cada ciclo:</p>
        <ol>
            <li><strong>Limpeza:</strong> O console é apagado para desenhar o novo frame.</li>
            <li><strong>Desenho:</strong> Dois laços (for) percorrem toda a grade. Se a posição atual for a da cobra, desenha <strong>■</strong>. Se for a maçã, desenha <strong>a</strong>. Se for a borda, desenha <strong>#</strong>.</li>
            <li><strong>Histórico:</strong> A lista <code>snakePosHistory</code> guarda onde a cobra passou. Se ela cresce (come maçã), mantemos mais itens na lista para formar o corpo.</li>
        </ol>
    </div>

    <h2>3. Controle e Colisão (As Regras)</h2>
    <div class="logic-card">
        <p>O jogo verifica constantemente se a cabeça da cobra atingiu as bordas ou o próprio corpo através do método <code>.Equals()</code>, que compara se as coordenadas X e Y são idênticas.</p>
    </div>

    <div class="code-explanation">
        <div>
            <strong>Input do Usuário:</strong> O código usa <code>Console.KeyAvailable</code>. Isso é crucial porque permite que o jogo continue rodando mesmo se você não apertar nenhuma tecla, capturando o movimento apenas quando você decide mudar a direção.
        </div>
    </div>
</div>

</body>
</html>
