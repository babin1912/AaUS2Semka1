using System;
using AaUS2Semka1.BinaryTree;

namespace AaUS2Semka1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tree = new SplayTree();
            BSTTree treeR = new BSTTree();
            //var peter = new IComparable[]{0, 2, 3};
            //tree.InsertList(new IComparable[] { 3, 9, 20, 15, 7 });

            //tree.InsertRecursiveList(new IComparable[] { 24, 31,25, 15,50, 18, 10,22,35,70,4,12,44,66,90,91});
            //Console.WriteLine(" " + tree.InOrder());


            //treeR.InsertList(new IComparable[] { 24, 31, 25, 15, 50, 18, 10, 22, 35, 70, 4, 12, 44, 66, 90, 91 });
            //Console.WriteLine(" " + treeR.InOrder());


           
            //treeR.ToStringAF();

            //tree.InsertRecursiveList(new IComparable[] {41,35,40,25,30,15,20,10 });
            tree.InsertList(new IComparable[] {15,10,35,25,20,30,40});

            //tree.RightRotation(35)
            /*Console.WriteLine("ROOT" + tree.Root.HasGrandChild());
            Console.WriteLine("Leftson" + tree.Root.LeftChild.HasGrandChild());
            Console.WriteLine("R son" + tree.Root.RightChild.HasGrandChild());*/

            //tree.ToStringAF();


            //tree.Splay(25);
            /*Console.WriteLine("ROOT" + tree.Root.HasGrandChild());
            Console.WriteLine("Leftson" + tree.Root.LeftChild.HasGrandChild());
            Console.WriteLine("Rtson" + tree.Root.RightChild.HasGrandChild());*/
            /*tree.Delete(35);
            
            tree.ToStringAF();
            tree.Delete(10);
            tree.ToStringAF();
            tree.Delete(20);*/
            /*Console.WriteLine(tree.Find(25).Has2Children());
            Console.WriteLine(tree.Find(25).HasOnly1Child());
            Console.WriteLine(tree.Find(35).Has2Children());
            Console.WriteLine(tree.Find(35).HasOnly1Child());
            Console.WriteLine(tree.Find(30).Has2Children());
            Console.WriteLine(tree.Find(30).HasOnly1Child());*/
            //tree.ToStringAF();
            //tree.Delete(25);
            /*tree.ToStringAF();
            tree.Delete(35);
            tree.ToStringAF();*/

            //tree.ToStringAF();
            //tree.Delete(20);
            //tree.ToStringAF();
            //Console.WriteLine(tree.Contains(90));

            //Console.WriteLine(jozef);
        }
    }
}
