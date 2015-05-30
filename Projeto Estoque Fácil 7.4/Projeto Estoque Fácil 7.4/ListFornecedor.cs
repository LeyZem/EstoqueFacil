using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estoque_Fácil_7._4
{
    static class ListFornecedor
    {
        public static List<Fornecedor> _list;
        static ListFornecedor()
        {
            _list = new List<Fornecedor>();
        }

        public static void Record(Fornecedor value)
        {
            _list.Add(value);
        }
        public static List<Fornecedor> Alteracao = new List<Fornecedor>();
        internal static void GravaAlteracao(Fornecedor value)
        {
            Alteracao.Add(value);
        }
    }
}
