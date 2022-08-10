namespace GreatestUsingParams
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] num = new int[3] { 10, 45, 543 };
            string[] name = new string[6] { "Raji", "Mani", "Vaishu", "Chinnu", "Nitish", "Manasa" };
            float[] numOne = new float[5] { 0.02F, 0.03F, 1.05F, 2.08F, 1.8F };
            Calculate<int> greatest = new Calculate<int>(num);
            greatest.sort();
            greatest.Comparison();
            greatest.Show();
            Console.WriteLine("biggest:" + greatest.Comparison());
            Calculate<string> great = new Calculate<string>(name);
            great.sort();
            great.Comparison();
            great.Show();
            Console.WriteLine("biggest:" + great.Comparison());
            Calculate<float> greatTwo = new Calculate<float>(numOne);
            greatTwo.sort();
            greatTwo.Comparison();
            greatTwo.Show();
            Console.WriteLine("biggest:" + greatTwo.Comparison());
        }
    }
}
