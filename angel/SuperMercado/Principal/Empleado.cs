using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
   public class Empleado
    {
        public int Id_empleado { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Documento { get; set; }
       

        public override string ToString()
        {
            return $"{Id_empleado};{Nombre};{Telefono};{Documento}";
        }


    }
}
