namespace LineComparisonComputation
{
class Program
    {
        public static void Main(string[] args)
        {
            Lcomparison(10, 20, 30, 40, 5, 6, 7, 8);
        }

        public static double Lcomparison(double x1,double y1,double x2,double y2,double a1,double b1,double a2,double b2)
        {
            Console.WriteLine("WelCome to Line Comparison Computation Program");
            double x = Math.Pow(x2 - x1, 2);
            double y = Math.Pow(y2 - y1, 2);
            double sum = x + y;
           double result1 = Math.Sqrt(sum);
            Console.WriteLine("Length of first line is {0}", result1);

             double a = Math.Pow(a2 - a1, 2);
            double b = Math.Pow(b2 - b1, 2);
            double sum1 = a + b;
            double result2 = Math.Sqrt(sum1);
            Console.WriteLine("Length of Second line is {0}", result2);

           int result = result1.CompareTo(result2);
            if (result>0)
            {
                Console.WriteLine("First line is greater than second line");

            }
            else if (result <0)
            {
                Console.WriteLine("Second Line is greater than First");

            }
            else
            {
               Console.WriteLine("Both lines are equal");

            }
            return result;
            //double Compare = result1.Equals(result2);
            //Console.WriteLine("Lines are equal:-{0}", Compare);
            //return Compare;
        }
    }
}

