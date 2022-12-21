namespace pz7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int count = 0;
            Console.Write("Введите количество переменных в массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; n > i; i++)
            {
                int value = rnd.Next(20, 100);
                A[i] = value;
                if (value % 10 == 0)
                {
                    count++;
                }
            }
            int[] B = new int[count];
            for (int i = 0; n > i; i++)
            {
                int value = A[i];
                if (value % 10 == 0)
                {
                    for (int j = 0; count > j; j++)
                    {
                        if (B[j] == 0)
                        {
                            B[j] = value;
                            break;
                        }
                        
                    }
                }
            }
            foreach (int i in B)
            {
                Console.WriteLine(i);
            }

        }
    }
}