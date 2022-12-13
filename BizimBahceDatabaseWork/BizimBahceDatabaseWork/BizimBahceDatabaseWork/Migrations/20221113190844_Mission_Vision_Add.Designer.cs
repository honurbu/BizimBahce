﻿// <auto-generated />
using BizimBahceDatabaseWork.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BizimBahceDatabaseWork.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221113190844_Mission_Vision_Add")]
    partial class Mission_Vision_Add
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vision")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.HasKey("CommentID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.OliveOil", b =>
                {
                    b.Property<int>("OliveOilsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OliveOilBenefitID")
                        .HasColumnType("int");

                    b.Property<int>("OliveOilPriceID")
                        .HasColumnType("int");

                    b.Property<int>("OliveOilPropertyID")
                        .HasColumnType("int");

                    b.Property<int>("OliveOilTypeID")
                        .HasColumnType("int");

                    b.HasKey("OliveOilsID");

                    b.HasIndex("OliveOilBenefitID");

                    b.HasIndex("OliveOilPriceID");

                    b.HasIndex("OliveOilPropertyID");

                    b.HasIndex("OliveOilTypeID");

                    b.ToTable("OliveOils");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.OliveOilBenefit", b =>
                {
                    b.Property<int>("OliveOilBenefitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OliveOilBenefitDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OliveOilBenefitID");

                    b.ToTable("OliveOilBenefits");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.OliveOilPrice", b =>
                {
                    b.Property<int>("OliveOilPriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("OliveOilPriceLiter")
                        .HasColumnType("real");

                    b.HasKey("OliveOilPriceID");

                    b.ToTable("OliveOilPrices");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.OliveOilProperty", b =>
                {
                    b.Property<int>("OliveOilPropertyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("OliveOilAsidic")
                        .HasColumnType("real");

                    b.Property<string>("OliveOilDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("OliveOilLiter")
                        .HasColumnType("real");

                    b.HasKey("OliveOilPropertyID");

                    b.ToTable("OliveOilProperties");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.OliveOilType", b =>
                {
                    b.Property<int>("OliveOilTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OliveOilDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OliveOilTypeID");

                    b.ToTable("OliveOilTypes");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.SocialMedia", b =>
                {
                    b.Property<int>("SocialMediaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SocialMediaFace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMediaInstagram")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocialMediaID");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.Comment", b =>
                {
                    b.HasOne("BizimBahceDatabaseWork.Models.Entities.Customer", "Customer")
                        .WithMany("Comments")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.OliveOil", b =>
                {
                    b.HasOne("BizimBahceDatabaseWork.Models.Entities.OliveOilBenefit", "OliveOilBenefit")
                        .WithMany("OliveOils")
                        .HasForeignKey("OliveOilBenefitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BizimBahceDatabaseWork.Models.Entities.OliveOilPrice", "OliveOilPrice")
                        .WithMany("OliveOils")
                        .HasForeignKey("OliveOilPriceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BizimBahceDatabaseWork.Models.Entities.OliveOilProperty", "OliveOilProperty")
                        .WithMany("OliveOils")
                        .HasForeignKey("OliveOilPropertyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BizimBahceDatabaseWork.Models.Entities.OliveOilType", "OliveOilType")
                        .WithMany("OliveOils")
                        .HasForeignKey("OliveOilTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OliveOilBenefit");

                    b.Navigation("OliveOilPrice");

                    b.Navigation("OliveOilProperty");

                    b.Navigation("OliveOilType");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.Customer", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.OliveOilBenefit", b =>
                {
                    b.Navigation("OliveOils");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.OliveOilPrice", b =>
                {
                    b.Navigation("OliveOils");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.OliveOilProperty", b =>
                {
                    b.Navigation("OliveOils");
                });

            modelBuilder.Entity("BizimBahceDatabaseWork.Models.Entities.OliveOilType", b =>
                {
                    b.Navigation("OliveOils");
                });
#pragma warning restore 612, 618
        }
    }
}
