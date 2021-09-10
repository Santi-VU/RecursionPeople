using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPeople
{
    class Recursive
    {
        private static List<Tuple<string, string>> _personas = Setup();
        private static int _count;

        public static List<Tuple<string, string>> Setup()
        {
            List<Tuple<string, string>> personas = new List<Tuple<string, string>>();
            personas.Add(Tuple.Create("Juan", "Pedro"));
            personas.Add(Tuple.Create("Juan", "Fernando"));
            personas.Add(Tuple.Create("Fernando", "Maria"));
            personas.Add(Tuple.Create("Maria", "Clara"));

            _count = personas.Count - 1;

            return personas;
        }

        public static List<Tuple<string, string>> Saludar(string n1, string n2, List<Tuple<string, string>> find)
        {
            if (_personas[_count].Item2 == n1)
            {
                return find;
            }

            if (_personas[_count].Item2 == n2)
            {
                find.Add(_personas[_count]);
                n2 = _personas[_count].Item1;
                _count--;
                return Saludar(n1, n2, find);
            }

            return null;
        }
    }
}
