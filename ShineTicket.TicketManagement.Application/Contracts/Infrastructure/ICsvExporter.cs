using ShineTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport;

namespace ShineTicket.TicketManagement.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
