﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using final_project_final_project_group_9.Data;

#nullable disable

namespace final_project_final_project_group_9.Migrations.FavoriteFoods
{
    [DbContext(typeof(FavoriteFoodsContext))]
    partial class FavoriteFoodsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("final_project_final_project_group_9.Models.FavoriteFoods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FavBreakfast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavDinner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavLunch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavSnack")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FavoriteFoods");

                    b.HasData(
                        new
                        {
                            Id = 14969824,
                            FavBreakfast = "sandwich",
                            FavDinner = "egg",
                            FavLunch = "ham",
                            FavSnack = "pie"
                        },
                        new
                        {
                            Id = 12345678,
                            FavBreakfast = "Toast",
                            FavDinner = "pasta",
                            FavLunch = "sandwich",
                            FavSnack = "Chips"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
