using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pagina_insumos.Models
{
    [Table("Gastos")]
    public class Gasto
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        public int Quantia { get; set; }

        [Display(Name = "Insumo")]
        public int InsumoId { get; set; }

        [ForeignKey("InsumoId")]
        public Insumo Insumo { get; set; }
    }
}
