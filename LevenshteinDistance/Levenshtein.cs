namespace LevenshteinDistance
{
    public static class Levenshtein
    {
        public static int GetDistance(string first, string second)
        {
            int[,] matrix = new int[first.Length, second.Length];

            for (int i = 1; i < first.Length; i++)
            {
                matrix[i, 0] = i;
            }

            for (int j = 1; j < second.Length; j++)
            {
                matrix[0, j] = j;
            }

            for (int j = 1; j < second.Length; j++)
            {
                for (int i = 1; i < first.Length; i++)
                {
                    int cost = first[i - 1] == second[j - 1] ? 0 : 1;

                    matrix[i, j] = min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1, matrix[i - 1, j - 1] + cost);
                }
            }

            return matrix[first.Length - 1, second.Length - 1];
        }

        private static int min(int a, int b, int c)
        {
            int minAB = a < b ? a : b;

            return minAB < c ? minAB : c;
        }
    }
}
