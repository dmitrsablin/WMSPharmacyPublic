using System.Data.Entity;
using WMSPharmacy.Properties;

namespace WMSPharmacy.Model
{
    public partial class WmsPharmacyContext : DbContext
    {
        public WmsPharmacyContext()
            : base(
                $@"data source={Settings.Default.AdressDB};initial catalog={Settings.Default.NameDB};persist security info=True;user id={Settings.Default.LoginDB};password={Settings.Default.PasswordDB};MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }
        public virtual DbSet<Medicines> Medicines { get; set; }
        public virtual DbSet<MedicinesTypes> MedicinesTypes { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturers>()
                .Property(e => e.ManufacturerName)
                .IsUnicode(false);

            modelBuilder.Entity<Manufacturers>()
                .HasMany(e => e.Medicines)
                .WithRequired(e => e.Manufacturers)
                .HasForeignKey(e => e.Manufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Medicines>()
                .Property(e => e.MedicineName)
                .IsUnicode(false);

            modelBuilder.Entity<Medicines>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Medicines>()
                .Property(e => e.Structure)
                .IsUnicode(false);

            modelBuilder.Entity<Medicines>()
                .Property(e => e.Diseases)
                .IsUnicode(false);

            modelBuilder.Entity<Medicines>()
                .HasMany(e => e.History)
                .WithRequired(e => e.Medicines1)
                .HasForeignKey(e => e.Medicines)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicinesTypes>()
                .Property(e => e.MedicinesTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<MedicinesTypes>()
                .HasMany(e => e.Medicines)
                .WithRequired(e => e.MedicinesTypes)
                .HasForeignKey(e => e.MedicinesType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserRoles>()
                .Property(e => e.NameRole)
                .IsUnicode(false);

            modelBuilder.Entity<UserRoles>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.UserRoles)
                .HasForeignKey(e => e.UserRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.History)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserName)
                .WillCascadeOnDelete(false);
        }
    }
}
