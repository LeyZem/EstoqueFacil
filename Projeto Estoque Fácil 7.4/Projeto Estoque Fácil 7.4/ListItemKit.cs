using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estoque_Fácil_7._4
{
    static class ListItemKit
    {
        public static List<ItemKit> _list;
        static ListItemKit()
        {
            _list = new List<ItemKit>();
        }

        public static void Record(ItemKit value)
        {
            _list.Add(value);
        }

        public static List<ItemKit> Alteracao = new List<ItemKit>();
        internal static void GravaAlteracao(ItemKit value)
        {
            Alteracao.Add(value);
        }

        public static List<Kit> _lista = new List<Kit>();
        internal static void Grava(Kit value)
        {
            _lista.Add(value);
        }

        public static List<Kit> Alter = new List<Kit>();
        internal static void GravaAlter(Kit value)
        {
            Alter.Add(value);
        }
    }
}

