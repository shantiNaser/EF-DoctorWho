using System;
using Microsoft.EntityFrameworkCore;


namespace EF_DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        public DbSet<tblEnemy> tblEnemy { get; set; }
        public DbSet<tblAuthor> tblAuthor { get; set; }
        public DbSet<tblCompanion> tblCompanion { get; set; }
        public DbSet<tblDoctor> tblDoctor { get; set; }
        public DbSet<tblEpisode> tblEpisode { get; set; }
        public DbSet<tblEpisodeCompanion> tblEpisodeCompanion { get; set; }
        public DbSet<tblEpisodeEnemy> tblEpisodeEnemy { get; set; }
        public DbSet<EpisodesView> viewEpisodes { get; set; }
        public DbSet<CompanionsFunction> fnCompanionss { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Server=localhost,1433; Database=DoctorWhoCore;User=sa; Password=NaserSQL123");
        }


        public int CompanionsFunctionResult(int customerId)
                => throw new NotSupportedException();



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EpisodesView>()
                        .HasNoKey()
                        .ToView("viewEpisodes");

            modelBuilder.Entity<CompanionsFunction>()
                        .HasNoKey()
                        .ToFunction("fnCompanions");


        }



    }
}