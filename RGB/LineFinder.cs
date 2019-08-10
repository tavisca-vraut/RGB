namespace RGB
{
    public class LineFinder
    {
        public static string CommonCombined = "G";
        public static int CountHorizontal(string[] matrix, string identifier)
        {
            matrix = Matrix.ReplaceAll(matrix, "G", identifier);

            int lineCount = 0;
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    bool currentElementIsBeingOperatedOn = matrix[i][j].ToString() == identifier;
                    if (currentElementIsBeingOperatedOn &&
                        StartOfNewLine(matrix, identifier, i, j))
                        lineCount++;
                }
            }
            return lineCount;
        }

        private static bool StartOfNewLine(string[] matrix, string identifier, int i, int j)
        {
            return (j == 0 || (matrix[i][j - 1].ToString() != identifier));
        }
    }
}
