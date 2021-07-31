using System;
using EVCharger.Base.Models.Models;
using EVCharger.Common.Protobuf;
using Microsoft.EntityFrameworkCore;

namespace EVCharger.DB
{
   public class ChargerContext : DbContext
   {
      public virtual DbSet<User> Users { get; set; }
      public virtual DbSet<Charger> Chargers { get; set; }
      public virtual DbSet<Constellation> Constellations { get; set; }
      public virtual DbSet<ChargingSession> ChargingSessions { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder
            .UseLazyLoadingProxies()
            .UseNpgsql(CommonSettings.SqlConnectionString);
   }
}