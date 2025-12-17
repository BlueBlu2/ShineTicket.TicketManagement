using ShineTicket.TicketManagement.Domain.Entities;

namespace ShineTicket.TicketManagement.Application.Contracts.Persistance
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
    }
}
