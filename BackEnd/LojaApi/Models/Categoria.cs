using System.ComponentModel.DataAnnotations;

namespace LojaApi.Models{
    public class Categoria{

        [Key]
        public int Id {get;set;}

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(5, ErrorMessage = "O nome precisa ter, pelo menos, 5 caracteres")]
        public string Nome {get;set;}

        public string Departamento {get;set;}

        public DateTime DataCadastro {get;set;}

    }
}