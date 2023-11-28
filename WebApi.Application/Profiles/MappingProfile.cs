using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Application.Features.Categories.Commands.CreateCategory;
using WebApi.Application.Features.Categories.Queries.GetCategoriesList;
using WebApi.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using WebApi.Application.Features.Events.Commands.CreateEvent;
using WebApi.Application.Features.Events.Commands.UpdateEvent;
using WebApi.Application.Features.Events.Queries.GetEventDetail;
using WebApi.Application.Features.Events.Queries.GetEventList;
using WebApi.Application.Features.Events.Queries.GetEventsExport;
using WebApi.Application.Features.Orders.GetOrdersForMonth;
using WebApi.Domain.Entities;

namespace WebApi.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

            CreateMap<Order, OrdersForMonthDto>();
        }
    }
}
