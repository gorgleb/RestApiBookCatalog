using System.ComponentModel.DataAnnotations;

namespace RestApiBookCatalog.Dtos
{
    public class CreateOrUpdate
    {
        public string Title { get; set; }
        [Required]
        [Range(0, 10000)]
        public decimal Price { get; set; }
    }
}
