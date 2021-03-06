// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MumbohTodo.Data;

namespace MumbohTodo.Migrations
{
    [DbContext(typeof(ToDoDbContext))]
    [Migration("20210420175401_Second Validation")]
    partial class SecondValidation
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

                    b.Property<string>("AddedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Done")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoneDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DueDate")
                        .HasColumnType("nvarchar(max)");

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
