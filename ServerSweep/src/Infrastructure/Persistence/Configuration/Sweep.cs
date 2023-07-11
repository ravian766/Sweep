using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ServerSweep.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finbuckle.MultiTenant.EntityFrameworkCore;
using ServerSweep.Domain.Sweep;

namespace ServerSweep.Infrastructure.Persistence.Configuration;

public class RequestConfig : IEntityTypeConfiguration<Request>
{
    public void Configure(EntityTypeBuilder<Request> builder)
    {
        builder.IsMultiTenant();

        builder
            .Property(b => b.Name)
                .HasMaxLength(256);
    }
}



//public class BrandConfig : IEntityTypeConfiguration<Brand>
//{
//    public void Configure(EntityTypeBuilder<Brand> builder)
//    {
//        builder.IsMultiTenant();

//        builder
//            .Property(b => b.Name)
//                .HasMaxLength(256);
//    }
