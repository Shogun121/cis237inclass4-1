using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            IIntegerLinkestList myLinkeedList = new IntegerLinkedList();

            myLinkeedList.AddToFront(5);
            myLinkeedList.AddToFront(4);
            myLinkeedList.AddToFront(3);

            myLinkeedList.AddToBack(6);
            myLinkeedList.AddToBack(7);
            myLinkeedList.AddToBack(8);

            myLinkeedList.Display();


            //Her is a gernic linked list that stores strings.
            IGenericLinkedList<string> myGenericLinkedList = new GenericLinkedList<string>();

            //Here is a gerneric linked list that stores any class that implements the IComparable interface.
            IGenericLinkedList < IComparable > myComparableLinkedList = new GenericLinkedList<IComparable>();

            //Let's use the string one.
            myGenericLinkedList.AddToFront("Foo");
            myGenericLinkedList.AddToFront("Dave");
            myGenericLinkedList.AddToFront("Bar");
            myGenericLinkedList.AddToFront("Barnes");

            myGenericLinkedList.AddToBack("Back 3");
            myGenericLinkedList.AddToBack("Back 2");
            myGenericLinkedList.AddToBack("Back 1");

            myGenericLinkedList.Display();

            string frontGuy = myGenericLinkedList.RemoveFromFront();

            Console.WriteLine(frontGuy);

            myGenericLinkedList.Display();
        }
    }
}
