using ShineTicket.TicketManagement.Application.Responses;

namespace ShineTicket.TicketManagement.Application.Features.Categories.Commands
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryCommandResponse() : base()
        {

        }

        public CreateCategoryDto Category { get; set; } = default!;
    }
}
