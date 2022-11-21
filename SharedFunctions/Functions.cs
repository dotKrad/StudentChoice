using System.Text.RegularExpressions;

namespace SharedFunctions
{
    public static class Functions
    {

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