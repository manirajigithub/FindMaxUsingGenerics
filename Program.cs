namespace FindMaximumString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            MaximumString maximum = new MaximumString();
            string str = maximum.MaximumStringValue("Apple", "Peach", "Banaana");

            Console.WriteLine("The MaximumString is: " + str);
        }
    }
}