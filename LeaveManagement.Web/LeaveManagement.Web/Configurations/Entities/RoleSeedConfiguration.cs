using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id="cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    Name="Administrator",
                    NormalizedName= "ADMINISTAROR"
                },
                new IdentityRole
                {
                    Id = "cac43a7e-f7cb-4448-baaf-1acb431eabbf",
                    Name = "User",
                    NormalizedName = "USER"
                }


                );
        }
    }
}