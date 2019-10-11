using System;
using AaUS2Semka1.BinaryTree;

namespace AaUS2Semka1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BSTTree tree = new BSTTree();
            BSTTree treeR = new BSTTree();
            //var peter = new IComparable[]{0, 2, 3};
            //tree.InsertList(new IComparable[] { 3, 9, 20, 15, 7 });

            tree.InsertRecursiveList(new IComparable[] { 24, 31,25, 15,50, 18, 10,22,35,70,4,12,44,66,90,91});
            //Console.WriteLine(" " + tree.InOrder());

            
            treeR.InsertList(new IComparable[] { 24, 31, 25, 15, 50, 18, 10, 22, 35, 70, 4, 12, 44, 66, 90, 91 });
            //Console.WriteLine(" " + treeR.InOrder());


            tree.ToStringAF();
            treeR.ToStringAF();

            Console.WriteLine(tree.Contains(90));
            //Console.WriteLine(jozef);
        }
    }
}
