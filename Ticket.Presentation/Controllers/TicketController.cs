using Microsoft.AspNetCore.Mvc;
using Ticket.Presentation.Controllers.Main;
using Ticket.services.Dtos;
using Ticket.services.Interfaces;

namespace Ticket.Presentation.Controllers
{
    public class TicketController : ControllerMain
    {
        private readonly ITicketServices _ticketServices;

        public TicketController(ITicketServices ticketServices)
        {
            _ticketServices = ticketServices;
        }
        [HttpGet("Tickets")]
        public async Task<IActionResult> GetAll()
        {
            var Tickets = await _ticketServices.GetAllAsync();
            return Ok(Tickets);
        }
        [HttpGet("Tickets/{id:int}")]
        public async Task<IActionResult> GetTicketById(int id)
        {
            var ticket = await _ticketServices.GetByIdAsync(id);
            return Ok(ticket);
        }

        [HttpPost("Tickets")]
        public async Task<IActionResult> AddTicket(TicketDto ticketDto)
        {
            await _ticketServices.AddAsync(ticketDto);
            return Ok("succes");
        }
        [HttpDelete("Tickets/{id:int}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            await _ticketServices.DeleteModuleById(id);

            return Ok("Removed");
        }


    }
}
