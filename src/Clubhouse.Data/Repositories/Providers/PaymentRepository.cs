﻿using Clubhouse.Data.Entities;
using Clubhouse.Data.Repositories.Base;
using Clubhouse.Data.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Clubhouse.Data.Repositories.Providers;

[Repository]
public class PaymentRepository : Repository<Payment>, IPaymentRepository
{
    public PaymentRepository(ApplicationDbContext dbContext, 
        ILogger<PaymentRepository> logger) 
        : base(dbContext, logger)
    {
    }
}