using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
   public class Provedor
    {
        public int Idprovedor { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        

        public override string ToString()
        {
            return $"{Idprovedor};{Nombre};{Telefono};{Cedula};";
        }

    }
}
