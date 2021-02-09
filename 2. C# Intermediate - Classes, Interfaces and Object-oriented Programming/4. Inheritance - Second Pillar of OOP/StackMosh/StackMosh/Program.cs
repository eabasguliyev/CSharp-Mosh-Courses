using System;

namespace StackMosh
{
    public class Stack
    {
        public object[] Data { get; private set; }


        public void Push(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj), "Object is null!");

            var newLength = (Data != null) ? Data.Length + 1 : 1;

            var tmp = new object[newLength];

            if (tmp.Length != 0)
            {
                if(Data != null)
                    Array.Copy(Data, tmp, Data.Length);

                tmp[newLength - 1] = obj;
            }

            Data = tmp;
        }

        public object Pop()
        {
            if (Data == null)
                throw new InvalidOperationException("There is no data in the stack!");

            var newLength = Data.Length - 1;
            var tmp = new object[newLength];

            if (tmp.Length != 0)
            {
                Array.Copy(Data, tmp, newLength);
            }
            else
            {
                tmp = null;
            }

            var removedObj = Data[Data.Length - 1];
            Data = tmp;

            return removedObj;
        }

        public void Clear() => Data = null;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push("sal");
            stack.Push('a');
            //stack.Push(null);

            Console.WriteLine(stack.Data.Length);

            stack.Clear();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
        }
    }
}
