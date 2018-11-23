using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class Adicionar
    {

        public int Id_venta { get; set; }
        public int Id_producto { get; set; }
        public int Id_cliente { get; set; }
        public int Id_empleado { get; set; }
        public int Cantidad { get; set; }
        public int Valor { get; set; }    
        public DateTime Fecha { get; set; }
        


        public override string ToString()
        {
            return $"{Id_venta};{Id_producto};{Id_cliente};{Cantidad};{Valor};{Fecha}";
        }

    }
}
