namespace KaficBeertija
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KaficDB : DbContext
    {
        public KaficDB()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Artikl> Artikl { get; set; }
        public virtual DbSet<Dobavljac> Dobavljac { get; set; }
        public virtual DbSet<Kafic> Kafic { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Narudzbenica> Narudzbenica { get; set; }
        public virtual DbSet<Racuni> Racuni { get; set; }
        public virtual DbSet<Statistika_rada> Statistika_rada { get; set; }
        public virtual DbSet<Stavke_narudzbenice> Stavke_narudzbenice { get; set; }
        public virtual DbSet<Stavke_racuna> Stavke_racuna { get; set; }
        public virtual DbSet<Tip_korisnika> Tip_korisnika { get; set; }
        public virtual DbSet<Vrsta_artikla> Vrsta_artikla { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artikl>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Artikl>()
                .HasMany(e => e.Stavke_narudzbenice)
                .WithRequired(e => e.Artikl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Artikl>()
                .HasMany(e => e.Stavke_racuna)
                .WithRequired(e => e.Artikl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dobavljac>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Dobavljac>()
                .Property(e => e.OIB)
                .IsUnicode(false);

            modelBuilder.Entity<Dobavljac>()
                .Property(e => e.Adresa)
                .IsUnicode(false);

            modelBuilder.Entity<Dobavljac>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Dobavljac>()
                .HasMany(e => e.Narudzbenica)
                .WithRequired(e => e.Dobavljac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kafic>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Kafic>()
                .Property(e => e.Adresa)
                .IsUnicode(false);

            modelBuilder.Entity<Kafic>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Kafic>()
                .Property(e => e.OIB)
                .IsUnicode(false);

            modelBuilder.Entity<Kafic>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Kafic>()
                .Property(e => e.IBAN)
                .IsUnicode(false);

            modelBuilder.Entity<Kafic>()
                .HasMany(e => e.Narudzbenica)
                .WithRequired(e => e.Kafic)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Grad)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Adresa)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Narudzbenica)
                .WithRequired(e => e.Korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Statistika_rada)
                .WithRequired(e => e.Korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Narudzbenica>()
                .HasMany(e => e.Stavke_narudzbenice)
                .WithRequired(e => e.Narudzbenica)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Racuni>()
                .HasMany(e => e.Stavke_racuna)
                .WithOptional(e => e.Racuni)
                .HasForeignKey(e => e.ID_racun);

            modelBuilder.Entity<Tip_korisnika>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Tip_korisnika>()
                .Property(e => e.Opis)
                .IsUnicode(false);

            modelBuilder.Entity<Tip_korisnika>()
                .HasMany(e => e.Korisnik)
                .WithRequired(e => e.Tip_korisnika)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vrsta_artikla>()
                .Property(e => e.Vrsta)
                .IsUnicode(false);

            modelBuilder.Entity<Vrsta_artikla>()
                .HasMany(e => e.Artikl)
                .WithRequired(e => e.Vrsta_artikla)
                .WillCascadeOnDelete(false);
        }
    }
}
