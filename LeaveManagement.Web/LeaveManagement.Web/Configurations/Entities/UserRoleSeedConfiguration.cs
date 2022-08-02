using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    UserId= "408aa945-3d84-4421-8342-7269ec64d949"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a7e-f7cb-4448-baaf-1acb431eabbf",
                    UserId = "3f4631bd-f907-4409-b416-ba356312e659"
                }

            );
        }
    }
}