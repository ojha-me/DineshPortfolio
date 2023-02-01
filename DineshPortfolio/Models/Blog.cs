using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DineshPortfolio.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [AllowNull]
        public string? CoverImage { get; set; }
    }
}