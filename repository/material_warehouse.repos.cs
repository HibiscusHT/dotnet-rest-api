using System;
using System.Linq;
using System.Collections.Generic;
using MaterialWarehouseEntity;
using MaterialWarehouseOrm;

namespace MaterialWarehouseRepos {
    public class MWarehouseRepos {
        private LocationDbContext context;
public MWarehouseRepos(LocationDbContext context)
{
this.context = context;
}

public ICollection<MWarehouse> AllForMember()
{
return this.context.MWarehouses.ToList();
}

    }
}