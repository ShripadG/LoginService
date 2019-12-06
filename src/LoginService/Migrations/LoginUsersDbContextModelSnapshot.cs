using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LoginService.Models;

namespace LoginService.Migrations
{
    [DbContext(typeof(LoginUsersDbContext))]
    partial class LoginUsersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3");

            modelBuilder.Entity("LoginService.Models.LoginUsers", b =>
                {
                     b.Property<int>("Id")
                       .ValueGeneratedOnAdd();
                    b.Property<string>("_id");
                    b.Property<string>("_rev");
                    b.Property<string>("EmailID");
                    b.Property<string>("Username");
                    b.Property<string>("Password");
                    b.Property<string>("Passwordsalt");
                    b.Property<string>("type");                    
                    b.HasKey("Id");
                    b.ToTable("LoginUsers");
                });
        }
    }
}
