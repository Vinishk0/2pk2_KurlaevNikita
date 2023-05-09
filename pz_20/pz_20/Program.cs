namespace pz_20
{
    internal class Program
    {
        static string reg()
        {
            string line = Console.ReadLine();
            string result = "";

            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsLower(line[i]))
                {
                    result += line[i].ToString().ToUpper();
                }
                else
                {
                    result += line[i].ToString().ToLower();
                }
            }

            try
            {
                Console.WriteLine(line[6]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Исключение обработано");
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(reg());
        }
    }
}