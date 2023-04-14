namespace functions_extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            function(10,"hallo");
        }
         static void function(int nummer, string woord)
        {
            Console.WriteLine(woord);
            Console.WriteLine(nummer);
        }
    }
}