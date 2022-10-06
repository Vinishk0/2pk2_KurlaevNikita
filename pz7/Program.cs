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
            int[,] A = new int[n,1];
            for (int i = 0; n > i; i++)
            {
                int value = rnd.Next(20, 100);
                A[i,0] = value;

                if (value % 10 == 0)
                {
                    count++;
                }
            }
            int[,] B = new int[A.Length, 1];
            for (int i = 0; count > i; i++)
            {
                if (A[i, 0] % 10 == 0) 
                {
                    B[i,0] = A[i,0];
                }
                
            }
            foreach (int i in B)
            {
                Console.WriteLine(i);
            }

        }
    }
}