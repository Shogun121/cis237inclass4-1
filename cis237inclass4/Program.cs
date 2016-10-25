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
        }
    }
}
