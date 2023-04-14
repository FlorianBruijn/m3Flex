namespace hello_world_extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string text = "Hello World";
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}