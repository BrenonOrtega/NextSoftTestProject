using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cadastro.Model
{
    public class CadastroModel
    {
        public string nome { get; set; }
        public string CPF { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string telefoneEndereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }
}
