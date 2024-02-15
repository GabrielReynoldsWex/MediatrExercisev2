using MediatR;
using MediatrExercisev2.Abstraction.Responses.Customer;
using MediatrExercisev2.Repository.Context;

namespace MediatrExercisev2.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CreateCustomerDTO>
    {
        private readonly ApplicationDbContext _dbcontext;

        public CreateCustomerCommandHandler(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<CreateCustomerDTO> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = request.CreateCustomer();

            await _dbcontext.Customers.AddAsync(customer, cancellationToken);
            await _dbcontext.SaveChangesAsync();

            return new CreateCustomerDTO(customer.Id);
        }
    }
}
