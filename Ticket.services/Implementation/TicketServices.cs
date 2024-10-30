using AutoMapper;
using Ticket.Domain.Models;
using Ticket.Domain.Repository;
using Ticket.services.Dtos;
using Ticket.services.Interfaces;

namespace Ticket.services.Implementation
{
    public class ticketServices : ITicketServices
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public ticketServices(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }
        public async Task AddAsync(TicketDto entity)
        {
            var Ticket = _mapper.Map<TicketModule>(entity);
            await _ticketRepository.AddAsync(Ticket);
        }

        public Task DeleteModuleById(int id)
         => _ticketRepository.Delete(id);
        public async Task<IEnumerable<TicketDto>> GetAllAsync()
        {
            var TicketList = await _ticketRepository.GetAllAsync();
            IEnumerable<TicketDto> TicketDto = _mapper.Map<IEnumerable<TicketDto>>(TicketList);
            return TicketDto;
        }

        public async Task<TicketDto> GetByIdAsync(int id)
        {
            TicketModule ticket = await _ticketRepository.GetByIdAsync(id);
            TicketDto TicketDto = _mapper.Map<TicketDto>(ticket);
            return TicketDto;
        }

        public void Update(TicketDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
