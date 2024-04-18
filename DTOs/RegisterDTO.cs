using System.ComponentModel.DataAnnotations;

namespace cp2.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string USerEmail { get; set; }
        [DataType(DataType.Password)]
        public string UserPassaword { get; set; }
        [DataType(DataType.Password)]
        [Compare("UserPassaword", ErrorMessage = "As senhas não coincidem.")]
        public string ComparePassaword { get; set; }
        public string UserPhone { get; set; }
    }
}
