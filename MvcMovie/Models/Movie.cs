using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "O campo deve ter entre {2} e {1} caracteres.")]
        [Required(ErrorMessage = "O campo {0} � obrigat�rio.")]
        [Display(Name = "Titulo")]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Lan�amento")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required(ErrorMessage = "O campo {0} � obrigat�rio.")]
        [StringLength(30, ErrorMessage = "O tamanho m�ximo do campo � {1} caracteres.")]
        [Display(Name = "G�nero")]
        public string? Genre { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Pre�o")]
        public decimal Price { get; set; }

        [Display(Name = "Avalia��o")]
        public string? Rating { get; set; }
    }
}