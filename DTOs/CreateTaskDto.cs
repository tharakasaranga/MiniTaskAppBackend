using System.ComponentModel.DataAnnotations;

namespace backend.DTOs
{
    public class CreateTaskDto
    {
        [Required]
        [MaxLength(150)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Description { get; set; }
    }
}