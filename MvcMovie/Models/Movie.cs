using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "O campo deve ter entre {2} e {1} caracteres.")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Titulo")]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(30, ErrorMessage = "O tamanho máximo do campo é {1} caracteres.")]
        [Display(Name = "Gênero")]
        public string? Genre { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Preço")]
        public decimal Price { get; set; }

        [Display(Name = "Avaliação")]
        public string? Rating { get; set; }
    }
}