using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DineshPortfolio.ViewModel
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile File { get; set; }
    }
}
