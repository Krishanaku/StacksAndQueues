using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            //Queues ....................................
            //QueueDemo queueDemo = new QueueDemo();
            ////queueDemo.QueueMethod();
            //queueDemo.GenericQuemethod();
            //Console.ReadLine();

            //
            //QueuePract queuePract = new QueuePract();
            //queuePract.EnqueueMethod(40);
            //queuePract.EnqueueMethod(50);
            //queuePract.EnqueueMethod(60);
            //queuePract.DequeueMethod();
            //queuePract.Display();
            //Console.ReadLine();

            //StackDemo stack = new StackDemo();
            //stack.StackMethod();
            //Console.ReadLine();

            StackPrac stack = new StackPrac();
            stack.PushM(10);
            stack.PushM(20);
            stack.PushM(30);
            stack.PeekMethod();
            stack.PopM();
            stack.Display();
            Console.ReadLine();
        }
    }
}
