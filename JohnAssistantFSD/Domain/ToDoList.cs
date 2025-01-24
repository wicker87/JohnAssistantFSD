namespace JohnAssistantFSD.Domain
{
    public class ToDoList : BaseDomainModel
    {
        public string? Content { get; set; }
        public bool Completed { get; set; }
    }
}
