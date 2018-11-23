using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public class Producto
    {

       
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Valor { get; set; }     
        public int Cantidad { get; set; }


        public override string ToString()
        {
            return $"{Codigo};{Nombre};{Valor};{Cantidad}";
        }

        
    }
}
