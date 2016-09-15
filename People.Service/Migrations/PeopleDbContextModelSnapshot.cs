using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using People.Service.Model;

namespace People.Service.Migrations
{
    [DbContext(typeof(PeopleDbContext))]
    partial class PeopleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("People.Service.Model.Contact", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("City");

                    b.Property<string>("Company");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("JobTitle");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<string>("PhotoUrl");

                    b.Property<string>("PostalCode");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });
        }
    }
}
