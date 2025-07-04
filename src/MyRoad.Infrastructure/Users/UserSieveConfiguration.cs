using MyRoad.Infrastructure.Identity.Entities;
using Sieve.Services;

namespace MyRoad.Infrastructure.Users;

public class UserSieveConfiguration : ISieveConfiguration
{
    public void Configure(SievePropertyMapper mapper)
    {
        mapper.Property<ApplicationUser>(x => x.Id)
            .CanFilter()
            .CanSort();
        
        mapper.Property<ApplicationUser>(x => x.FirstName)
            .CanFilter()
            .CanSort();

        mapper.Property<ApplicationUser>(x => x.Email)
            .CanFilter()
            .CanSort();

        mapper.Property<ApplicationUser>(x => x.IsActive)
            .CanFilter()
            .CanSort();
    }
}