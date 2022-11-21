
using System.Text.RegularExpressions;

const string filename = "weather.dat";
int counter = 0;

// Read the file and display it line by line.  
double spread;
int foundAt = 0;

double max;
double min;

double minSpread = double.MaxValue;

var regex = new Regex(@"^\s*(\d+)\*?\s*(\d+)\*?\s*(\d+).*");




foreach (string line in File.ReadLines(filename))
{
    counter++;
    //skipping 1st and 2nd lines
    if (counter <= 2)
        continue;


    var match = regex.Match(line);
    if (match.Success)
    {
        min = double.Parse(match.Groups[3].ToString());
        max = double.Parse(match.Groups[2].ToString());
        spread = max - min;


        //Console.WriteLine($"{match.Groups[1]} {min} {max} {spread}");

        if (spread < minSpread)
        {
            minSpread = spread;
            foundAt = int.Parse(match.Groups[1].ToString());
        }
    }


}
Console.WriteLine(foundAt);
