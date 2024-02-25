namespace MediatrExercisev2.Abstraction.Responses.Purchase
{
    public class GetHouseholdPurchaseDTO
    {
        public Guid CustomerId { get; set; }

        public required string CustomerName { get; set; }

        public required string CustomerDiscount {  get; set; }

        public required List<List<string>> Purchases { get; set; }
    }
}
