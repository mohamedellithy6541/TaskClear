using AutoMapper;
using Ticket.Domain.Models;
using Ticket.services.Dtos;

namespace Ticket.services.Mapper
{
    public class TicketProfile : Profile
    {
        public TicketProfile()
        {
            CreateMap<TicketModule, TicketDto>().ReverseMap();

            //CreateMap<IEnumerable<TicketModule>, IEnumerable<TicketDto>>().ReverseMap();

        }
    }
}
