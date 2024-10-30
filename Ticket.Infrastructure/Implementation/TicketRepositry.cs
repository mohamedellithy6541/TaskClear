using Microsoft.EntityFrameworkCore;
using Ticket.Domain.Models;
using Ticket.Domain.Repository;
using Ticket.Infrastructure.Data;

namespace Ticket.Infrastructure.Implementation
{
    public class TicketRepositry : ITicketRepository
    {
        private readonly ApplicationContext _applicationContext;

        public TicketRepositry(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public async Task AddAsync(TicketModule entity)
        {
            await _applicationContext.Ticket.AddAsync(entity);
            await _applicationContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var ticket = await GetByIdAsync(id);
            _applicationContext.Ticket.Remove(ticket);
            await _applicationContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TicketModule>> GetAllAsync()
        => await _applicationContext.Ticket.ToListAsync();


        public async Task<TicketModule> GetByIdAsync(int id)
        {
            var ticket = await _applicationContext.Ticket.FirstOrDefaultAsync(x => x.TicketId == id);
            return ticket;
        }

        public void Update(TicketModule entity)
          => _applicationContext.Update(entity);

    }
}
