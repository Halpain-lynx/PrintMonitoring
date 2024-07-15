using System;
using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class PrintEvent
    {
        public int Id { get; set; }

        [Required]
        public DateTime EventTime { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string PrinterName { get; set; }

        [Required]
        public int PageCount { get; set; }
    }
}