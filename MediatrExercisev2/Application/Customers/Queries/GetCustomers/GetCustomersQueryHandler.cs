using MediatR;
using MediatrExercisev2.Abstraction.Responses.Customer;
using MediatrExercisev2.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace MediatrExercisev2.Application.Customers.Queries.GetCustomers
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, IList<GetCustomerDTO>>
    {
        private readonly ApplicationDbContext _dbContext;
        public GetCustomersQueryHandler(ApplicationDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }

        public async Task<IList<GetCustomerDTO>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = await _dbContext.Customers.ToListAsync();
            var List = new List<GetCustomerDTO>();
            foreach (var item in customers) 
            {
                var customer = item.MapTo();
                List.Add(customer);
            }
            return List;
        }
    }
}
