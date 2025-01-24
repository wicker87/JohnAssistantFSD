using Microsoft.Identity.Client;

namespace JohnAssistantFSD.Domain
{
    public class Events : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? EventType { get; set; }
        public string? AdditionalNotes {  get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string? Location { get; set; }

    }
}
