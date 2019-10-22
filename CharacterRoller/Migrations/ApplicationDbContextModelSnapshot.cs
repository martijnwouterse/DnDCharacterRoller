﻿// <auto-generated />
using System;
using CharacterRoller.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CharacterRoller.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CharacterRoller.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharismaBase");

                    b.Property<int>("ConstitutionBase");

                    b.Property<int>("DexterityBase");

                    b.Property<int>("Experience");

                    b.Property<string>("Expertises");

                    b.Property<int>("IntelligenceBase");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<string>("Proficiencies");

                    b.Property<int>("StrenghtBase");

                    b.Property<int>("WisdomBase");

                    b.Property<string>("characterClassId");

                    b.Property<string>("characterRaceId");

                    b.HasKey("Id");

                    b.HasIndex("characterClassId");

                    b.HasIndex("characterRaceId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("CharacterRoller.Models.Choice", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AllowedNumberOfOptions");

                    b.Property<string>("ChosenOptions");

                    b.Property<int>("Destination");

                    b.Property<string>("Options");

                    b.Property<bool>("resolved");

                    b.HasKey("Id");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("CharacterRoller.Models.Class", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AbilityScoreImprovements");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Classes");

                    b.HasData(
                        new { Id = "barbarian", Name = "Barbarian" },
                        new { Id = "bard", Name = "Bard" },
                        new { Id = "cleric", Name = "Cleric" },
                        new { Id = "druid", Name = "Druid" },
                        new { Id = "fighter", Name = "Fighter" },
                        new { Id = "monk", Name = "Monk" },
                        new { Id = "paladin", Name = "Paladin" },
                        new { Id = "ranger", Name = "Ranger" },
                        new { Id = "rogue", Name = "Rogue" },
                        new { Id = "sorcerer", Name = "Sorcerer" },
                        new { Id = "warlock", Name = "Warlock" },
                        new { Id = "wizard", Name = "Wizard" }
                    );
                });

            modelBuilder.Entity("CharacterRoller.Models.ClassFeature", b =>
                {
                    b.Property<string>("classFeatureId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<string>("Feature");

                    b.Property<int>("Level");

                    b.Property<string>("choiceId");

                    b.HasKey("classFeatureId");

                    b.HasIndex("choiceId");

                    b.ToTable("ClassFeatures");

                    b.HasData(
                        new { classFeatureId = "fighterProficiencyChoice", Class = "fighter", Feature = "Skills: Choose two Skills from Acrobatics, Animal Handling, Athletics, History, Insight, Intimidation, Perception, and Survival", Level = 0 }
                    );
                });

            modelBuilder.Entity("CharacterRoller.Models.Race", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AbilityScoreImprovements");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Races");

                    b.HasData(
                        new { Id = "human", AbilityScoreImprovements = "Strenght_1_Racial|Dexterity_1_Racial|Constitution_1_Racial|Intelligence_1_Racial|Wisdom_1_Racial|Charisma_1_Racial", Name = "Human" },
                        new { Id = "humanVariant", Name = "Human (Variant)" }
                    );
                });

            modelBuilder.Entity("CharacterRoller.Models.RaceFeature", b =>
                {
                    b.Property<string>("raceFeatureId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Feature");

                    b.Property<string>("race");

                    b.Property<string>("raceFeatureName");

                    b.HasKey("raceFeatureId");

                    b.ToTable("RaceFeatures");

                    b.HasData(
                        new { raceFeatureId = "1", Feature = "Your Ability Scores each increase by 1.", race = "human", raceFeatureName = "Abilities" },
                        new { raceFeatureId = "2", Feature = "Humans reach Adulthood in their late teens and live less than a century.", race = "human", raceFeatureName = "Age" },
                        new { raceFeatureId = "3", Feature = "Humans tend toward no particular Alignment. The best and the worst are found among them.", race = "human", raceFeatureName = "Alignment" },
                        new { raceFeatureId = "4", Feature = "Humans vary widely in height and build, from barely 5 feet to well over 6 feet tall. Regardless of your position in that range, your size is Medium.", race = "human", raceFeatureName = "Size" },
                        new { raceFeatureId = "5", Feature = "Your base walking speed is 30 feet.", race = "human", raceFeatureName = "Speed" },
                        new { raceFeatureId = "6", Feature = "You can speak, read, and write Common and one extra language of your choice. Humans typically learn the Languages of other peoples they deal with, including obscure dialects. They are fond of sprinkling their Speech with words borrowed from other tongues: Orc curses, Elvish musical expressions, Dwarvish Military phrases, and so on.", race = "human", raceFeatureName = "Languages" },
                        new { raceFeatureId = "7", Feature = "Two different ability scores of your choice increase by 1.", race = "humanVariant", raceFeatureName = "Abilities" },
                        new { raceFeatureId = "8", Feature = "You gain proficiency in one skill of your choice.", race = "humanVariant", raceFeatureName = "Skills" },
                        new { raceFeatureId = "9", Feature = "You gain one Feat of your choice.", race = "humanVariant", raceFeatureName = "Feat" },
                        new { raceFeatureId = "10", Feature = "Humans reach Adulthood in their late teens and live less than a century.", race = "humanVariant", raceFeatureName = "Age" },
                        new { raceFeatureId = "11", Feature = "Humans tend toward no particular Alignment. The best and the worst are found among them.", race = "humanVariant", raceFeatureName = "Alignment" },
                        new { raceFeatureId = "12", Feature = "Humans vary widely in height and build, from barely 5 feet to well over 6 feet tall. Regardless of your position in that range, your size is Medium.", race = "humanVariant", raceFeatureName = "Size" },
                        new { raceFeatureId = "13", Feature = "Your base walking speed is 30 feet.", race = "humanVariant", raceFeatureName = "Speed" },
                        new { raceFeatureId = "", Feature = "You can speak, read, and write Common and one extra language of your choice. Humans typically learn the Languages of other peoples they deal with, including obscure dialects. They are fond of sprinkling their Speech with words borrowed from other tongues: Orc curses, Elvish musical expressions, Dwarvish Military phrases, and so on.", race = "humanVariant", raceFeatureName = "Languages" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CharacterRoller.Models.Character", b =>
                {
                    b.HasOne("CharacterRoller.Models.Class", "characterClass")
                        .WithMany()
                        .HasForeignKey("characterClassId");

                    b.HasOne("CharacterRoller.Models.Race", "characterRace")
                        .WithMany()
                        .HasForeignKey("characterRaceId");
                });

            modelBuilder.Entity("CharacterRoller.Models.ClassFeature", b =>
                {
                    b.HasOne("CharacterRoller.Models.Choice", "Choice")
                        .WithMany()
                        .HasForeignKey("choiceId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
