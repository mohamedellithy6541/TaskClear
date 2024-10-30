using Microsoft.EntityFrameworkCore;
using Ticket.Domain.Models;
using Ticket.Domain.Utilites;

namespace Ticket.Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
        #region Ctor
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        #endregion

        #region Handle Function
        protected override void OnModelCreating(ModelBuilder Builder)
        {
            Builder.Entity<User>().HasData(
           new User { Id = 1, UserName = "Mohamed", job = "admin" },
           new User { Id = 2, UserName = "Mostafa", job = "student" }
           );
            Builder.Entity<TicketModule>().HasData(
         new TicketModule { TicketId = 1, Description = "Ticketone", Status = Status.Complete, FromData = DateTime.Now, ToData = DateTime.Today, Title = "Testone", userId = 1 },
            new TicketModule { TicketId = 2, Description = "TicketTwo", Status = Status.Inprogress, FromData = DateTime.Now, ToData = DateTime.Today, Title = "TestTwo", userId = 2 });
            Builder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();
        }
        #endregion

        #region DbSets
        public DbSet<User> User { get; set; }
        public DbSet<TicketModule> Ticket { get; set; }
        #endregion

    }
}
