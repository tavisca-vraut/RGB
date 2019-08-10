using System;

namespace RGB
{
    class Program
    {
        int row_count(string[] picture)
        {
            for(int i = 0; i < picture.Length; i++)
            {
                picture[i] = picture[i].Replace('G', 'R');
            }

            int count = 0;

            for(int i = 0; i < picture.Length; i++)
            {
                for (int j = 0; j < picture[0].Length; j++)
                {
                    if (picture[i][j] == 'R' && (j == 0 || (picture[i][j - 1] != 'R')))
                        count++;
                }
            }
            return count;
        }

        int column_count(string[] picture)
        {
            for (int i = 0; i < picture.Length; i++)
            {
                picture[i] = picture[i].Replace('G', 'B');
            }
            int count = 0;
            for (int i = 0; i < picture.Length; i++)
            {
                for (int j = 0; j < picture[0].Length; j++)
                {
                    if (picture[i][j] == 'B' && (i == 0 || (picture[i-1][j] != 'B')))
                        count++;
                }
            }
            return count;
        }

        int GetLeast(string[] picture)
        {
            if (picture.Length == 0) return 0;

            return column_count((string[])picture.Clone()) + row_count(picture);
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
