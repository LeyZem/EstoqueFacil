using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estoque_Fácil_7._4
{
    static class ListMaterial
    {
        public static List<Material> _list;
        static ListMaterial()
        {
            _list = new List<Material>();
        }

        public static void Record(Material value)
        {
            _list.Add(value);
        }

        public static List<Material> Alteracao = new List<Material>();
        internal static void GravaAlteracao(Material value)
        {
            Alteracao.Add(value);
        }
    }
}
