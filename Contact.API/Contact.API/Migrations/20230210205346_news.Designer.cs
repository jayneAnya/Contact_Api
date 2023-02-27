﻿// <auto-generated />
using System;
using Contact.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Contact.API.Migrations
{
    [DbContext(typeof(ContactDbContext))]
    [Migration("20230210205346_news")]
    partial class news
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Contact.Domain.Model.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Continent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Contact.Domain.Model.Email", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmailId"), 1L, 1);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserContactId")
                        .HasColumnType("int");

                    b.HasKey("EmailId");

                    b.HasIndex("UserContactId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("Contact.Domain.Model.PhoneNumber", b =>
                {
                    b.Property<int>("PhoneNumberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhoneNumberId"), 1L, 1);

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetworkProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserContactId")
                        .HasColumnType("int");

                    b.HasKey("PhoneNumberId");

                    b.HasIndex("UserContactId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("Contact.Domain.Model.UserContact", b =>
                {
                    b.Property<int>("UserContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserContactId"), 1L, 1);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserContactId");

                    b.HasIndex("AddressId");

                    b.ToTable("UserContacts");
                });

            modelBuilder.Entity("Contact.Domain.Model.Email", b =>
                {
                    b.HasOne("Contact.Domain.Model.UserContact", null)
                        .WithMany("Email")
                        .HasForeignKey("UserContactId");
                });

            modelBuilder.Entity("Contact.Domain.Model.PhoneNumber", b =>
                {
                    b.HasOne("Contact.Domain.Model.UserContact", null)
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("UserContactId");
                });

            modelBuilder.Entity("Contact.Domain.Model.UserContact", b =>
                {
                    b.HasOne("Contact.Domain.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Contact.Domain.Model.UserContact", b =>
                {
                    b.Navigation("Email");

                    b.Navigation("PhoneNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}
