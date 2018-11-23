using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class Compra
    {
        public int Id_compra { get; set; }
        public int Id_producto { get; set; }
        public int Id_provedor { get; set; }
        public int Cantidad { get; set; }
        public int Valor { get; set; }
        public DateTime Fecha { get; set; }

        public override string ToString()
        {
            return $"{Id_compra};{Id_producto};{Id_provedor};{Cantidad};{Valor};{Fecha}";
        }
    }
}
