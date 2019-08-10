using System.Text;

namespace RGB
{
    public class Matrix
    {
        public static string[] Transpose(string[] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            string[] newMatrix = new string[cols];
            for (int i = 0; i < cols; i++)
            {
                var temp = new StringBuilder();
                for (int j = 0; j < rows; j++)
                    temp.Append(matrix[j][i]);
                newMatrix[i] = temp.ToString();
            }
            return newMatrix;
        }

        public static string[] ReplaceAll(string[] matrix, string original, string @new)
        {
            for (int i = 0; i < matrix.Length; i++) 
                matrix[i] = matrix[i].Replace(original, @new);

            return matrix;
        }

        public static bool IsEmpty(string[] matrix) => matrix.Length == 0;
    }
}
