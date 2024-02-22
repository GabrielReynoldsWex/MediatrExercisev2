using MediatrExercisev2.Domain.Entities.CustomerClass;

namespace MediatrExercisev2.Application.Customers.Commands.CreateCustomer
{
    public static class CreateCustomerCommandExtension
    {
        public static Customer CreateCustomer(this CreateCustomerCommand command)
        {
            var Customer = new Customer(command.Name, command.ContactNumber, command.CustomerDiscount);
            return Customer;
        }
    }
}
