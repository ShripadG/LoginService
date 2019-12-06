using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using employeeservice.Models;

namespace employeeservice.Migrations
{
    [DbContext(typeof(LoginUserTypesDbContext))]
    partial class LoginUserTypesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3");

            modelBuilder.Entity("employeeservice.Models.LoginUserTypes", b =>
                {
                     b.Property<int>("Id")
                       .ValueGeneratedOnAdd();
                    b.Property<string>("_id");
                    b.Property<string>("_rev");
                    b.Property<string>("logintypes");
                                        
                    b.HasKey("Id");
                    b.ToTable("LoginUserTypes");
                });
        }
    }
}
