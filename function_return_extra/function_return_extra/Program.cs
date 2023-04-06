namespace function_return_extra
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int num = random_number();
            Console.WriteLine(num);
        }
        static int random_number()
        {
            int number = new Random().Next(100);
            return number;
        }
    }
}