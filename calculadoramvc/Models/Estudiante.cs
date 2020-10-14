using System;
using System.ComponentModel.DataAnnotations;


namespace calculadoramvc.Models
{
    public class Estudiante
    {
        [Required(ErrorMessage = "Por favor, ingrese nombre")]
        [Display(Name="Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese Apellido")]
        [Display(Name="Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese un e-mail")]
        [Display(Name="Email")]
        public string Email { get; set; }
        
        [Display(Name="Curso")]
        public string Curso { get; set; }
        
        public string Respuesta { get; set; }

    }
}