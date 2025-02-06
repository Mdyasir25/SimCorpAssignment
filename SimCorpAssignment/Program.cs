namespace SimCorpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("Enter the length of the sides of the triangle in space separated manner:");
                try
                {
                    string input = Console.ReadLine();
                    float[] sides = input.Split().Select(float.Parse).ToArray();

                    if (sides.Length != 3)
                    {
                        Console.WriteLine("Invalid number of sides");
                        return;
                    }
                    if (sides[0]<=0 || sides[1]<=0 || sides[2]<=0)
                    {
                        Console.WriteLine("Invalid triangle: Length of a side cannot be non-positive");
                        stop = WantToStop();
                        continue;
                    }

                    float perimeter = sides.Sum();
                    float maxSide = sides.Max();

                    if (maxSide > perimeter - maxSide)
                    {
                        Console.WriteLine("Invalid triangle: Length of a side cannot be greater than sum of length of the other two sides");
                        stop = WantToStop();
                        continue;
                    }

                    if (sides[0] == sides[1] && sides[0] == sides[2])
                    {
                        Console.WriteLine("Equilateral Triangle");
                    }
                    else if (sides[0] != sides[1] && sides[1] != sides[2] && sides[2] != sides[0])
                    {
                        Console.WriteLine("Scalene Triangle");
                    }
                    else
                    {
                        Console.WriteLine("Isosceles Triangle");
                    }
                    stop = WantToStop();  
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    stop = WantToStop();
                }
            }
        }
        public static bool WantToStop()
        {
            Console.Write("Press 0 to stop: ");
            if (Console.ReadLine() == "0") return true;
            Console.WriteLine("*********************************************************");
            return false;
        }
    }
}
