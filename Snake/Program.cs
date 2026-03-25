using Snake;

coordenada gridDimensions = new coordenada(33, 20);
coordenada posicaoCobra = new coordenada(10,1);
Random rand = new Random();
coordenada macapos = new coordenada(rand.Next(1,gridDimensions.x-1), rand.Next(1,gridDimensions.y-1));
int frameDalayMilli = 100;
direcao MovimentoDirecao = direcao.down;
List<coordenada> snakePosHistory = new List<coordenada>();
int taillength = 1;
int score = 0;
while (true)
{
    Console.Clear();
    Console.WriteLine("score: " + score);
    posicaoCobra.ApplyMovimentDirection(MovimentoDirecao);
    for (int y = 0; y < gridDimensions.Y; y++)
    {
        for (int x = 0; x < gridDimensions.X; x++)
        {
            coordenada cordAtual = new coordenada(x, y);
            if (posicaoCobra.Equals(cordAtual) || snakePosHistory.Contains(cordAtual))
                Console.Write("■");
            else if (macapos.Equals(cordAtual))
            {
                Console.Write("a");
            }
            else if (x == 0 || y == 0 || x == gridDimensions.X - 1 || y == gridDimensions.Y - 1)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }

    if (posicaoCobra.Equals(macapos))
    {
        taillength++;
        score++;
        macapos = new coordenada(rand.Next(1,gridDimensions.X-1), rand.Next(1,gridDimensions.Y-1));
    }
    else if (posicaoCobra.X == 0 || posicaoCobra.Y ==0 ||posicaoCobra.X == gridDimensions.X-1 || posicaoCobra.Y ==gridDimensions.Y-1 
             || snakePosHistory.Contains(posicaoCobra))
    {
        score = 0;
        taillength = 1;
        posicaoCobra = new coordenada(10, 1);
        snakePosHistory.Clear();
        MovimentoDirecao = direcao.down;
        continue;
    }
    snakePosHistory.Add(new coordenada(posicaoCobra.X, posicaoCobra.Y));
    if (snakePosHistory.Count > taillength)
    {
        snakePosHistory.RemoveAt(0);
    }
    DateTime time = DateTime.Now;
    while ((DateTime.Now - time).Milliseconds < frameDalayMilli)
    {
        if (Console.KeyAvailable)
        {
            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    MovimentoDirecao = direcao.left;
                    break;
                case ConsoleKey.RightArrow:
                    MovimentoDirecao = direcao.right;
                    break;
                case ConsoleKey.UpArrow:
                    MovimentoDirecao = direcao.up;
                    break;
                case ConsoleKey.DownArrow:
                    MovimentoDirecao = direcao.down;
                    break;
            }
        }
    }
}