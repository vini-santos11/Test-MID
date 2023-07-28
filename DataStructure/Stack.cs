namespace DataStructure;

public class Stack<T> 
{
    private class Node 
    {
        public T Data;
        public Node Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node top;

    public void Push(T item) {
        Node newNode = new Node(item);
        newNode.Next = top;
        top = newNode;
    }

    public T Pop() 
    {
        if (IsEmpty()) {
            throw new InvalidOperationException("Stack is empty");
        }

        T item = top.Data;
        top = top.Next;
        return item;
    }

    public bool IsEmpty() {
        return top == null;
    }
}