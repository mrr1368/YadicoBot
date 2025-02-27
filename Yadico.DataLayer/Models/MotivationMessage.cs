using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yadico.DataLayer.Models
{
    public class MotivationMessage
    {
        [Key]
        public int MotivationMessageId { get; set; } 

        [Required]
        [StringLength(1000)]
        public string Message { get; set; }  

        [Required]
        [ForeignKey("PlanId")]
        public int PlanId { get; set; }  

        [StringLength(100)]
        public string PlanType { get; set; }  

        public string ProgressStage { get; set; } 

        public DateTime SentAt { get; set; }  
    }
}
