public class Point
{
    private int x;
    private int y;

    public int X
    {
        get { return this.x; }
        private set { this.x = value; }
    }


    public int Y
    {
        get { return this.y; }
        private set { this.y = value; }
    }


    public Point(int x,int y)
    {
        this.X = x;
        this.Y = y;
    }
}

