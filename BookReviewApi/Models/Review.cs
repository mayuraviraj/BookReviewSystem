using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookReviewApi.Models;

public class Review
{
    [Key]
    public Guid Id { get; set; } = default;
    
    // Foreign key
    [Required]
    public Guid BookId { get; set; }
    
    // Optional navigation to parent Book
    [ForeignKey(nameof(BookId))]
    public Book Book { get; set; } = default!;
    
    [Required]
    public string Content { get; set; } = string.Empty;
}