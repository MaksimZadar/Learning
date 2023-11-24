using System.Dynamic;

Console.WriteLine("============= Linked Lists =============");

Console.WriteLine("Current nodes...");
Node<int> node2 = new(2);
Node<int> node1 = new(1, node2);
var linkedList = new LinkedList<int>(node1);
linkedList.DisplayAllNodes();

Console.WriteLine("Adding new node at end...");
Node<int> newNode = new(3);
linkedList.InsertAtEnd(newNode);
linkedList.DisplayAllNodes();


Console.WriteLine("Adding new node at start...");
newNode = new(0);
linkedList.InsertAtStart(newNode);
linkedList.DisplayAllNodes();

Console.WriteLine("Insert at index 1...");
newNode = new(5);
linkedList.InsertAt(1, newNode);
linkedList.DisplayAllNodes();

Console.WriteLine("Insert at index 3...");
newNode = new(6);
linkedList.InsertAt(3, newNode);
linkedList.DisplayAllNodes();

Console.WriteLine("Gettting node at index 4...");
var nodeAt4 = linkedList.GetNodeAtIndex(4);
Console.WriteLine(nodeAt4.Data);

Console.WriteLine("Getting last node...");
var lastNode = linkedList.GetLastNode();
Console.WriteLine(lastNode.Data);

Console.WriteLine("Reversing nodes...");
linkedList.ReverseList();
linkedList.DisplayAllNodes();

class Node<T>
{
    public T Data { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T data, Node<T>? next)
    {
        Data = data;
        Next = next;
    }
    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList<T>
{
    public Node<T> Head { get; set; }
    private int _length = 0;

    public LinkedList(Node<T> headNode)
    {
        Head = headNode;
        _length++;
    }

    public int Length()
    {
        return _length;
    }

    public void DisplayAllNodes()
    {
        Node<T> current = Head;

        while (current.Next != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }

        Console.WriteLine(current.Data);
    }

    public void InsertAtEnd(Node<T> newNode)
    {
        var lastNode = GetLastNode();
        lastNode.Next = newNode;
        _length++;
    }

    public void InsertAtStart(Node<T> newNode)
    {
        var firstNode = Head;
        newNode.Next = firstNode;
        Head = newNode;
        _length++;
    }

    public void InsertAt(int index, Node<T> newNode)
    {
        if (index > _length)
        {
            InsertAtEnd(newNode);
            return;
        }

        if (index <= 0)
        {
            InsertAtStart(newNode);
            return;
        }

        var previousIndex = index - 1;
        var i = 0;
        Node<T> cur = Head;
        while (i < previousIndex)
        {
            cur = cur.Next!;
            i++;
        }

        newNode.Next = cur.Next;
        cur.Next = newNode;
        _length++;
    }

    public Node<T> GetNodeAtIndex(int index)
    {
        if (index > _length) return GetLastNode();

        int i = 0;
        Node<T> cur = Head;
        while (i < index)
        {
            cur = cur.Next!;
            i++;
        }

        return cur;
    }

    public Node<T> GetLastNode()
    {
        var temp = Head;

        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        return temp;
    }

    public void ReverseList()
    {
        if (Head.Next is null) return;

        Node<T>? prev = null;
        Node<T>? cur = Head;
        Node<T>? oldNext = null;

        while (cur is not null)
        {
            oldNext = cur.Next;
            cur.Next = prev;
            prev = cur;
            cur = oldNext;
        }
        if (prev is null) return;
        Head = prev;
    }
}
