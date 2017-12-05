using System;
using System.Collections;

namespace DesignAStack
{
    public class Stack
    {
        private readonly ArrayList _stack = new ArrayList();
       
        public void Push(object obj)
        {
            if (obj != null)
            {
                _stack.Add(obj);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public object Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var popped = _stack[_stack.Count - 1];
            _stack.Remove(popped);
            return popped;
        }

        public void Clear()
        {
            _stack.Clear();
        }

    }

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
