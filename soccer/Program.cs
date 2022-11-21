using SharedFunctions;

const string filename = "football.dat";
// Read the file and display it line by line.  


/*
 * 1 - name
 * 2 - F
 * 3 - A
 */
const string pattern = @"^\s*\d+\.\*?\s*([\w|_]+)\*?\s*[\w ]{20,20}(\d+)\s+\-\s+(\d+).*";

var result = Functions.GetSmallestDifference(filename, pattern, 3, 2, 1);


Console.WriteLine(result);