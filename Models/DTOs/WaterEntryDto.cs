using System.ComponentModel.DataAnnotations;

namespace Models.DTOs
{
    public class WaterEntryDto
    {
        [Required]
        [Range(0, 10000)]
        public int AmountMl { get; set; }

        [Required]
        public DateTime EntryDate { get; set; }
    }
}