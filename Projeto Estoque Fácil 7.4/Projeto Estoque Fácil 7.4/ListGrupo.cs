using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estoque_Fácil_7._4
{
    static class ListGrupo
    {
        public static List<Grupo> _list;
        static ListGrupo()
        {
            _list = new List<Grupo>();
        }

        public static void Record(Grupo value)
        {
            _list.Add(value);
        }

        public static List<Grupo> Alteracao = new List<Grupo>();
        internal static void GravaAlteracao(Grupo value)
        {
            Alteracao.Add(value);
        }
    }
}
