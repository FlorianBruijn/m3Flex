namespace time_extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));
                Thread.Sleep(1000);
            }
        }
    }
}