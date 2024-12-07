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