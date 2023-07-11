using ServerSweep.Application.Catalog.Brands;
using ServerSweep.Application.Sweep.Requests;

namespace ServerSweep.Host.Controllers.Sweep;

public class RequestsController : VersionedApiController
{
    [HttpPost("search")]
    // [MustHavePermission(FSHAction.Search, FSHResource.Requests)]
    // [OpenApiOperation("Search requests using available filters.", "")]
    public Task<PaginationResponse<RequestDto>> SearchAsync(SearchRequestsRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPost]
    //[MustHavePermission(FSHAction.Create, FSHResource.Brands)]
    //[OpenApiOperation("Create a new brand.", "")]
    public Task<Guid> CreateAsync(CreateRequestRequest request)
    {
        return Mediator.Send(request);
    }
}

//{ 
//  "keyword": "",
//  "pageNumber": 0,
//  "pageSize": 10,
//  "orderBy": [
//    "id"
//  ]
//}