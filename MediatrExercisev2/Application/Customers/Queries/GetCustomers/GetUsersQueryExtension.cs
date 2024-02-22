using MediatrExercisev2.Abstraction.Responses.Customer;
using MediatrExercisev2.Domain.Entities.CustomerClass;

namespace MediatrExercisev2.Application.Customers.Queries.GetCustomers
{
    public static class GetUsersQueryExtension
    {
        public static GetCustomerDTO MapTo(this Customer customer)
        {
            return new GetCustomerDTO
            {
                Id = customer.Id,
                Name = customer.Name,
                ContactNumber = customer.ContactNumber,
                CustomerDiscount = customer.CustomerDiscount
            };
        }
    }
}
