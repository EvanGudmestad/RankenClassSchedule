using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RankenClassSchedule.Models.DomainModels;

namespace RankenClassSchedule.Models.Configuration
{
    public class ClassConfig : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> entity)
        {
           //Fluent API to change the delete behavior to restrict
           entity.HasOne(c => c.Teacher)
                .WithMany(t => t.Classes)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasData(
                new Class { ClassId = 1, Title="Intro to C#", Number=100, TeacherId=1,DayId=1, MilitaryTime="0800"},
                new Class { ClassId = 2, Title = "Intro to Web Dev", Number = 101, TeacherId = 1, DayId = 2, MilitaryTime = "0800" },
                new Class { ClassId = 3, Title = "Intro to MERN", Number = 102, TeacherId = 1, DayId = 3, MilitaryTime = "0800" },
                new Class { ClassId = 4, Title = "Intro to .NET MVC Core", Number = 103, TeacherId = 1, DayId = 4, MilitaryTime = "0800" },
                new Class { ClassId = 5, Title = "Intro to Desktop Support", Number = 104, TeacherId = 2, DayId = 1, MilitaryTime = "0800" },
                new Class { ClassId = 6, Title = "Intro to Hardware", Number = 105, TeacherId = 3, DayId = 1, MilitaryTime = "0800" },
                new Class { ClassId = 7, Title = "Intro to IT Administration", Number = 106, TeacherId = 4, DayId = 1, MilitaryTime = "0800" },
                new Class { ClassId = 8, Title = "Intro to Networking", Number = 107, TeacherId = 5, DayId = 1, MilitaryTime = "0800" }
                );
        }
    }
}
