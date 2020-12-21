using System.ComponentModel.DataAnnotations;

namespace NextSoftTest.Models
{
    public class cadastro
    {
        [Key]
        [Required]
        public int id { get; set; }
       
        [Required]
        public string nome { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string telefone { get; set; }

        [Required]
        public string logradouro { get; set; }

        [Required]
        public int numero { get; set; }

        [Required]
        public string telefoneEndereco{get;set;}

        [Required]
        public string bairro { get; set; }

        [Required]
        public string cidade { get; set; }

        [Required]
        public string estado { get; set; } 
    }
}