using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FruttiCultura.Models
{
    [Table("fruta")]
    public class Fruta
    {
        [Key]
        public int idFruta { get; set; }

        [Required(ErrorMessage = "informe o nome da fruta!")]
        public string nomeFruta { get; set; } = string.Empty;

        [Required(ErrorMessage = "informe o nome da árvore fruta!")]
        public string arvoreFruta { get; set; } = string.Empty;

        [Required(ErrorMessage = "informe o nome da vitamina fruta!")]
        public string vitaminaFruta { get; set; } = string.Empty; 
    }
}
