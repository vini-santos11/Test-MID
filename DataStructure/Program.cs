namespace DataStructure;

public class Program {
    static void Main() 
    {
        Stack<int> stack = new Stack<int>();

        Console.WriteLine("Is stack empty? " + stack.IsEmpty()); 

        stack.Push(1);

        Console.WriteLine("Is stack empty? " + stack.IsEmpty()); 

        Console.WriteLine(stack.Pop()); 
    }
}