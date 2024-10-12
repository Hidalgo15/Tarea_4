﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Tarea_4.Migrations
{
    [DbContext(typeof(SerieContext))]
    partial class SerieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Personaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apodo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Foto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Poder_caracteristico")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Serie_Libro_Pelicula_Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeriesPeliculasLibrosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SeriesPeliculasLibrosId");

                    b.ToTable("Personaje");
                });

            modelBuilder.Entity("SeriePeliculasLibro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lenguage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Resumen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SeriePeliculasLibros");
                });

            modelBuilder.Entity("Personaje", b =>
                {
                    b.HasOne("SeriePeliculasLibro", "SeriesPeliculasLibros")
                        .WithMany("personajes")
                        .HasForeignKey("SeriesPeliculasLibrosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SeriesPeliculasLibros");
                });

            modelBuilder.Entity("SeriePeliculasLibro", b =>
                {
                    b.Navigation("personajes");
                });
#pragma warning restore 612, 618
        }
    }
}
