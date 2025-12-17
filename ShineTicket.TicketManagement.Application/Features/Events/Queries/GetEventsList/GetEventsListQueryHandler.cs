using AutoMapper;
using MediatR;
using ShineTicket.TicketManagement.Application.Contracts.Persistance;
using ShineTicket.TicketManagement.Domain.Entities;

namespace ShineTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQueryHandler : IRequestHandler<GetEventsListQuery, List<EventListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Event> _eventRepository;
        public GetEventsListQueryHandler(IMapper mapper, IAsyncRepository<Event> asyncRepository)
        {
          _mapper = mapper;
          _eventRepository = asyncRepository;
        }
        public async Task<List<EventListVm>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(x => x.Date);
            return _mapper.Map<List<EventListVm>>(allEvents);
        }
    }

}
