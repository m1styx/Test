// See https://aka.ms/new-console-template for more information
namespace Test
{
    class StringCounter
    {
        public static void Main()
        {
            Console.WriteLine("напишите текст");

            string? s = Console.ReadLine();

            if (s == null || s == "")
            {
                Console.WriteLine("Напишите что-то");
            }
            else
            {
                Console.WriteLine("{0}", s.Length);

            }

        }
    }
}