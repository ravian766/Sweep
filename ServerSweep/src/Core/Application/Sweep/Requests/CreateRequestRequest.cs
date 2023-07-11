using ServerSweep.Application.Sweep.Requests;
using ServerSweep.Domain.Sweep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSweep.Application.Sweep.Requests;
public class CreateRequestRequest : IRequest<Guid>
{
    public string Name { get; set; } = default!;
}

public class CreateRequestRequestHandler : IRequestHandler<CreateRequestRequest, Guid>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<Request> _repository;

    public CreateRequestRequestHandler(IRepositoryWithEvents<Request> repository) => _repository = repository;

    public async Task<Guid> Handle(CreateRequestRequest requestRequest, CancellationToken cancellationToken)
    {
        var request = new Request(requestRequest.Name);

        await _repository.AddAsync(request, cancellationToken);

        return request.Id;
    }
}
