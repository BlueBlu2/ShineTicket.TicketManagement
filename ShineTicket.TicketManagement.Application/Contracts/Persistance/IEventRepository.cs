using ShineTicket.TicketManagement.Domain.Entities;

namespace ShineTicket.TicketManagement.Application.Contracts.Persistance
{
    public interface IEventRepository: IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);

    }
}
