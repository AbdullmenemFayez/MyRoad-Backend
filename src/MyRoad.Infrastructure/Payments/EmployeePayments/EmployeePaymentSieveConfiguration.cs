using MyRoad.Domain.Payments.EmployeePayments;
using Sieve.Services;

namespace MyRoad.Infrastructure.Payments.EmployeePayments;

public class EmployeePaymentSieveConfiguration : ISieveConfiguration
{
    public void Configure(SievePropertyMapper mapper)
    {
        mapper.Property<EmployeePayment>(x => x.PaymentDate)
            .CanFilter()
            .CanSort();
        
        mapper.Property<EmployeePayment>(x => x.Id)
            .CanFilter()
            .CanSort();
        
        mapper.Property<EmployeePayment>(x => x.Employee.FullName)
            .CanFilter()
            .CanSort();
        
        mapper.Property<EmployeePayment>(x => x.Employee.Address)
            .CanFilter()
            .CanSort();
    }
}