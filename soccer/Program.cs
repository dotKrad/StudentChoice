using System.Text.RegularExpressions;

const string filename = "football.dat";
// Read the file and display it line by line.  
int spread;
string name = "";

int max;
int min;

int minDiff = int.MaxValue;

/*
 * 1 - name
 * 2 - F
 * 3 - A
 */
var regex = new Regex(@"^\s*\d+\.\*?\s*([\w|_]+)\*?\s*[\w ]{20,20}(\d+)\s+\-\s+(\d+).*");




foreach (string line in File.ReadLines(filename))
{
    var match = regex.Match(line);
    if (match.Success)
    {
        min = int.Parse(match.Groups[3].ToString());
        max = int.Parse(match.Groups[2].ToString());
        spread = Math.Abs(max - min);


        //Console.WriteLine($"{match.Groups[1]} {min} {max} {spread}");

        if (spread < minDiff)
        {
            minDiff = spread;
            name = match.Groups[1].ToString();
        }
    }


}
Console.WriteLine(name);