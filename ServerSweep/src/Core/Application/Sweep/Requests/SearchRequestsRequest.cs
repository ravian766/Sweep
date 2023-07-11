using ServerSweep.Application.Catalog.Brands;
using ServerSweep.Domain.Sweep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSweep.Application.Sweep.Requests;

public class SearchRequestsRequest : PaginationFilter, IRequest<PaginationResponse<RequestDto>>
{

}

public class RequestsBySearchRequestSpec : EntitiesByPaginationFilterSpec<Request, RequestDto>
{
    public RequestsBySearchRequestSpec(SearchRequestsRequest request)
        : base(request) =>
        Query.OrderBy(c => c.Name, !request.HasOrderBy());
}

public class SearchRequestsRequestHandler : IRequestHandler<SearchRequestsRequest, PaginationResponse<RequestDto>>
{
    private readonly IReadRepository<Request> _repository;

    public SearchRequestsRequestHandler(IReadRepository<Request> repository) => _repository = repository;

    public async Task<PaginationResponse<RequestDto>> Handle(SearchRequestsRequest request, CancellationToken cancellationToken)
    {
        var spec = new RequestsBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}