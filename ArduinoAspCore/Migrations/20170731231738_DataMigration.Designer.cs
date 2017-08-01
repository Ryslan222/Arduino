using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ArduinoAspCore.Model;

namespace ArduinoAspCore.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20170731231738_DataMigration")]
    partial class DataMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArduinoAspCore.Model.Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Datas");
                });
        }
    }
}
