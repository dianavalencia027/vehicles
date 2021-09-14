using System.ComponentModel.DataAnnotations;

namespace Vehicles.API.Models
{
    public class ChangePasswordViewModel
    {
        [Display(Name = "Contraseña actual")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "El campo {0} debe tener una longitud mínima de {1} caracteres")]
        public string OldPassword { get; set; }

        [Display(Name = "Nueva contraseña")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "El campo {0} debe tener una longitud mínima de {1} caracteres")]
        public string NewPassword { get; set; }

        [Display(Name = "Confirmación de contraseña")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "El campo {0} debe tener una longitud mínima de {1} caracteres")]
        [Compare("NewPassword", ErrorMessage = "La nueva contraseña y la confirmación no son iguales")]
        public string Confirm { get; set; }
    }
}