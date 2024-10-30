using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ticket.Domain.Utilites;

namespace Ticket.Domain.Models
{
    public class TicketModule
    {
        [Key]
        public int TicketId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime FromData { get; set; }
        public DateTime ToData { get; set; }
        public Status Status { get; set; }
        [ForeignKey("User")]
        public int? userId { get; set; }
        public virtual User? User { get; set; }
    }
}


