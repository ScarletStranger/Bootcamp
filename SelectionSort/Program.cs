using static ArrayCreator;
using static Sorting;
using System.Diagnostics;

int[] array = 100.CreateOneDimensionArray().Fill(1, 100);


array.ConvertToStringAndprintToTerminal();
Stopwatch sw = new Stopwatch();

sw.Start();
array.SortCounting();
sw.Stop();
array.ConvertToStringAndprintToTerminal();
Console.WriteLine($"SortCounting: {sw.ElapsedMilliseconds}");


