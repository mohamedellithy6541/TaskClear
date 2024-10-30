using Ticket.services.Dtos;

namespace Ticket.services.Interfaces
{
    public interface ITicketServices
    {
        Task<IEnumerable<TicketDto>> GetAllAsync();
        Task<TicketDto> GetByIdAsync(int id);
        Task AddAsync(TicketDto entity);
        void Update(TicketDto entity);
        Task DeleteModuleById(int id);

    }
}
