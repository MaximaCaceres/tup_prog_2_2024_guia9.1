using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Guia9._1.Models
{
    public class FiscalizadorVTV
    {
        public int CantidadVTV { get; private set; }
        public string PlantillaComprobante { get; set; }
        public List<VTV> Verificaciones = new List<VTV>();

        
    }
}
