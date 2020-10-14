using System;
using System.ComponentModel.DataAnnotations;


namespace calculadoramvc.Models
{
    public class Contacto
    {
        [Required(ErrorMessage = "Por favor, ingrese nombre")]
        [Display(Name="Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese Apellido")]
        [Display(Name="Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese un e-mail para contactarlo")]
        [Display(Name="Email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar un número de teléfono")]
        [RegularExpression(@"[0-9]{9}", ErrorMessage = "No es un número de teléfono válido")]
        // [DataType(DataType.PhoneNumber)]
        [Display(Name="Teléfono")]
        public int Telefono { get; set; }

        [Display(Name="Asunto")]
        public string Asunto { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese un mensaje")]
        [Display(Name="Mensaje")]
        public string Mensaje { get; set; }
        public string Respuesta { get; set; }

    }
}