using Ticket.Domain.Models;

namespace Ticket.Domain.Repository
{
    public interface ITicketRepository
    {
        Task<IEnumerable<TicketModule>> GetAllAsync();
        Task<TicketModule> GetByIdAsync(int id);
        Task AddAsync(TicketModule entity);
        void Update(TicketModule entity);
        Task Delete(int id);


    }
}
