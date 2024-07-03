using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Model_Tables
{
    public record Divisions
    {
        public long Id { get; set; }
        public string Name { get; set; }  

       
        public int? ParentDivCode { get; set; }
        public Divisions Parent { get; set; }
        public List<Divisions> Children { get; set; }

        public int ChiefId { get; set; }
        public Employees Chef { get; set; }



        public List<Employees> Employees { get; set; }

        

    }
   
    public record DivisionsMap
    {
        public DivisionsMap(EntityTypeBuilder<Divisions> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(e => e.Id);
            entityTypeBuilder.Property(e => e.Name).IsRequired();
            //entityTypeBuilder.
            //    HasMany(e => e.Employees)
            //    .WithOne(e => e.Divisions)
            //    .HasForeignKey(e => e.DivisionId);
            entityTypeBuilder
                .HasMany(e => e.Children)
                .WithOne(e => e.Parent)
                .HasForeignKey(e => e.ParentDivCode);
          
         
        }
    }

}
