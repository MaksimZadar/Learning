// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Selection Sort");

Console.WriteLine("Starting array: ");
int Min = 0;
int NumOfNumbers = 20000;

int[] array = new int[NumOfNumbers]; 

Random randNum = new();
for (int i = 0; i < array.Length; i++)
{
    array[i] = randNum.Next(Min, NumOfNumbers);
}

foreach (var num in array)
{
    Console.Write($"{num} ");
}
Console.WriteLine();


Console.WriteLine("Sorting...");
var watch = new Stopwatch();
watch.Start();
for (int i = 0; i < array.Length; i++)
{
    var smallest = array[i];
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < smallest) {
            smallest = array[j];
            array[j] = array[i];
            array[i] = smallest;
        }
    }
}
watch.Stop();
Console.WriteLine("New Array: ");
foreach (var num in array)
{
    Console.Write($"{num} ");
}
Console.WriteLine();
Console.WriteLine($"Took: {watch.ElapsedMilliseconds}ms");