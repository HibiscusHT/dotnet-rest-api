using System;
using System.Linq;
using System.Collections.Generic;
using VoucherEntity;
using VoucherConfigEntity;
using VoucherOrm;
using Microsoft.EntityFrameworkCore;

namespace VouchersRepos {
    public class VoucherRepos {
        private LocationDbContext context;
public VoucherRepos(LocationDbContext context)
{
this.context = context;
}

public ICollection<Voucher> AllForMember()
{
return this.context.Vouchers.ToList();
}

public ICollection<Voucher> AllJoin()
{
return this.context.Vouchers.Include(v=>v.ketentuan).ToList();
}

    }
}