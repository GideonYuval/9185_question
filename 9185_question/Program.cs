using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9185_question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> n = Arr2List(new int[] { 2, 9, -9, 4, -9, 3, 4, 5, -9 });

            Console.WriteLine(BuildDigit(n)); //92->4->543
        }

        public static Node<T> Arr2List<T>(T[] arr)
        {
            if (arr.Length == 0) return null;

            Node<T> head = new Node<T>(arr[0]);
            Node<T> current = head;
            for (int i = 1; i < arr.Length; i++)
            {
                current.SetNext(new Node<T>(arr[i]));
                current = current.GetNext();
            }
            return head;
        }


        static Node<int> BuildDigit(Node<int> lst)
        {
            return null;
        }
    }
}
