using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class WaterEntry
    {
        [Key]
        public int WaterEntryId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [Range(0, 10000)]
        public int AmountMl { get; set; }

        [Required]
        public DateTime EntryDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Property
        public User User { get; set; }
    }
}
