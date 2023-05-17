using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    public class StackDemo
    {
        public void StackMethod()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(11);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine("Push element in stack :"); //=>30,20,11,10
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Pop element :" + stack.Pop());
            Console.WriteLine("Peek element :" + stack.Peek());
        }
    }
}
