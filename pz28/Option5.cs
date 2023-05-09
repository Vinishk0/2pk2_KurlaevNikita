/*namespace pz28
{
    // Вариант 5
    public class Visitor
    {
        public static event Action<int> VisitorCount;
        private static int visitorCount;

        public Visitor()
        {
            visitorCount++;
            if (visitorCount > 30)
            {
                VisitorCount?.Invoke(visitorCount);
            }
        }

        public static int GetVisitorCount()
        {
            return visitorCount;
        }
    }

    public class Controller
    {
        static void Main(string[] args)
        {
            Visitor.VisitorCount += OnVisitorCount;

            for (int i = 0; i < 35; i++)
            {
                Visitor visitor = new Visitor();
                if (Visitor.GetVisitorCount() <= 30)
                {
                    Console.WriteLine($"Создан посетитель №{Visitor.GetVisitorCount()}!");
                }
                else break;
            }
        }

        static void OnVisitorCount(int count)
        {
            Console.WriteLine("\nПоселителей больше 30!");
        }
    }
}*/