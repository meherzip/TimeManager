namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbTimeManager : DbContext
    {
        public dbTimeManager()
            : base("name=dbTimeManager")
        {
        }

        public virtual DbSet<BonCommande> BonCommandes { get; set; }
        public virtual DbSet<BonCommandeEmployee> BonCommandeEmployees { get; set; }
        public virtual DbSet<Competance> Competances { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Contrat> Contrats { get; set; }
        public virtual DbSet<DemandeConge> DemandeConges { get; set; }
        public virtual DbSet<Domaine> Domaines { get; set; }
        public virtual DbSet<DomaineCompetance> DomaineCompetances { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeCompetance> EmployeeCompetances { get; set; }
        public virtual DbSet<EmployeeConge> EmployeeConges { get; set; }
        public virtual DbSet<EmployeeTypePrime> EmployeeTypePrimes { get; set; }
        public virtual DbSet<EtatBonCommande> EtatBonCommandes { get; set; }
        public virtual DbSet<EtatDemandeConge> EtatDemandeConges { get; set; }
        public virtual DbSet<Frai> Frais { get; set; }
        public virtual DbSet<GrilleSalaire> GrilleSalaires { get; set; }
        public virtual DbSet<JourTravaille> JourTravailles { get; set; }
        public virtual DbSet<PeriodeJour> PeriodeJours { get; set; }
        public virtual DbSet<PrioriteConge> PrioriteConges { get; set; }
        public virtual DbSet<Salaire> Salaires { get; set; }
        public virtual DbSet<Societe> Societes { get; set; }
        public virtual DbSet<SocieteContact> SocieteContacts { get; set; }
        public virtual DbSet<TypeCompetance> TypeCompetances { get; set; }
        public virtual DbSet<TypeConge> TypeConges { get; set; }
        public virtual DbSet<TypeEmployee> TypeEmployees { get; set; }
        public virtual DbSet<TypeFrai> TypeFrais { get; set; }
        public virtual DbSet<TypePrime> TypePrimes { get; set; }
        public virtual DbSet<TypeSociete> TypeSocietes { get; set; }
        public virtual DbSet<ValidationCRA> ValidationCRAs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Prenom)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Adresse)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.CodePostal)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.TelephonePortable)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.TelephoneFixe)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<ValidationCRA>()
                .Property(e => e.IdValidationCRA)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
