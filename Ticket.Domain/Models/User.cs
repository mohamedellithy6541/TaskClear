using System.ComponentModel.DataAnnotations;

namespace Ticket.Domain.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string job { get; set; }

        public ICollection<TicketModule>? Tickets { get; set; }
    }
}
