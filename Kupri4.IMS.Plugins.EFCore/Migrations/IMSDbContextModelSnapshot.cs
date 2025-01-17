﻿// <auto-generated />
using System;
using Kupri4.IMS.Plugins.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kupri4.IMS.Plugins.EFCore.Migrations
{
    [DbContext(typeof(IMSDbContext))]
    partial class IMSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Kupri4.IMS.CoreBusiness.InvenoryTransaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ActivityType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DoneBy")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("InventoryId")
                        .HasColumnType("TEXT");

                    b.Property<int>("InventoryQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PurchaseOrder")
                        .HasColumnType("TEXT");

                    b.Property<int>("QuantityAfter")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuantityBefore")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("TransactionDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId");

                    b.ToTable("InvenoriesTransactions");
                });

            modelBuilder.Entity("Kupri4.IMS.CoreBusiness.Inventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Kupri4.IMS.CoreBusiness.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Kupri4.IMS.CoreBusiness.ProductInventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("InventoryId")
                        .HasColumnType("TEXT");

                    b.Property<int>("InventoryQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInventories");
                });

            modelBuilder.Entity("Kupri4.IMS.CoreBusiness.ProductTransaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ActivityType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DoneBy")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuantityAfter")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuantityBefore")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("TransactionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("TransactionNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductTransactions");
                });

            modelBuilder.Entity("Kupri4.IMS.CoreBusiness.InvenoryTransaction", b =>
                {
                    b.HasOne("Kupri4.IMS.CoreBusiness.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId");

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("Kupri4.IMS.CoreBusiness.ProductInventory", b =>
                {
                    b.HasOne("Kupri4.IMS.CoreBusiness.Inventory", "Inventory")
                        .WithMany("ProductInventories")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kupri4.IMS.CoreBusiness.Product", "Product")
                        .WithMany("ProductInventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Kupri4.IMS.CoreBusiness.ProductTransaction", b =>
                {
                    b.HasOne("Kupri4.IMS.CoreBusiness.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Kupri4.IMS.CoreBusiness.Inventory", b =>
                {
                    b.Navigation("ProductInventories");
                });

            modelBuilder.Entity("Kupri4.IMS.CoreBusiness.Product", b =>
                {
                    b.Navigation("ProductInventories");
                });
#pragma warning restore 612, 618
        }
    }
}
