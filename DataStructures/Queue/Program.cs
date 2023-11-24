// See https://aka.ms/new-console-template for more information
Console.WriteLine("Queue");
var queue = new Queue<int>();
queue.Push(1, 2, 3);
queue.DisplayAll();

Console.WriteLine($"Popped: {queue.Pop()}");
queue.DisplayAll();

queue.Push(5);
queue.DisplayAll();

public class Queue<T>
{
    private List<T> _queue = new();

    public Queue() { }

    public void Push(T item)
    {
        _queue = _queue.Append(item).ToList();
    }

    public void Push(params T[] items)
    {
        foreach (var item in items)
        {
            _queue = _queue.Append(item).ToList();
        }
    }

    public T Pop()
    {
        var item = _queue.First();
        _queue.RemoveAt(0);
        return item;
    }

    public void DisplayAll() {
        Console.WriteLine("Current Queue");
        foreach (var item in _queue)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
