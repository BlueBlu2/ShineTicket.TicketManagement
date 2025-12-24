using ShineTicket.TicketManagement.Domain.Entities;

namespace ShineTicket.TicketManagement.Application.Contracts.Persistance
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        Task<List<Order>> GetPagedOrdersForMonth(DateTime date, int page, int size);
        Task<int> GetTotalCountOfOrdersForMonth(DateTime date);
    }
}
