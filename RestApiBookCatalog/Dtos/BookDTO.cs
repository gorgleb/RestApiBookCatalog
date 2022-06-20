using System.ComponentModel.DataAnnotations;

namespace RestApiBookCatalog.Dtos
{
    public record BookDTO
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(0, 10000)]
        public decimal Price { get; set; }
    }
}
