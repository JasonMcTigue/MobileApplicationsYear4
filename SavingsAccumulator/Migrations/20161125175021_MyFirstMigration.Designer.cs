using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SavingsAccumulator.DataContext;

namespace SavingsAccumulator.Migrations
{
    [DbContext(typeof(TargetDataContext))]
    [Migration("20161125175021_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("SavingsAccumulator.Model.Target", b =>
                {
                    b.Property<int>("TargetId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("CurrentBalance");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<decimal>("SavingTarget");

                    b.HasKey("TargetId");

                    b.ToTable("Targets");
                });

            modelBuilder.Entity("SavingsAccumulator.Model.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("TargetId");

                    b.HasKey("Id");

                    b.HasIndex("TargetId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("SavingsAccumulator.Model.Transaction", b =>
                {
                    b.HasOne("SavingsAccumulator.Model.Target", "Target")
                        .WithMany("Transactions")
                        .HasForeignKey("TargetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
