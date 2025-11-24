using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class SleepEntry
    {
        [Key]
        public int SleepEntryId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime SleepTime { get; set; }

        [Required]
        public DateTime WakeTime { get; set; }

        public double DurationHours { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Property
        public User User { get; set; }
    }
}
