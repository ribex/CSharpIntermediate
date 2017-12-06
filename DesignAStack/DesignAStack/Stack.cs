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
}