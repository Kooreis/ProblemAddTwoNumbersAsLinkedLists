Here is a C# console application that solves the problem:

```CSharp
using System;

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
}

public class LinkedList
{
    public Node Head { get; set; }

    public void Add(int value)
    {
        Node newNode = new Node { Value = value };
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list1 = new LinkedList();
        list1.Add(2);
        list1.Add(4);
        list1.Add(3);

        LinkedList list2 = new LinkedList();
        list2.Add(5);
        list2.Add(6);
        list2.Add(4);

        LinkedList result = AddTwoNumbers(list1, list2);

        Node current = result.Head;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
    }

    static LinkedList AddTwoNumbers(LinkedList l1, LinkedList l2)
    {
        LinkedList result = new LinkedList();
        Node current1 = l1.Head;
        Node current2 = l2.Head;
        int carry = 0;

        while (current1 != null || current2 != null)
        {
            int sum = carry;
            if (current1 != null)
            {
                sum += current1.Value;
                current1 = current1.Next;
            }
            if (current2 != null)
            {
                sum += current2.Value;
                current2 = current2.Next;
            }
            result.Add(sum % 10);
            carry = sum / 10;
        }

        if (carry > 0)
        {
            result.Add(carry);
        }

        return result;
    }
}
```