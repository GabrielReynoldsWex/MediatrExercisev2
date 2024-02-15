using MediatR;
using MediatrExercisev2.Abstraction.Responses.Customer;

namespace MediatrExercisev2.Application.Customers.Queries.GetCustomers
{
    public class GetCustomersQuery : IRequest<IList<GetCustomerDTO>>
    {
    }
}
