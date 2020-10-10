using System;
using System.ComponentModel.DataAnnotations;


namespace calculadoramvc.Models
{
    public class Calculadora
    {
        public int Operador1 { get; set; }
        public int Operador2 { get; set; }

        public string Accion { get; set; }

        [Display(Name="Sale: ")]
        public float Respuesta { get; set; }

    }
}
