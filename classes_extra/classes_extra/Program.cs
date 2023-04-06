namespace classes_extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(100, 200, 50, 50);
        }
    }
    public class Rectangle
    {
        static int x;
        static int y;
        static int Width;
        static int Height;
        private int v1;
        private int v2;
        private int v3;
        private int v4;

        public Rectangle(int v1, int v2, int v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }
    }
}