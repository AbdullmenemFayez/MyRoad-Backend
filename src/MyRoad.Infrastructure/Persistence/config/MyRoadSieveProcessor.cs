using Microsoft.Extensions.Options;
using MyRoad.Infrastructure.Customers;
using MyRoad.Infrastructure.Employees;
using MyRoad.Infrastructure.EmployeesLogs;
using MyRoad.Infrastructure.Orders;
using MyRoad.Infrastructure.Payments.CustomerPayments;
using MyRoad.Infrastructure.Payments.EmployeePayments;
using MyRoad.Infrastructure.Payments.SupplierPayments;
using MyRoad.Infrastructure.Purchases;
using MyRoad.Infrastructure.Suppliers;
using MyRoad.Infrastructure.Users;
using Sieve.Models;
using Sieve.Services;

namespace MyRoad.Infrastructure.Persistence.config;

public class MyRoadSieveProcessor(IOptions<SieveOptions> options, ISieveCustomFilterMethods filterMethods) : SieveProcessor(options, filterMethods)
{
    protected override SievePropertyMapper MapProperties(SievePropertyMapper mapper)
    {
        return mapper
            .ApplyConfiguration<OrderSieveConfiguration>()
            .ApplyConfiguration<CustomerSieveConfiguration>()
            .ApplyConfiguration<EmployeePaymentSieveConfiguration>()
            .ApplyConfiguration<EmployeeSieveConfiguration>()
            .ApplyConfiguration<CustomerPaymentSieveConfiguration>()
            .ApplyConfiguration<EmployeeLogSieveConfiguration>()
            .ApplyConfiguration<SupplierSieveConfiguration>()
            .ApplyConfiguration<PurchaseSieveConfiguration>()
            .ApplyConfiguration<SupplierPaymentSieveConfiguration>()
            .ApplyConfiguration<UserSieveConfiguration>();
    }
}