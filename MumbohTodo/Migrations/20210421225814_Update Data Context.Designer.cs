﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MumbohTodo.Data;

namespace MumbohTodo.Migrations
{
    [DbContext(typeof(ToDoDbContext))]
    [Migration("20210421225814_Update Data Context")]
    partial class UpdateDataContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MumbohTodo.Models.AddToDo", b =>
                {
                    b.Property<int>("AddToDoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddToDoID");

                    b.ToTable("AddToDos");
                });

            modelBuilder.Entity("MumbohTodo.Models.ToDo", b =>
                {
                    b.Property<int>("ToDoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddToDoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DoneDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ToDoID");

                    b.HasIndex("AddToDoID");

                    b.ToTable("ToDos");
                });

            modelBuilder.Entity("MumbohTodo.Models.ToDo", b =>
                {
                    b.HasOne("MumbohTodo.Models.AddToDo", "AddToDo")
                        .WithMany()
                        .HasForeignKey("AddToDoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddToDo");
                });
#pragma warning restore 612, 618
        }
    }
}
