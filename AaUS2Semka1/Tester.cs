using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using AaUS2Semka1.BinaryTree;

namespace AaUS2Semka1
{
    class Tester
    {
        public SplayTree Stromek;
        public List<int> Pole;

        public Tester()
        {
            Stromek = new SplayTree();
            Pole = new List<int>(10);

        }

        public void GenerateArray()
        {
            Random rnd = new Random();
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                j += rnd.Next(0, 10);

                try
                {
                    Pole.Insert(rnd.Next(0,Pole.Capacity),j);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Pole.Add(j);
                    //throw;
                }
            }

            foreach (var i in Pole)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Array Generated");
        }

        public void AddToTreeRND()
        {
            var i = new IComparable[] {15, 22, 6, 31, 14, 51, 17, 26, 47, 39};
            /*foreach (var v in i)
            {
                Console.WriteLine(v);
            }
*/

            Console.WriteLine("cyka");
            Stromek.InsertList(Pole.Cast<IComparable>());
            //Stromek.InsertList(i);
            //Stromek.InsertList(Pole);
            
        }

        public void ToStringAF()
        {
            Stromek.ToStringAF();
        }
    }
}
