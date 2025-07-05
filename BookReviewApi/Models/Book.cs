using System.ComponentModel.DataAnnotations;

namespace BookReviewApi.Models;

public class Book
{
    [Key]
    public Guid Id { get; set; } = default;
    [Required]
    public string Name { get; set; } = string.Empty;
    
    public string ISBN { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public int PublicationYear { get; set; } = default;
    public byte[]? Image { get; set; }
    
    // Navigation property for one-to-many
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    
}