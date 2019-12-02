  using System;
  public class SinglyLinkedList {
      public SllNode Head;
      public void AddToBack (int value) {
          SllNode newNode = new SllNode (value);
          if (Head == null) {
              Head = newNode;

          } else {
              SllNode runner = Head;
              while (runner.Next != null) {
                  runner = runner.Next;
              }
              runner.Next = newNode;
              System.Console.WriteLine (newNode.Value);
              System.Console.WriteLine (newNode.Next);
          }
      }
      public void AddToFront (int value) {
          SllNode newNode = new SllNode (value);
          if (Head == null) {
              Head = newNode;
          } else {
              var Newhead = Head;
              Head = newNode;
              Head.Next = Newhead;
          }
      }
      public void FindVal (int x) {
          System.Console.WriteLine ("Find value " + x);
          if (Head == null) {
              System.Console.WriteLine ("Sll is Empty");
          } else {
              SllNode runner = Head;
              Boolean check = false;
              while (runner != null) {
                  if (runner.Value == x) {
                      System.Console.WriteLine ("Found the value : Node " + runner.Value);
                      check = true;
                      break;
                  }
                  runner = runner.Next;
              }
              if (!check) {
                  System.Console.WriteLine (" Value Not Found");
              }

          }
      }
      public void RemoveFromBack () {
          if (Head == null) {
              System.Console.WriteLine ("SLL is empty");
          } else {
              SllNode runner = Head;
              if (runner.Next == null) {
                  Head = runner.Next;
                  System.Console.WriteLine ("Head delted");
              } else {
                  while (runner != null) {
                      if (runner.Next.Next == null) {
                          runner.Next = null;
                          System.Console.WriteLine ("Remove Value: " + runner.Value + " , Next: " + runner.Next);
                      }
                      runner = runner.Next;
                  }
              }
          }
      }
      public void RemoveAt (int x) {
          if (Head == null) {
              System.Console.WriteLine ("SLL is empty");
          }
          System.Console.WriteLine ("x: " + x);
          var count = 0;
          SllNode runner = Head;
          if (x == count) {
              var Newhead = Head.Next;
              Head.Next = null;
              Head = Newhead;
              System.Console.WriteLine (Head.Value);
          } else {
              var previous = runner;
              while (runner.Next != null) {
                  count++;
                  runner = runner.Next;
                  previous = runner.Next;

                  if (count == x) {
                      if (runner.Next.Next == null) {
                          runner.Next = null;
                      } else {
                          previous.Next = runner.Next.Next;
                      }
                  }
              }
              if (x > count) {
                  System.Console.WriteLine (x + " Not Available");
              }
          }
      }
      public void RemoveFromFront () {
          if (Head == null) {
              System.Console.WriteLine ("SLL is empty");
          } else {
              var Newhead = Head.Next;
              Head.Next = null;
              Head = Newhead;
          }
      }

      public void print () {
          System.Console.WriteLine ("******************************");
          var count = 0;
          if (Head == null) {
              Console.WriteLine ("SLL is empty");
          } else {
              SllNode runner = Head;

              System.Console.WriteLine ("Head: " + runner.Value + " , Next: " + runner.Next);
              while (runner.Next != null) {
                  runner = runner.Next;
                  count++;
                  System.Console.WriteLine ("Value: " + runner.Value + " , Next: " + runner.Next);
              }
              System.Console.WriteLine ("SLL Length is: " + count);
              System.Console.WriteLine ("******************************");
          }
      }
  }