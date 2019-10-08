using System;
using System.Collections;           // für ArrayList
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHL_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = new int[5] { 11, 22, 33, 44, 55 };

            foreach (int zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }

            int[,] tabelle = new int[7, 5]
            {
                { 15, 16, 18, 20, 23 },
                { 15, 16, 18, 20, 23 },
                { 15, 16, 18, 20, 23 },
                { 15, 16, 18, 20, 23 },
                { 15, 16, 18, 20, 23 },
                { 15, 16, 18, 20, 23 },
                { 15, 16, 18, 20, 23 }
            };

            int[,,] tabellen = new int[7, 5, 10];

            int[] erstesArray = new int[3] { 1, 2, 3 };
            int[] zweitesArray = erstesArray;

            for (int i=0; i < erstesArray.Length; i++)
            {
                zweitesArray[i] = erstesArray[i];
            }

            int[] intArray = new int[5]
            {
                10,55,23,18,5
            };
            Array.Sort(intArray);
            foreach (int i in intArray) {
                Console.WriteLine(i);
            }

            ArrayList arrayList = new ArrayList();


            Console.ReadKey();
           
        }
    }
}
