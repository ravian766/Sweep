using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSweep.Domain.Sweep;

public class Request : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; }

    public Request(string name)
    {
        Name = name;
    }
}
