namespace ConsoleApp2
{
    internal class pz5
    {
        static void Main(string[] args)
        {
            char let = 'А';
            int j = 50;

            Console.WriteLine("Задание 1");
            for (int i = 10; i <= 100; i += 5)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("Задание 2");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(let);
                let++;
            }

            Console.WriteLine("Задание 3");
            for (int i = 0; i < 6; i++)
            {
                for (int a = 0; a < 7; a++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.WriteLine("Задание 4");
            for (int i = 0; i <= 100; i += 6)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Задание 5");
            for (int i = 4; i != j; i++)
            {
                Console.WriteLine($"i = {i} \n j = {j}");
                j--;
            }
        }
    }
}