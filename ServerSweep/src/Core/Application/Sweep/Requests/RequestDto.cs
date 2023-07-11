using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSweep.Application.Sweep.Requests;

public class RequestDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
}
