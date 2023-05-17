using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    public class StackPrac
    {
        public Node top;
        public StackPrac()
        {
            top = null;
        }
        public void PushM(int value)
        {
            Node node = new Node(value);
            if (top == null)
            {
                node.next = null;

            }
            else
            {
                node.next = top;
            }
            top = node;
            Console.WriteLine("Push element :" + value);
        }
        public void PeekMethod()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");

            }
            Console.WriteLine("Peek :" + this.top.data);

        }
        public void PopM()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");

            }
            Console.WriteLine("Pop :" + this.top.data);
            this.top = this.top.next;


        }

        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
