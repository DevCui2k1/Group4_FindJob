﻿using FindJobSolution.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var roleId = new Guid("70E7A246-E168-45E9-B78C-6F66B23F4633");
            var adminId = new Guid("D1A052BE-B2E2-4DBF-8778-DA82A7BBCB98");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin"
            });
            var roleJobseekerId = new Guid("728D69EC-5FF4-4688-9107-D8906B264F79");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleJobseekerId,
                Name = "JobSeeker",
                NormalizedName = "JobSeeker"
            });

            var roleRecuiterId = new Guid("F91C93E9-5527-4162-B7C5-DD3CBA713A49");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleRecuiterId,
                Name = "Recuiter",
                NormalizedName = "Recuiter"
            });

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = string.Empty,
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "home", Value = "this is home" },
                new AppConfig() { Key = "keywork", Value = "this is keywork" }
                );

            modelBuilder.Entity<Job>().HasData(
                new Job() { JobId = 1, JobName = "IT" },
                new Job() { JobId = 2, JobName = "Marketing" }
                );
        }
    }
}