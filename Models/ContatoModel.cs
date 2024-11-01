using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome de contato não pode ficar em branco!!!") ]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "E-mail de contato não pode ficar em branco!!!")]
        [EmailAddress(ErrorMessage ="E-mail de contato invalido!!!")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Celular de contato não pode ficar em branco!!!")]
        [Phone(ErrorMessage ="Celular de contato invalido!!!")]
        public string? Celular { get; set; }

    }
}
