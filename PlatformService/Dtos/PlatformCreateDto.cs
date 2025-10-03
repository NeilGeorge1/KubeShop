using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PlatformService.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher {get; set; }

        [Required]
        public int Cost { get; set; }
    }
}