namespace FindMaximumFloat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            FindMaximumFloat maximum = new FindMaximumFloat();
            double value = maximum.MaximumFloatNumber(5.6, 8.9, 4.4);

            Console.WriteLine("The Maximum Float is:- " + value);
        }
    }
}