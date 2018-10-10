﻿// <auto-generated />
using System;
using MicroFlow.Infrastructure.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicroFlow.Infrastructure.Data.Migrations.Budget
{
    [DbContext(typeof(BudgetDbContext))]
    partial class BudgetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MicroFlow.Domain.Model.BudgetItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<byte[]>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Notes")
                        .HasMaxLength(1000);

                    b.Property<int>("Order");

                    b.Property<int>("Type_Id");

                    b.HasKey("Id");

                    b.HasIndex("Type_Id");

                    b.ToTable("BudgetItems","Budget");

                    b.HasDiscriminator<string>("Discriminator");
                });

            modelBuilder.Entity("MicroFlow.Domain.Model.BudgetItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BudgetClass");

                    b.Property<byte[]>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Notes")
                        .HasMaxLength(1000);

                    b.Property<int>("Order");

                    b.HasKey("Id");

                    b.ToTable("BudgetItemTypes","Budget");
                });

            modelBuilder.Entity("MicroFlow.Domain.Model.BudgetItem", b =>
                {
                    b.HasOne("MicroFlow.Domain.Model.BudgetItemType", "Type")
                        .WithMany()
                        .HasForeignKey("Type_Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
