namespace JohnAssistantFSD.Domain
{
    public class ShoppingList : BaseDomainModel
    {
        public string? Content { get; set; }
        public int? Amount { get; set; }
        public float? Cost { get; set; }
        public bool Bought { get; set; }
    }
}
