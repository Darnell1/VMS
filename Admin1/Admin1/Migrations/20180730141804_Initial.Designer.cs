﻿// <auto-generated />
using Admin1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Admin1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180730141804_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Admin1.Models.User", b =>
                {
                    b.Property<string>("userName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("password");

                    b.HasKey("userName");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
