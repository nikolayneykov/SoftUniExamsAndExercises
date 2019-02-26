public class Rectangle
{
    private Point topLeft;
    private Point bottomRight;

    public Point TopLeft
    {
        get { return this.topLeft; }
        private set { this.topLeft = value; }
    }

    public Point BottomRight
    {
        get { return this.bottomRight; }
        private set { this.bottomRight = value; }
    }

    public Rectangle(Point topLeft, Point bottomRight)
    {
        this.TopLeft = topLeft;
        this.BottomRight = bottomRight;
    }

    public bool Contains(Point p)
    {
        if (this.TopLeft.X <= p.X && this.BottomRight.X >= p.X &&
            this.TopLeft.Y <= p.Y && this.BottomRight.Y >= p.Y)
        {
            return true;
        }
        return false;
    }

}

