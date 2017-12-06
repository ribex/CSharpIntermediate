using System;

namespace DesignAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            // stack.Clear();
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Push(4);
            stack.Push(5);

            Console.WriteLine(stack.Pop());

            stack.Clear();

            stack.Push(6);
            Console.WriteLine(stack.Pop());

            // output:
            // 3
            // 2
            // 1
            // 5
            // 6
        }
    }
}
