namespace ProblemUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Calculate<int> greatest = new Calculate<int>();
            greatest.Comparison(230, 543, 565);
            Calculate<string> great = new Calculate<string>();
            great.Comparison("Apple", "Peach", "banana");
            Calculate<float> greatTwo = new Calculate<float>();
            greatTwo.Comparison(1.00002F, 2.001F, 1.001F);
        }
    }
       
    
}


