using ShineTicket.TicketManagement.Domain.Entities;

namespace ShineTicket.TicketManagement.Application.Contracts.Persistance
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {

    }
}
