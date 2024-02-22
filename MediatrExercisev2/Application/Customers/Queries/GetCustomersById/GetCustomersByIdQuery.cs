using MediatR;
using MediatrExercisev2.Abstraction.Responses.Customer;

namespace MediatrExercisev2.Application.Customers.Queries.GetCustomersByID
{
    public class GetCustomersByIdQuery : IRequest<IList<GetCustomerDTO>>
    {
    }
}
