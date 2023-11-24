Console.WriteLine("Stack Implementation");

var stack = new Stack<int>();
stack.Push(0, 1, 2, 4, 5, 6, 7);
stack.DisplayStack();
Console.WriteLine("Popping...");
Console.WriteLine($"Popped: {stack.Pop()}");
stack.DisplayStack();
Console.WriteLine("Pushing onto stack...");
stack.Push(1);
stack.DisplayStack();

public class Stack<T>
{
	private List<T> _stack = new();
	public Stack() { }

	public void Push(T newItem)
	{
		_stack = _stack.Prepend(newItem).ToList();
	}

	/// <summary>
	/// Pushes items in order from left to right (so first arg is at the bottom of the stack)
	/// </summary>
	/// <param name="newItems"></param>
	public void Push(params T[] newItems)
	{
		for (int i = 0; i < newItems.Length; i++)
		{
			_stack = _stack.Prepend(newItems.ElementAt(i)).ToList();
		}
	}

	public T Pop()
	{
		var item = _stack.ElementAt(0);
		_stack.RemoveAt(0);
		return item;
	}

	public void DisplayStack() {
		Console.WriteLine("Displaying Stack...");
		foreach (var item in _stack)
		{
			Console.WriteLine(item);
		}
		Console.WriteLine();
	}

}
