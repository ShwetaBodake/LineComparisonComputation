namespace LineComparisonComputation
{
class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Line Comparison Computation Program");
            //Console.ReadLine();
            double x1, x2, y1, y2, result;
            Console.WriteLine("Enter the x and y coordinate of first point { ");
             x1=Convert.ToDouble(Console.ReadLine());
             y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the x and y coordinate of second point { ");
             x2 = Convert.ToDouble(Console.ReadLine());
             y2 = Convert.ToDouble(Console.ReadLine());

            double x = (x2 - x1) * (x2 - x1);
            double y=(y2-y1)*(y2-y1);
            double sum = x + y;
            result = Math.Sqrt(sum);
            Console.WriteLine("Length of line is {0}", result);

        }
    }
}

