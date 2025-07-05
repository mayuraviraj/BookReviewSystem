using System.ComponentModel.DataAnnotations;

namespace BookReviewApi.Models;

public class User
{
    [Key]
    public Guid Id { get; set; } = default;
    
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    
    [Required]
    public string Password { get; set; } = string.Empty;
}