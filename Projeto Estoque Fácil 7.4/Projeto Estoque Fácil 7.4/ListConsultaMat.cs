using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estoque_Fácil_7._4
{
    static class ListConsultaMat
    {
        public static List<Material> Consulta;
        static ListConsultaMat()
        {
            Consulta = new List<Material>();
        }

        public static void Record(Material value)
        {
            Consulta.Add(value);
        }
    }
}
