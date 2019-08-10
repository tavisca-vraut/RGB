using System;

namespace RGB
{
    class Program
    {
        int GetLeast(string[] picture)
        {
            if (Matrix.IsEmpty(picture)) return 0;

            var horizontalCount = LineFinder.CountHorizontal((string[])picture.Clone(), "R");
            var verticalCount = LineFinder.CountHorizontal(Matrix.Transpose(picture), "B");

            return horizontalCount + verticalCount;
        }

        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            Program rgbSolver = new Program ();
            do
            {
                string[] picture = input.Split(',');
                Console.WriteLine(rgbSolver.GetLeast(picture));
                input = Console.ReadLine();
            } while (input != "-1");
        }
    }
}
