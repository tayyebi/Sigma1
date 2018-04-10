namespace Core.RexaModel.ADONET
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MainModel : DbContext
    {
        public MainModel()
            : base("name=MainModel")
        {
        }

        public virtual DbSet<AdminSet> AdminSet { get; set; }
        public virtual DbSet<CitySet> CitySet { get; set; }
        public virtual DbSet<DocumentSet> DocumentSet { get; set; }
        public virtual DbSet<EducationSet> EducationSet { get; set; }
        public virtual DbSet<JobSet> JobSet { get; set; }
        public virtual DbSet<Logger> Logger { get; set; }
        public virtual DbSet<PasswordSet> PasswordSet { get; set; }
        public virtual DbSet<ProvinceSet> ProvinceSet { get; set; }
        public virtual DbSet<ResumeSet> ResumeSet { get; set; }
        public virtual DbSet<UserSet> UserSet { get; set; }
        public virtual DbSet<AdminView> AdminView { get; set; }
        public virtual DbSet<DocumentView> DocumentView { get; set; }
        public virtual DbSet<EducationView> EducationView { get; set; }
        public virtual DbSet<JobView> JobView { get; set; }
        public virtual DbSet<PasswordView> PasswordView { get; set; }
        public virtual DbSet<ResumeView> ResumeView { get; set; }
        public virtual DbSet<UserPasswordView> UserPasswordView { get; set; }
        public virtual DbSet<UserView> UserView { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocumentSet>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Logger>()
                .HasOptional(e => e.AdminSet)
                .WithRequired(e => e.Logger);

            modelBuilder.Entity<Logger>()
                .HasOptional(e => e.DocumentSet)
                .WithRequired(e => e.Logger);

            modelBuilder.Entity<Logger>()
                .HasOptional(e => e.EducationSet)
                .WithRequired(e => e.Logger);

            modelBuilder.Entity<Logger>()
                .HasOptional(e => e.JobSet)
                .WithRequired(e => e.Logger);

            modelBuilder.Entity<Logger>()
                .HasOptional(e => e.ResumeSet)
                .WithRequired(e => e.Logger);

            modelBuilder.Entity<Logger>()
                .HasOptional(e => e.UserSet)
                .WithRequired(e => e.Logger);

            modelBuilder.Entity<ProvinceSet>()
                .HasMany(e => e.CitySet)
                .WithRequired(e => e.ProvinceSet)
                .HasForeignKey(e => e.ProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ResumeSet>()
                .HasMany(e => e.DocumentSet)
                .WithRequired(e => e.ResumeSet)
                .HasForeignKey(e => e.ResumeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ResumeSet>()
                .HasOptional(e => e.EducationSet)
                .WithRequired(e => e.ResumeSet);

            modelBuilder.Entity<ResumeSet>()
                .HasOptional(e => e.JobSet)
                .WithRequired(e => e.ResumeSet);

            modelBuilder.Entity<UserSet>()
                .HasOptional(e => e.AdminSet)
                .WithRequired(e => e.UserSet);

            modelBuilder.Entity<UserSet>()
                .HasMany(e => e.PasswordSet)
                .WithRequired(e => e.UserSet)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserSet>()
                .HasMany(e => e.ResumeSet)
                .WithRequired(e => e.UserSet)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentView>()
                .Property(e => e.Type)
                .IsUnicode(false);
        }
    }
}
