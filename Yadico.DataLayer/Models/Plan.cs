using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yadico.DataLayer.Models
{
    public class Plan
    {
        [Key]
        public int PlanID { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public bool IsComplete { get; set; }

        [ForeignKey("UserId")]
        public int UserID { get; set; }
    }
}