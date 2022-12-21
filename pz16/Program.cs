using System.Text.RegularExpressions;
namespace pz16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1 = @""; 
            FileInfo file = new FileInfo(file1);
            if (!file.Exists)
            {
                file.Create();
            }

            Console.WriteLine("Введите текст: ");

            using (StreamWriter sw = new StreamWriter(file1))
            {
                string line = "";
                line = Console.ReadLine();
                sw.WriteLine(line);
                string digits = Regex.Replace(line, @"\D", "");
                Console.WriteLine("Количество цифр: " + digits.Length);
                sw.Close();
                Console.ReadLine();
            }
            using (StreamReader sr = new StreamReader(file1))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}