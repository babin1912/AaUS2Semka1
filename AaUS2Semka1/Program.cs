using System;
using AaUS2Semka1.BinaryTree;

namespace AaUS2Semka1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BSTTree tree = new BSTTree();
            tree.Insert(5);
            tree.Insert(4);

            var peter = string.Concat(" ", "ano");
            Console.WriteLine(peter);
        }
    }
}
