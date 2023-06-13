﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_Esquema.Data;

#nullable disable

namespace Proyecto_Esquema.Migrations
{
    [DbContext(typeof(Proyecto_EsquemaContext))]
    [Migration("20230613005945_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proyecto_Esquema.Model.Adoptante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Id_Entrega")
                        .HasColumnType("int");

                    b.Property<int>("Id_Persona")
                        .HasColumnType("int");

                    b.Property<string>("LugarEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Adoptante");
                });

            modelBuilder.Entity("Proyecto_Esquema.Model.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdoptanteID")
                        .HasColumnType("int");

                    b.Property<string>("ApellidoPerson")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("DireccionPerson")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("FechaPerson")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("NombrePerson")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("SexoPerson")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("AdoptanteID");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("Proyecto_Esquema.Model.Persona", b =>
                {
                    b.HasOne("Proyecto_Esquema.Model.Adoptante", "Adoptante")
                        .WithMany()
                        .HasForeignKey("AdoptanteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adoptante");
                });
#pragma warning restore 612, 618
        }
    }
}
