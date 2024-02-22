namespace MediatrExercisev2.Abstraction.Responses.Item
{
    public class GetItemDTO
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Category { get; set; }
        public required string Price { get; set; }
    }
}