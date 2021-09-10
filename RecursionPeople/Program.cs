using System;
using System.Collections.Generic;

namespace RecursionPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = "Fernando";
            string n2 = "Clara";

            List<Tuple<string, string>> find = new List<Tuple<string, string>>();
            find = Recursive.Saludar(n1, n2, find);

            LeerLista(find);
        }

        public static void LeerLista(List<Tuple<string, string>> find)
        {
            for (int i = find.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"{find[i].Item1} --> {find[i].Item2}");
            }
        }
    }
}
