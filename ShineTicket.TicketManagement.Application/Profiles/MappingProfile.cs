using AutoMapper;
using ShineTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using ShineTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using ShineTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using ShineTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using ShineTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using ShineTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList;
using ShineTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Category,CategoryListVm>().ReverseMap();
            CreateMap<Category, CategoryEventListVm>().ReverseMap();

            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();

        }
    }
}
