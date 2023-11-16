using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pagina_insumos.Models
{
    [Table("Insumos")]
    public class Insumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quantidade")]
        public string Quantidade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor")]
        public int Valor { get; set; }
    }
}
