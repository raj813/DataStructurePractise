using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static practiseDemo.LinkedList;

namespace practiseDemo
{
    internal class NodeT
    {
        public NodeT Left, Right;
        public int data;

        public NodeT (int data)
        {
            this.data = data;
        }

        public NodeT createSampletree() 
        {
            NodeT root = null;
            root = new NodeT(10);
            root.Left = new NodeT(2);
            root.Right = new NodeT(3);
            root.Left.Left = new NodeT(7);
            root.Left.Right = new NodeT(8);
            root.Right.Right = new NodeT(15);
            root.Right.Left = new NodeT(12);
            root.Right.Right.Left = new NodeT(14);

            return root;

        }
        public NodeT BSTcreateSampletree()
        {
            NodeT root = null;
            root = new NodeT(10);
            root.Left = new NodeT(5);
            root.Right = new NodeT(50);
            root.Right.Right = new NodeT(80);
            root.Right.Left = new NodeT(20);
            root.Right.Right.Right = new NodeT(100);
            root.Right.Right.Left = new NodeT(70);
            root.Right.Right.Left.Left = new NodeT(60);
            return root;

        }
    }
}
