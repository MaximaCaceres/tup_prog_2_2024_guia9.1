using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Guia9._1.Models
{
    public class VTV:IComparable
    {
        List<Evaluacion> Evaluaciones = new List<Evaluacion>();
        public string Patente { get; private set; }
        public DateTime Fecha { get; private set; }
        public Propietario p { get; private set; }
        
        public int CantidadDeEvaluaciones ////
        {
            get
            {
                return Evaluaciones.Count;
            }
        }
        //declaro un indexador con un indice int que devuelve una Evaluacion
        public Evaluacion this[int idx]//le paso el indice
        {
            get
            {
                Evaluacion eva = null;//creo la variable a retornar
               if(idx >= 0 && idx < CantidadDeEvaluaciones)//si el indice es mayor o igual a cero y menor que la cantidad de evaluaciones...
                {
                    eva = Evaluaciones[idx];//entonces me guardo la evaluacion en ese indice.
                }
                return eva;//retorno la evaluacion.
            }
        }
        public TipoAprobacion Aprobacion
        {
            get
            {
                TipoAprobacion M = TipoAprobacion.Indefinido;
                for(int i = 0; i <CantidadDeEvaluaciones; i++)
                {
                    Evaluacion eva = this[i];
                    M = eva.Evaluar();
                }
                return M;
            }
        }
        public VTV(string patente, Propietario pro,DateTime f)
        {
            Patente = patente;
            p = pro;
            Fecha = f;
        }
        public string[] EmitirComprobante()//hago un metodo que me retorna un vector de string
        {
            string[] comprobantes = new string[CantidadDeEvaluaciones];
            for(int i = 0; i < CantidadDeEvaluaciones; i++)
            {
                Evaluacion o = this[i];//uso el indexador antes definido
                string com = o.ToString();//traigo el metodo Ver de cada evaluacion.
                comprobantes[i] = com;//lo guardo en la pos del arreglo.
            }
            return comprobantes;
        }
        public override string ToString()
        {
            string date = $"{p.ToString()}{Fecha}{Patente}";
            return date;
        }
    }
}
