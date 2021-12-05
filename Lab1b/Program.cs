using Lab1;
using Lab1b;

IGetStringReader dataReader = new FileDataReader();

ReadFileReverseIt readFileReverseIt = new(dataReader);
string result = readFileReverseIt.Start();

Console.WriteLine(result);