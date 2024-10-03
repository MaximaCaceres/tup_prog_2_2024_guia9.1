using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Guia9._1.Models
{
    internal class EvaluacionParametrica:Evaluacion
    {
        public double ValorMinimo { get; private set; }
        public double ValorMaximo { get; private set; }
        public string Unidad { get; private set; }
        public double ValorTolerado { get; private set; }
        public double ValorMedido { get; set; }
        #region Metodos
        public EvaluacionParametrica(string nom, string des, double min,double max,string uni,double tole):base(nom,des)
        {
            ValorMinimo = min;
            ValorMaximo = max;
            Unidad = uni;
            ValorTolerado = tole;
        }
        public override TipoAprobacion Evaluar()
        {
            TipoAprobacion MedidaA = TipoAprobacion.Indefinido;

            if (ValorMedido < ValorMinimo)//si el valor minimo es menos al 70% de 30
            {
                MedidaA = TipoAprobacion.NoAprobado;
            }
            else if(ValorMedido > ValorMinimo && ValorMedido <= ValorMaximo)
            {
                MedidaA = TipoAprobacion.Parcial;
            }
            else
            {
                MedidaA = TipoAprobacion.Aprobado;
            }
            return MedidaA;
            
        }
        public override string ToString()
        {
            string d = Evaluar().ToString();
            string date = $"{Descripcion}{Unidad}{d}\n\r";
            return date;
        }
        #endregion
    }
}
