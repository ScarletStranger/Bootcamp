using static ArrayCreator;
using static ArraySum;
using System.Diagnostics;

int[] array = 50000.CreateOneDimensionArray()
.Fill(1, 10);
//array.ConvertToStringAndprintToTerminal();

int m = 1000;
Stopwatch sw = new Stopwatch();
sw.Start();

int max = array.BadGetSum(m);
sw.Stop();

Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
max = array.GoodGetSum(m);
sw.Stop();
Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");