namespace LineComparisonComputation
{
class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Line Comparison Computation Program");
            //Console.ReadLine();
            double x1, x2, y1, y2, result1;
            Console.WriteLine("Enter the x and y coordinate of first point { ");
             x1=Convert.ToDouble(Console.ReadLine());
             y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the x and y coordinate of second point { ");
             x2 = Convert.ToDouble(Console.ReadLine());
             y2 = Convert.ToDouble(Console.ReadLine());

            double x = (x2 - x1) * (x2 - x1);
            double y=(y2-y1)*(y2-y1);
            double sum = x + y;
            result1 = Math.Sqrt(sum);
            Console.WriteLine("Length of first line is {0}", result1);

            double a1, a2, b1, b2, result2;
            Console.WriteLine("Enter the x and y coordinate of first point { ");
            a1 = Convert.ToDouble(Console.ReadLine());
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the x and y coordinate of second point { ");
            a2 = Convert.ToDouble(Console.ReadLine());
            b2 = Convert.ToDouble(Console.ReadLine());

            double a = (a2 - a1) * (a2 - a1);
            double b = (b2 - b1) * (b2 - b1);
            double sum1 = a + b;
            result2 = Math.Sqrt(sum1);
            Console.WriteLine("Length of Second line is {0}", result2);

            //bool Compare = result1.Equals(result2);
            //Console.WriteLine("Lines are equal:-{0}", Compare);

            if(result1>result2)
            {
                Console.WriteLine("First line is greater than second line");
            }
            else if(result2>result1)
            {
                Console.WriteLine("Second Line is greater than First");
            }
            else
            {
                Console.WriteLine("Both lines are equal");
            }

        }
    }
}

