namespace pz27
{
    struct MARSH
    {
        public string BEGST;
        public string TERM;
        public int NUMER;
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool completed = false;
            MARSH[] TRAFIC = new MARSH[8];

            for (int i = 0; i < TRAFIC.Length; i++)
            {
                Console.WriteLine("Введите данные маршрута №{0}:", i + 1);
                Console.Write("Название начального пункта: ");
                string begst = Console.ReadLine();
                Console.Write("Название конечного пункта: ");
                string term = Console.ReadLine();
                TRAFIC[i] = new MARSH { BEGST = begst, TERM = term, NUMER = i + 1 };
            }

            Console.Write("Введите название пункта: ");
            string input = Console.ReadLine();

            foreach (MARSH marsh in TRAFIC)
            {
                if (marsh.BEGST == input || marsh.TERM == input)
                {
                    Console.WriteLine($"Маршрут №{marsh.NUMER}, начинающийся в пункте {marsh.BEGST} и заканчивающийся в пункте {marsh.TERM}");
                    completed = true;
                }
            }

            if (!completed)
            {
                Console.WriteLine($"Маршруты, начинающиеся или заканчивающиеся в пункте {input}, не найдены.");
            }
        }
    }
}