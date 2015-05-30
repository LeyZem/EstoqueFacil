using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estoque_Fácil_7._4
{
    static class ListCusto
    {
        public static List<Custo> _list;
        static ListCusto()
        {
            _list = new List<Custo>();
        }

        public static void Record(Custo value)
        {
            _list.Add(value);
        }
        public static List<Custo> Alteracao = new List<Custo>();
        internal static void GravaAlteracao(Custo value)
        {
            Alteracao.Add(value);
        }
    }
}
