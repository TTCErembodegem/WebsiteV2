﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Ttc.Model;

namespace Ttc.DataAccess
{
    public class TtcDbContext : DbContext
    {
        public TtcDbContext() : base("ttc")
        {
            Database.SetInitializer<TtcDbContext>(new TtcDbInitializer());
        }

        public DbSet<Ttc.Model.Speler> Spelers { get; set; }
        public DbSet<Ttc.Model.Match> Matches { get; set; }
        public DbSet<Ttc.Model.Club> Clubs { get; set; }
        public DbSet<Ttc.Model.ClubLokaal> ClubLokalen { get; set; }
        public DbSet<Ttc.Model.ClubPloeg> Ploegen { get; set; }
        public DbSet<Ttc.Model.ClubPloegSpeler> PloegSpelers { get; set; }
        public DbSet<Ttc.Model.ContactInfoClub> ContactInfo { get; set; }
        public DbSet<Ttc.Model.Klassement> Klassementen { get; set; }
        public DbSet<Ttc.Model.Reeks> Reeksen { get; set; }
        public DbSet<Ttc.Model.Training> Trainingen { get; set; }
        public DbSet<Ttc.Model.Verslag> Verslagen { get; set; }
        public DbSet<Ttc.Model.VerslagSpeler> SpelersVerslag { get; set; }
        public DbSet<Ttc.Model.WeekSpeler> SpelerVanDeWeek { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
