using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace RestApiBookCatalog.Models
{
    public class Book
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(0,10000)]
        public decimal Price { get; set; }

    }
}
