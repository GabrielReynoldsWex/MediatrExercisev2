using System.Runtime.CompilerServices;

using MediatrExercisev2.Domain.Entities.Customer;

namespace MediatrExercisev2.Application.Customers.Commands.CreateCustomer
{
    public static class CreateCustomerCommandExtension
    {
        public static CustomerClass CreateCustomer(this CreateCustomerCommand command)
        {
            var Customer = new CustomerClass(command.Name, command.ContactNumber);
            return Customer;
        }
    }
}
