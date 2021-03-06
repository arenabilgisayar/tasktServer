﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tasktServer.Models
{
    public class tasktDatabaseContext : DbContext
    {
      protected override void OnConfiguring(DbContextOptionsBuilder contextBuilder)
        {
            if (!contextBuilder.IsConfigured)
            {

                var connection = DatabaseConfiguration.ConnectionString;
                contextBuilder.UseSqlServer(connection);
            }
        }
        public tasktDatabaseContext(DbContextOptions<tasktDatabaseContext> options)
            : base(options)
        { }
        public tasktDatabaseContext()
        { }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<WorkerPool> WorkerPools { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<PublishedScript> PublishedScripts { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<BotStoreModel> BotStore { get; set; }
        public DbSet<UserProfile> LoginProfiles { get; set; }
    }

    public static class DatabaseConfiguration
    {
        public static string ConnectionString { get; set; }
    }



}
