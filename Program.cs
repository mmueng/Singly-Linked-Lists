using System;
using System.Collections.Generic;
namespace singly_linked_lists {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Singly Linked Lists");
            SinglyLinkedList ssl = new SinglyLinkedList ();
            ssl.AddToBack (5);
            ssl.AddToBack (6);
            ssl.AddToBack (7);
            // ssl.AddToFront (4);
            // ssl.AddToFront (2);
            ssl.print ();
            ssl.RemoveFromBack ();
            ssl.RemoveFromBack ();
            ssl.print ();
            ssl.RemoveFromBack ();
            // ssl.RemoveFromFront ();
            // ssl.RemoveFromFront ();
            // ssl.FindVal (2);
            // ssl.FindVal (4);
            // ssl.FindVal (6);
            // ssl.FindVal (8);
            ssl.print ();
            // ssl.RemoveFromBack ();
            //     ssl.RemoveAt (0);
            //     ssl.print ();
            //     ssl.RemoveAt (1);
            //     ssl.print ();
        }
    }

}