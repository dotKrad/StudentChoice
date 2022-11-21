
using SharedFunctions;

const string filename = "weather.dat";

var pattern = @"^\s*(\d+)\*?\s*(\d+)\*?\s*(\d+).*";


var result = Functions.GetSmallestDifference(filename, pattern, 3, 2, 1);

Console.WriteLine(result);
