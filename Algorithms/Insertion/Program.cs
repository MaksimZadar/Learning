// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Insertion Algorithm");

Console.WriteLine("Starting array: ");
int Min = 0;
int NumOfNumbers = 100000;

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
Console.WriteLine("Sorting...");
var watch = new Stopwatch();
watch.Start();
for (int i = 1; i < array.Length; i++)
{
    var key = array[i];
    var j = i - 1;
    while (j >= 0 && array[j] > key)
    {
        array[j+1] = array[j];
        j--;
    }
    array[j + 1] = key;
}
watch.Stop();

Console.WriteLine("New Array: ");
foreach (var num in array)
{
    Console.Write($"{num} ");
}
Console.WriteLine();
Console.WriteLine($"Took: {watch.ElapsedMilliseconds}ms");
