using AutoMapper;
using CalculationCash.Data;
using MediatR;
using System.Transactions;
using AutoMapper;


namespace CalculationCash.Application.Service.Queries.TransactionsQuery
{
    public class GetTransactionByIdQuery : IRequest<TransactionDto>
    {
        public Guid Id { get; set; }

        public GetTransactionByIdQuery(Guid id)
        {
            Id = id;
        }
    }
    public class GetTransactionByIdQueryHandler : IRequestHandler<GetTransactionByIdQuery, TransactionDto>
    {
        private readonly IRepository<Transaction> _transactionRepository;
        private readonly IMapper _mapper;

        public GetTransactionByIdQueryHandler(IRepository<Transaction> transactionRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }

        public Task<TransactionDto> Handle(GetTransactionByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
