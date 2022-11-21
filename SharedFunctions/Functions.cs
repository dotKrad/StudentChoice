using System.Text.RegularExpressions;

namespace SharedFunctions
{
    public static class Functions
    {
        /// <summary>
        /// Reads a data file and calculate the minimun diference between two columns from each line of the file
        /// </summary>
        /// <param name="filename">Data file to read</param>
        /// <param name="pattern">Pattern to match</param>
        /// <param name="minGroup">Group index to use as a min value</param>
        /// <param name="maxGroup">Group index to use as a max value</param>
        /// <param name="returnGroup">Group index to use as a return value</param>
        /// <returns>A desired colum from the line where the minimun diference was found</returns>
        public static string GetSmallestDifference(string filename, string pattern, int minGroup, int maxGroup, int returnGroup)
        {
            int spread;
            string result = "";

            int max;
            int min;

            int minDiff = int.MaxValue;

            var regex = new Regex(pattern);

            foreach (string line in File.ReadLines(filename))
            {
                var match = regex.Match(line);
                if (match.Success)
                {
                    min = int.Parse(match.Groups[minGroup].ToString());
                    max = int.Parse(match.Groups[maxGroup].ToString());
                    spread = Math.Abs(max - min);


                    //Console.WriteLine($"{match.Groups[1]} {min} {max} {spread}");

                    if (spread < minDiff)
                    {
                        minDiff = spread;
                        result = match.Groups[returnGroup].ToString();
                    }
                }


            }

            return result;
        }
    }
}