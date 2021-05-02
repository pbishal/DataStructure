using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class LinkedList
    {
        internal Node head; //new 

        /// <summary>
        /// Adding nodes from begining
        /// </summary>
        /// <param name="data"></param>
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
            Console.WriteLine();
        }

        /// <summary>
        /// Display the all nodes.
        /// </summary>
        internal void Display()
        {
            Console.WriteLine("=====Read from left to right =====>>>>\n");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; //temp=null
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Insert a node at particular position.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (position-- != 0) //
                {

                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    temp = temp.next;//1000
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }

        /// <summary>
        /// Delete a node from first position.
        /// </summary>
        /// <returns></returns>
        internal Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

        /// <summary>
        /// Delete a node from last position.
        /// </summary>
        /// <returns></returns>
        internal Node RemovaLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        /// <summary>
        /// search a particular node.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        internal Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }
    }
}
