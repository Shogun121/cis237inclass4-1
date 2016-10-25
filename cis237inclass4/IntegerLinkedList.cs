﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class IntegerLinkedList : IIntegerLinkestList
    {
        //This is an inner class. It will serve as our Node class for the linked list.
        //Because it is an inner class, it can't be used outside the class, which is okay,
        //since we don't need it anywhere else but here.
        protected class Node
        {
            //NOde has 2 properties. Data, to store the data.
            //and Next, to point to the next node in the list.
            public int Data { get; set; }
            public Node Next { get; set;}
        }

        //Head and Tail to point to the beginning and the end of the list nodes.
        protected Node _head;
        protected Node _tail;
        protected int _size;        //Does this really need an explanation?
        //Check to see if the head is null. If the head pointer is null, there is nothing in the list.
        public bool IsEmpty
        {
            get
            {
                return _head == null;
            }
        }

        //Get the size by returning the backing field's value.
        public int Size
        {
            get
            {
                return _size;
            }
        }

        public void AddToBack(int IntegerData)
        {
            //Create a new node that points to the same location as the tail.
            Node oldTail = _tail;
            //Create a new node and put it in the tail variable.
            _tail = new Node();
            //Set the data
            _tail.Data = IntegerData;
            //Set the next to null since this is the last node.
            _tail.Next = null;
            //We can check to see if the list is empty. Empty is the head pointing to null.
            //Since on an initial add, adding is done to the tail, 
            //head is still null. We want head and tail to point to the same first node.
            //Therefore the list is empty, just set the head equal to the tail.
            if(IsEmpty)
            {
                _head = _tail;
            }
            //Otherwise, this is not an initial add. It is with an established list
            //so we just need to set the oldTail's next pointer to the new tail we created.
            else
            {
                oldTail.Next = _tail;

            }
            //Don't forget to increase the size of the linked list.
            _size++;
        }

        public void AddToFront(int IntegerData)
        {
            //Make a new pointer named OldName that points tot he same place as the head variables points to.
            Node oldHead = _head;
            //Create  a new node and store it in the head variabe.
            _head = new Node();
            //Set the data on the new node
            _head.Data = IntegerData;
            //Set the next property to the oldHead.
            _head.Next = oldHead;
            //Increase the size
            _size++;
            //If the size is equal to one, which means one node only.
            //The head and the tail are the same, so let's set them that way.
            if(_size==1)
            {
                _tail=_head;
            }
        }

        public void Display()
        {
            if(IsEmpty)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                Console.WriteLine("The list is: ");
                //Define a node that starts pointing at the same place as head.
                Node current = _head;
                //While the current pointer is not null.
                //Being null would suggest that it is now pointing at a location that is past, or at the end of the list.
                while(current!=null)
                {
                    //Write out the data.
                    Console.Write(current.Data+", ");
                    //Move the current pointer to the next node in the list.
                    //We can accomplish this by taking the pointer that is in the current node's next property.
                    //and assigning it to the current variable.
                    current = current.Next;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        //This one takes more work than the other 3.
        //Keep this in minf for the assignment.
        public int RemoveFromBack()
        {
            if(IsEmpty)
            {
                throw new Exception("The list is empty");
            }
            //Get the data from the tail node. This is what we will return.
            int returnData = _tail.Data;

            //If we are in a situation where there is only one node, and we try to remove it.
            //Just set head and tail equal to null. (Remove all reference to the node).
            if(_head==_tail)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                //Create a current node and start it at head. Just like in the display method.
                //This way we can 'walk' the list.
                Node current = _head;

                //While current's next property is not equal to the tail.
                //Which means, while we are not at the node right before the tail.
                while (current.Next != _tail)
                {
                    current = current.Next;
                }
                //When we get there, we will just set tail to the current node we are at.
                _tail = current;

                //Set the next property of current to null so the last node that was just removed has
                //no references pointing to it.
                current.Next = null;
            }
            

            //Return the return data.
            return returnData;
        }

        public int RemoveFromFront()
        {
            if (IsEmpty)
            {
                throw new Exception("List is empty");
            }
            //Get out the data that needs to be returned.
            int returnData = _head.Data;

            //Move the head to the nxt node in the list.(Next property)
            _head = _head.Next;

            /**
             * Now that there are no variables that point to where the old head is
             * the garbage collector can clean it up
             * */

            //Decrement the size
            _size--;

            //Check to see if we just removed the last node in the list.
            //If so, we want to set tail to null as well.
            if (IsEmpty)
            {
                _tail = null;
            }

            //return the returnData
            return returnData;
        }
        //COnstructor
        public IntegerLinkedList()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }
    }
}
