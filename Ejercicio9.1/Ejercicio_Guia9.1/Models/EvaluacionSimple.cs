using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Guia9._1.Models
{
    public class EvaluacionSimple:Evaluacion
    {
        public bool HaVerificado { get; set; }
        public EvaluacionSimple(string nom, string des):base(nom,des)
        {
        }
        public override TipoAprobacion Evaluar()
        {
            TipoAprobacion MedidaA = TipoAprobacion.Indefinido;
            if(HaVerificado == true)
            {
                MedidaA = TipoAprobacion.Aprobado;
            }
            else
            {
                MedidaA = TipoAprobacion.NoAprobado;
            }
            return MedidaA;
        }
        public override string ToString()
        {
            string date = Evaluar().ToString();
            return date;
        }
    }
}
