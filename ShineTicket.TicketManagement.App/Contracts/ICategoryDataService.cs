using ShineTicket.TicketManagement.App.Services;
using ShineTicket.TicketManagement.App.Services.Base;
using ShineTicket.TicketManagement.App.ViewModels;

namespace ShineTicket.TicketManagement.App.Contracts
{
    public interface ICategoryDataService
    {
        Task<List<CategoryViewModel>> GetAllCategories();
        Task<List<CategoryEventsViewModel>> GetAllCategoriesWithEvents(bool includeHistory);
        Task<ApiResponse<CategoryDto>> CreateCategory(CategoryViewModel categoryViewModel);
    }
}
