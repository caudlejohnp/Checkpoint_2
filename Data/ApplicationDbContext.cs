﻿using AutoMapper.Configuration;
using capstone.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.Data
{

    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public IConfiguration Configuration { get; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<JusticeLeagueMember> JusticeLeagueMembers { get; set; }
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }
        public ApplicationDbContext() : base(new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite("Data Source=app.db").Options,null)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<JusticeLeagueMember>()
                .HasData(
                new JusticeLeagueMember
                {
                    Id = 1,
                    Name = "Superman",
                    Alias = "Clark Kent",
                    Age = 45,
                    MemberSince = new DateTime(1950, 1, 15),
                    IsActiveMember = true,
                    UserId = "56bdddab-0486-48db-9aa8-9e95dd50d60b"
                },
                new JusticeLeagueMember
                {
                    Id = 2,
                    Name = "Batman",
                    Alias = "Bruce Wayne",
                    Age = 43,
                    MemberSince = new DateTime(1950, 1, 15),
                    IsActiveMember = true,
                    UserId = "56bdddab-0486-48db-9aa8-9e95dd50d60b"
                },
                new JusticeLeagueMember
                {
                    Id = 3,
                    Name = "Wonder Woman",
                    Alias = "Diana Prince",
                    Age = 38,
                    MemberSince = new DateTime(1950, 1, 15),
                    IsActiveMember = true,
                    UserId = "56bdddab-0486-48db-9aa8-9e95dd50d60b"
                });
            base.OnModelCreating(builder);
        }
    }
}
