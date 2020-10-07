using System;
using System.ComponentModel.DataAnnotations;


namespace calculadoramvc.Models
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }


    }
}