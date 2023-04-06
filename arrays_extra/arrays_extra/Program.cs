using System.ComponentModel;

namespace arrays_extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 30, 40, 50, 60 };
            int result = add(array);
            Console.WriteLine(result);
        }
        static int add(int [] to_add)
        {
            int total = 0;
            for (int i = 0; i < to_add.Length; i++)
            {
                total += to_add[i];
            }
            return total;
        }
    }
}