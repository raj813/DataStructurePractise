using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//*
//LinkedList :
//Detect Loop
//Find sarting of loop
//Delete loop
//*//

namespace practiseDemo
{
    public class LinkedList
    {
        public Node head;

        public class Node
        {

            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }



        public Node detectCycle(Node head)
        {
            Node slow = head;
            Node fast = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    return slow;
                }
            }
            return null;
        }

        public Node findFirstNodeandDelete(Node head)
        {
            Node meet = detectCycle(head);
            Node start = head;
            Node prev = meet;

            while (meet != start)
            {
                prev = meet;
                meet = meet.next;
                start = start.next;
            }
            prev.next = null;    // delete cycle. 
            return start;
        }

        public void printList(Node node)
        {
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
        }
        public Node reverseLinkelist(Node head)
        {
            Node cur = head;
            Node prv = null;

            while (cur != null)
            {
                Node temp = cur.next;
                cur.next = prv;
                prv = cur;
                cur = temp;
            }

            return prv;
        }

        public Node reverseLinkelistmn(Node head,int m,int n)
        {
            Node cur = head;
            int count = 1;
            Node startNode = null;
                                                            
            while (count < m) 
            {
                count++;
                startNode = cur;
                cur = cur.next;
               
            }                             
            Node tail = cur;
            Node prv = null;
            
            while (count >= m && count <= n) 
            {
                Node temp = cur.next;
                cur.next = prv;
                prv = cur;
                cur = temp;
                count++;
            }

            startNode.next = prv;
            tail.next = cur;
            return head;
        }
    }
}
