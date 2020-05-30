using System;
using System.ComponentModel.DataAnnotations;

namespace MvcCard.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }
    }
}