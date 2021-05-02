using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============  LINKED LIST DATA STRUCTURE  =================");


            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();

            Console.WriteLine("\nINSERT AT PERTICULAR POSITION");
            linkedList.InsertAtParticularPosition(2, 100);
            linkedList.InsertAtParticularPosition(3, 300);
            linkedList.InsertAtParticularPosition(4, 400);
            linkedList.Display();

            linkedList.RemoveFirstNode();
            linkedList.Display();

            linkedList.RemovaLastNode();
            linkedList.Display();

            linkedList.Search(30);
            linkedList.Display();

            Console.ReadKey();
        }
    }
}
