﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230421203952_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Star Wars, conocida también en español como La guerra de las galaxias,7​8​9​ es una franquicia y universo compartido de fantasía compuesta primordialmente de una serie de películas concebidas por el cineasta estadounidense George Lucas en la década de 1970, y producidas y distribuidas inicialmente por 20th Century Fox y posteriormente por The Walt Disney Company a partir de 2012. Su trama describe las vivencias de un grupo de personajes que habitan en una galaxia ficticia e interactúan con elementos como «la Fuerza», un campo de energía metafísico y omnipresente10​ que posee un «lado luminoso» impulsado por la sabiduría, la nobleza y la justicia y utilizado por los Jedi, y un «lado oscuro» usado por los Sith y provocado por la ira, el miedo, el odio y la desesperación.",
                            ImageUrl = "https://es.web.img2.acsta.net/r_1280_720/pictures/bzp/01/25802.jpg",
                            Price = 9.9900000000000002,
                            Title = "Star Wars"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Fue la primera película que se estrenó de la saga Star Wars, y se ordena como la cuarta en términos de su cronología interna: dos filmes siguientes continuarían la trama de la trilogía original (El Imperio contraataca y El retorno del Jedi), mientras que otra trilogía (La amenaza fantasma, El ataque de los clones y La venganza de los Sith) describiría los eventos previos a La guerra de las galaxias, centrada en torno al antagonista principal Darth Vader. ",
                            ImageUrl = "https://m.media-amazon.com/images/I/81aA7hEEykL._AC_UF1000,1000_QL80_.jpg",
                            Price = 10.99,
                            Title = "Star Wars: Episodio IV - Una nueva esperanza"
                        },
                        new
                        {
                            Id = 3,
                            Description = "La ficción de la película se sitúa tres años después de la destrucción de la estación espacial de combate conocida como la Estrella de la Muerte, destrucción acaecida al final del episodio anterior, Una Nueva Esperanza, estrenada en el año 1977. En El Imperio contraataca Luke Skywalker, Han Solo, Leia Organa y el resto de la Alianza Rebelde son perseguidos por Darth Vader y las fuerzas de élite del Imperio Galáctico. En este episodio se desarrolla la historia de amor entre Han y Leia, mientras que Luke aprende más sobre los caminos de la Fuerza de la mano del maestro Yoda.",
                            ImageUrl = "https://es.web.img2.acsta.net/r_1280_720/pictures/bzp/01/25802.jpg",
                            Price = 12.99,
                            Title = "Star Wars: Episodio V - El Imperio contraataca"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
