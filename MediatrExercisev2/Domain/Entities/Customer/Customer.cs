namespace MediatrExercisev2.Domain.Entities.Customer

{
    // Not a great class name but had to be different to the namespace
    public class CustomerClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }

        public CustomerClass(string name, string contactNumber) 
        {
            Name = name;
            ContactNumber = contactNumber;
        }
    }
}
