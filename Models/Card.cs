using System;
using System.ComponentModel.DataAnnotations;

namespace MvcCard.Models
{
    public class Card
    {
        public int Id { get; set; }

        [StringLength(30, MinimumLength = 5)]
        [Required]
        public string From { get; set; }

        [StringLength(30, MinimumLength = 5)]
        [Required]
        public string To { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string Message { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
    }
}