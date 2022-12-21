namespace pz15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream File1 = new FileStream(@"D:\File_New.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(File1);
            double sum = 0;
            double[] nums = new double[50];
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                nums[i] = rnd.NextDouble() + rnd.Next(1000000, 9999999);
                writer.WriteLine(nums[i].ToString("### ####.#0"));
            }
            sum = nums.Sum();
            writer.WriteLine(sum.ToString("####.#0"));
            writer.Close();
        }
    }
}