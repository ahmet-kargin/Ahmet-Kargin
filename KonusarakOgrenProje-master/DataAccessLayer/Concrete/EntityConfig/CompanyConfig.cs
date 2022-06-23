using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityConfig
{
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company { CompanyId=1,Name="LCW",TelNo="5325486448",Mail="lcw@gmail.com"},
                new Company { CompanyId=2,Name="Koton",TelNo="5458599754",Mail= "koton@gmail.com" },
                new Company { CompanyId=3,Name="Pull&Bear",TelNo="5236548964",Mail= "pull@gmail.com" },
                new Company { CompanyId=4,Name="Zara",TelNo="5214589645",Mail= "zara@gmail.com" }
                );
        }
    }
}
