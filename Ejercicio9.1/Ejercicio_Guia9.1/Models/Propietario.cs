using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Guia9._1.Models
{
    public class Propietario
    {
        public int DNI { get; set; }
        public string ApellidosNombres { get; set; }
        public string Email { get; set; }
        public Propietario(int dni, string nom, string email)
        {
            DNI = dni;
            ApellidosNombres = nom;
            Email = email;
        }
        public override string ToString()
        {
            string date = $"{DNI}||{ApellidosNombres}||{Email}\n\r";
            return date;
        }
    }
}
