namespace Snake;

public class coordenada
{
    public int x;
    public int y;

    public  int X { get{return x; } }
    public  int Y { get{return y; } }

    public coordenada(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override bool Equals(object? obj)
    {
        if ((obj == null) || !GetType().Equals(obj.GetType()))
        {
            return false;
        }

        coordenada outro = (coordenada)obj;
        return x == outro.x && y == outro.y;
    }

    public void ApplyMovimentDirection(direcao direcao)
    {
        switch (direcao)
        {
            case direcao.left:
                x--;
                break;
            case direcao.right:
                x++;
                break;
            case direcao.down:
                y++;
                break;
            case direcao.up:
                y--;
                break;
        }
    }
}
