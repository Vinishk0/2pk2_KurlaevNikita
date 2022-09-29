namespace pz6
{
    internal class pz6
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            double result = 0;
            double n = Convert.ToDouble(Console.ReadLine());
            double i = 1;
            while (i <= n)
            {
                result += 1 / i;
                i++;
            }
            Console.WriteLine($"Результат равен: {result}");
        }
    }
}