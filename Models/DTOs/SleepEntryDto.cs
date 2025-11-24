using System.ComponentModel.DataAnnotations;

namespace Models.DTOs
{
    public class SleepEntryDto
    {
        [Required]
        public DateTime SleepTime { get; set; }

        [Required]
        public DateTime WakeTime { get; set; }
    }
}