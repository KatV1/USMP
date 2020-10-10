using System;
using System.ComponentModel.DataAnnotations;


namespace calculadoramvc.Models
{
    public class Contacto
    {
        //[Required(ErrorMessage = "Por favor, ingrese nombre")]
        [Display(Name="Nombre")]
        public string Nombre { get; set; }

        [Display(Name="Apellido")]
        public string Apellido { get; set; }

        [Display(Name="Email")]
        public string Email { get; set; }
        
        //[DataType(DataType.PhoneNumber)]
        [Display(Name="Teléfono")]
        public string Telefono { get; set; }

        [Display(Name="Asunto")]
        public string Asunto { get; set; }

        [Display(Name="Mensaje")]
        public string Mensaje { get; set; }
        public string Respuesta { get; set; }

    }
}