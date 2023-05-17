using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    public class QueueDemo
    {
        public void QueueMethod()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(21);
            queue.Enqueue(61);
            queue.Enqueue(132);
            var remove = queue.Dequeue(); // it wil remove first element from queue
            Console.WriteLine(remove);
            foreach (var item in queue)
            {
                Console.WriteLine("Add :" + item);
            }
            //Console.WriteLine("Peek........");
            //queue.Dequeue();
            //foreach (var items in queue)
            //{
            //    Console.WriteLine("Remove :" + items);
            //}
            Console.WriteLine("Peek :" + queue.Peek());
            // value is presenet or not.................
            Console.WriteLine("Conatins :" + queue.Contains(31));

            //Generic help to......


        }
        public void GenericQueMethod()
        {
            Queue<int> queueGen = new Queue<int>();
            queueGen.Enqueue(189);
            queueGen.Enqueue(27);
            queueGen.Enqueue(31);
            queueGen.Enqueue(46);
            var deq = queueGen.Dequeue();
            Console.WriteLine("Remove:" + deq);

            foreach (var Gitem in queueGen)
            {
                Console.WriteLine(Gitem);
            }

        }
    }
}
