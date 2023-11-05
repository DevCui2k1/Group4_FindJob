﻿// <auto-generated />
using System;
using FindJobSolution.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FindJobSolution.Data.Migrations
{
    [DbContext(typeof(FindJobDBContext))]
    [Migration("20221202043924_reportidentity")]
    partial class reportidentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FindJobSolution.Data.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfigs", (string)null);

                    b.HasData(
                        new
                        {
                            Key = "home",
                            Value = "this is home"
                        },
                        new
                        {
                            Key = "keywork",
                            Value = "this is keywork"
                        });
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.ApplyJob", b =>
                {
                    b.Property<int>("JobSeekerId")
                        .HasColumnType("int");

                    b.Property<int>("JobInformationId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<DateTime>("TimeApply")
                        .HasColumnType("datetime2");

                    b.HasKey("JobSeekerId", "JobInformationId");

                    b.HasIndex("JobInformationId");

                    b.ToTable("ApplyJobs", (string)null);
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("70e7a246-e168-45e9-b78c-6f66b23f4633"),
                            ConcurrencyStamp = "72698436-a03a-4ad6-9ebe-ac98c0002f39",
                            Name = "admin",
                            NormalizedName = "admin"
                        },
                        new
                        {
                            Id = new Guid("728d69ec-5ff4-4688-9107-d8906b264f79"),
                            ConcurrencyStamp = "acecfeb8-b639-4660-aac7-b70aef1f073f",
                            Name = "JobSeeker",
                            NormalizedName = "JobSeeker"
                        },
                        new
                        {
                            Id = new Guid("f91c93e9-5527-4162-b7c5-dd3cba713a49"),
                            ConcurrencyStamp = "b003ec6f-72fb-45ed-bd49-e5e7a65647ab",
                            Name = "Recuiter",
                            NormalizedName = "Recuiter"
                        });
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.Avatar", b =>
                {
                    b.Property<int>("AvatarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AvatarId"), 1L, 1);

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<int>("JobSeekerId")
                        .HasColumnType("int");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timespan")
                        .HasColumnType("datetime2");

                    b.HasKey("AvatarId");

                    b.HasIndex("JobSeekerId")
                        .IsUnique();

                    b.ToTable("Avatars", (string)null);
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.Cv", b =>
                {
                    b.Property<int>("CvId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CvId"), 1L, 1);

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<int>("JobSeekerId")
                        .HasColumnType("int");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timespan")
                        .HasColumnType("datetime2");

                    b.HasKey("CvId");

                    b.HasIndex("JobSeekerId");

                    b.ToTable("CVs", (string)null);
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobId"), 1L, 1);

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobId");

                    b.ToTable("Jobs", (string)null);

                    b.HasData(
                        new
                        {
                            JobId = 1,
                            JobName = "IT"
                        },
                        new
                        {
                            JobId = 2,
                            JobName = "Marketing"
                        });
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.JobInformation", b =>
                {
                    b.Property<int>("JobInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobInformationId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<DateTime>("JobInformationTimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("JobInformationTimeStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MaxSalary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("MinSalary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<int>("RecruiterId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<int>("ViewCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("WorkingLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobInformationId");

                    b.HasIndex("JobId");

                    b.HasIndex("RecruiterId");

                    b.ToTable("JobInformations", (string)null);
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.JobSeeker", b =>
                {
                    b.Property<int>("JobSeekerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobSeekerId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DesiredSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("National")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("JobSeekerId");

                    b.HasIndex("JobId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("JobSeekers", (string)null);
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.JobSeekerOldCompany", b =>
                {
                    b.Property<int>("JobSeekerOldCompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobSeekerOldCompanyId"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobSeekerId")
                        .HasColumnType("int");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkExperience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobSeekerOldCompanyId");

                    b.HasIndex("JobSeekerId");

                    b.ToTable("JobSeekerOldCompanys", (string)null);
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.JobSeekerSkill", b =>
                {
                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<int>("JobSeekerId")
                        .HasColumnType("int");

                    b.HasKey("SkillId", "JobSeekerId");

                    b.HasIndex("JobSeekerId");

                    b.ToTable("JobSeekerSkills", (string)null);
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.Recruiter", b =>
                {
                    b.Property<int>("RecruiterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecruiterId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyIntroduction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("RecruiterId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Recruiters", (string)null);
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.RecruiterImages", b =>
                {
                    b.Property<int>("RecruiterImagesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecruiterImagesId"), 1L, 1);

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<int>("RecruiterId")
                        .HasColumnType("int");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("RecruiterImagesId");

                    b.HasIndex("RecruiterId");

                    b.ToTable("RecruiterImages", (string)null);
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reports", (string)null);
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.SaveJob", b =>
                {
                    b.Property<int>("JobSeekerId")
                        .HasColumnType("int");

                    b.Property<int>("JobInformationId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<DateTime>("TimeSave")
                        .HasColumnType("datetime2");

                    b.HasKey("JobSeekerId", "JobInformationId");

                    b.HasIndex("JobInformationId");

                    b.ToTable("SaveJobs", (string)null);
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"), 1L, 1);

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.ToTable("Skills", (string)null);
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d1a052be-b2e2-4dbf-8778-da82a7bbcb98"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "799d3db8-35fe-4a51-9467-dc50a9a2cb87",
                            Email = "thanh26092000@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "thanh26092000@gmail.com",
                            NormalizedUserName = "Lxthanh",
                            PasswordHash = "AQAAAAEAACcQAAAAEG5xGHHrUxW1jmaznULbqxoKVJTRyjxV7BPkffh1i/MbeNf/EqT2QoDcsejb7w9GZA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Lxthanh"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("70e7a246-e168-45e9-b78c-6f66b23f4633"),
                            UserId = new Guid("d1a052be-b2e2-4dbf-8778-da82a7bbcb98")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.ApplyJob", b =>
                {
                    b.HasOne("FindJobSolution.Data.Entities.JobInformation", "JobInformation")
                        .WithMany("ApplyJobs")
                        .HasForeignKey("JobInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FindJobSolution.Data.Entities.JobSeeker", "JobSeeker")
                        .WithMany("ApplyJobs")
                        .HasForeignKey("JobSeekerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("JobInformation");

                    b.Navigation("JobSeeker");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.Avatar", b =>
                {
                    b.HasOne("FindJobSolution.Data.Entities.JobSeeker", "JobSeeker")
                        .WithOne("Avatar")
                        .HasForeignKey("FindJobSolution.Data.Entities.Avatar", "JobSeekerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobSeeker");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.Cv", b =>
                {
                    b.HasOne("FindJobSolution.Data.Entities.JobSeeker", "JobSeeker")
                        .WithMany("Cvs")
                        .HasForeignKey("JobSeekerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobSeeker");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.JobInformation", b =>
                {
                    b.HasOne("FindJobSolution.Data.Entities.Job", "Job")
                        .WithMany("JobInformation")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FindJobSolution.Data.Entities.Recruiter", "Recruiter")
                        .WithMany("JobInformation")
                        .HasForeignKey("RecruiterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("Recruiter");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.JobSeeker", b =>
                {
                    b.HasOne("FindJobSolution.Data.Entities.Job", "Job")
                        .WithMany("JobSeekers")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FindJobSolution.Data.Entities.User", "Users")
                        .WithOne("JobSeeker")
                        .HasForeignKey("FindJobSolution.Data.Entities.JobSeeker", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.JobSeekerOldCompany", b =>
                {
                    b.HasOne("FindJobSolution.Data.Entities.JobSeeker", "JobSeeker")
                        .WithMany("JobSeekerOldCompanies")
                        .HasForeignKey("JobSeekerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobSeeker");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.JobSeekerSkill", b =>
                {
                    b.HasOne("FindJobSolution.Data.Entities.JobSeeker", "JobSeeker")
                        .WithMany("JobSeekerSkills")
                        .HasForeignKey("JobSeekerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FindJobSolution.Data.Entities.Skill", "Skill")
                        .WithMany("JobSeekerSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobSeeker");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.Recruiter", b =>
                {
                    b.HasOne("FindJobSolution.Data.Entities.User", "Users")
                        .WithOne("Recruiter")
                        .HasForeignKey("FindJobSolution.Data.Entities.Recruiter", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.RecruiterImages", b =>
                {
                    b.HasOne("FindJobSolution.Data.Entities.Recruiter", "Recruiter")
                        .WithMany("RecruiterImages")
                        .HasForeignKey("RecruiterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recruiter");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.SaveJob", b =>
                {
                    b.HasOne("FindJobSolution.Data.Entities.JobInformation", "JobInformation")
                        .WithMany("SaveJobs")
                        .HasForeignKey("JobInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FindJobSolution.Data.Entities.JobSeeker", "JobSeeker")
                        .WithMany("SaveJobs")
                        .HasForeignKey("JobSeekerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("JobInformation");

                    b.Navigation("JobSeeker");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.Job", b =>
                {
                    b.Navigation("JobInformation");

                    b.Navigation("JobSeekers");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.JobInformation", b =>
                {
                    b.Navigation("ApplyJobs");

                    b.Navigation("SaveJobs");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.JobSeeker", b =>
                {
                    b.Navigation("ApplyJobs");

                    b.Navigation("Avatar")
                        .IsRequired();

                    b.Navigation("Cvs");

                    b.Navigation("JobSeekerOldCompanies");

                    b.Navigation("JobSeekerSkills");

                    b.Navigation("SaveJobs");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.Recruiter", b =>
                {
                    b.Navigation("JobInformation");

                    b.Navigation("RecruiterImages");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.Skill", b =>
                {
                    b.Navigation("JobSeekerSkills");
                });

            modelBuilder.Entity("FindJobSolution.Data.Entities.User", b =>
                {
                    b.Navigation("JobSeeker")
                        .IsRequired();

                    b.Navigation("Recruiter")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
