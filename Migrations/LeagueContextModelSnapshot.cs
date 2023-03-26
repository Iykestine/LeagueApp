﻿// <auto-generated />
using System;
using LeagueApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeagueApp.Migrations
{
    [DbContext(typeof(LeagueContext))]
    partial class LeagueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("LeagueApp.Models.Conference", b =>
                {
                    b.Property<string>("ConferenceId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LeagueId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ConferenceId");

                    b.HasIndex("LeagueId");

                    b.ToTable("Conference");
                });

            modelBuilder.Entity("LeagueApp.Models.Division", b =>
                {
                    b.Property<string>("DivisionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConferenceId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("DivisionId");

                    b.HasIndex("ConferenceId");

                    b.ToTable("Division");
                });

            modelBuilder.Entity("LeagueApp.Models.League", b =>
                {
                    b.Property<string>("LeagueId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("LeagueId");

                    b.ToTable("League");
                });

            modelBuilder.Entity("LeagueApp.Models.Player", b =>
                {
                    b.Property<string>("PlayerId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("College")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Depth")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DraftPick")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DraftRound")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DraftYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Experience")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Position")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeamId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("LeagueApp.Models.Team", b =>
                {
                    b.Property<string>("TeamId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("DivisionId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<int>("Loss")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PointsAgainst")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PointsFor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Stadium")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tie")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Win")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.HasKey("TeamId");

                    b.HasIndex("DivisionId");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("LeagueApp.Models.Conference", b =>
                {
                    b.HasOne("LeagueApp.Models.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId");

                    b.Navigation("League");
                });

            modelBuilder.Entity("LeagueApp.Models.Division", b =>
                {
                    b.HasOne("LeagueApp.Models.Conference", "Conference")
                        .WithMany()
                        .HasForeignKey("ConferenceId");

                    b.Navigation("Conference");
                });

            modelBuilder.Entity("LeagueApp.Models.Player", b =>
                {
                    b.HasOne("LeagueApp.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("LeagueApp.Models.Team", b =>
                {
                    b.HasOne("LeagueApp.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId");

                    b.Navigation("Division");
                });

            modelBuilder.Entity("LeagueApp.Models.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
