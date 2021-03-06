// <auto-generated />
using System;
using AngularDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AngularDemo.Migrations {
    [DbContext (typeof (ApplicationDBContext))]
    [Migration ("20180915092004_InitialCreate")]
    partial class InitialCreate {
        protected override void BuildTargetModel (ModelBuilder modelBuilder) {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation ("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation ("Relational:MaxIdentifierLength", 128)
                .HasAnnotation ("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity ("AngularDemo.Models.Account", b => {
                b.Property<int> ("ID")
                    .ValueGeneratedOnAdd ()
                    .HasAnnotation ("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string> ("Password");

                b.Property<string> ("UserName");

                b.HasKey ("ID");

                b.ToTable ("Accounts");
            });

            modelBuilder.Entity ("AngularDemo.Models.Category", b => {
                b.Property<int> ("CategoryID")
                    .ValueGeneratedOnAdd ()
                    .HasAnnotation ("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string> ("CategoryName");

                b.Property<string> ("Desctiption");

                b.HasKey ("CategoryID");

                b.ToTable ("Categories");
            });

            modelBuilder.Entity ("AngularDemo.Models.Product", b => {
                b.Property<int> ("ProductID")
                    .ValueGeneratedOnAdd ()
                    .HasAnnotation ("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?> ("CategoryID");

                b.Property<string> ("Description");

                b.Property<string> ("ImagePath");

                b.Property<string> ("ProductName");

                b.Property<double?> ("UnitPrice");

                b.HasKey ("ProductID");

                b.HasIndex ("CategoryID");

                b.ToTable ("Products");
            });

            modelBuilder.Entity ("AngularDemo.Models.Product", b => {
                b.HasOne ("AngularDemo.Models.Category", "Category")
                    .WithMany ("Products")
                    .HasForeignKey ("CategoryID");
            });
#pragma warning restore 612, 618
        }
    }
}