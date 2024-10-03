using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ejercicio_Guia9._1.Models
{
    public abstract class Evaluacion
    {
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public Evaluacion(string nom, string des)
        {
            Nombre = nom;
            Descripcion = des;
        }
        public abstract TipoAprobacion Evaluar(); //metodo abstracto que utiliza el enum.
        public override string ToString()
        {
            string date = $"{Nombre}||{Descripcion}\n\r";
            return date;
        }
    }
}
