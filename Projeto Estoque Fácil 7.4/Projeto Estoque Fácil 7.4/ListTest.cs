using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estoque_Fácil_7._4
{
    static class ListTest
    {
        static List<Material> _list; // Static List instance

        static ListTest()
        {
            //
            // Allocate the list.
            //
            _list = new List<Material>();
        }

        public static void Record(Material value)
        {
            //
            // Record this value in the list.
            //
            _list.Add(value);
        }

        public static void Display()
        {
            //
            // Write out the results.
            //
            foreach (var value in _list)
            {
                Console.WriteLine(value);
            }
        }
    }
}
