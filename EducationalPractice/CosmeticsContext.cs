using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EducationalPractice;

public partial class CosmeticsContext : DbContext
{
    public CosmeticsContext()
    {
    }

    public CosmeticsContext(DbContextOptions<CosmeticsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ClientsCorporate> ClientsCorporates { get; set; }

    public virtual DbSet<ClientsIndividual> ClientsIndividuals { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Cosmetics;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<ClientsCorporate>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__ClientsC__E67E1A04EF084251");

            entity.ToTable("ClientsCorporate");

            entity.Property(e => e.ClientId)
                .ValueGeneratedNever()
                .HasColumnName("ClientID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.BankAccount).HasMaxLength(255);
            entity.Property(e => e.Bic)
                .HasMaxLength(255)
                .HasColumnName("BIC");
            entity.Property(e => e.Ceoname)
                .HasMaxLength(255)
                .HasColumnName("CEOName");
            entity.Property(e => e.CompanyName).HasMaxLength(255);
            entity.Property(e => e.ContactPhone).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Inn)
                .HasMaxLength(255)
                .HasColumnName("INN");
            entity.Property(e => e.Password).HasMaxLength(255);
        });

        modelBuilder.Entity<ClientsIndividual>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK_Clients");

            entity.ToTable("ClientsIndividual");

            entity.Property(e => e.ClientId)
                .HasMaxLength(255)
                .HasColumnName("ClientID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.BirthDate).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FullName).HasMaxLength(255);
            entity.Property(e => e.PassportDate).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF1611D0180");

            entity.Property(e => e.EmployeeId)
                .HasMaxLength(255)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.FullName).HasMaxLength(255);
            entity.Property(e => e.LastLogin).HasMaxLength(255);
            entity.Property(e => e.Login).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Position).HasMaxLength(255);
            entity.Property(e => e.Services).HasColumnType("text");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orders__3214EC27F46B965B");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ClientId)
                .HasMaxLength(255)
                .HasColumnName("ClientID");
            entity.Property(e => e.ClosureDate).HasMaxLength(255);
            entity.Property(e => e.CreationDate).HasMaxLength(255);
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(255)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.ExecutionTime).HasMaxLength(255);
            entity.Property(e => e.OrderNumber).HasMaxLength(255);
            entity.Property(e => e.Services).HasColumnType("text");
            entity.Property(e => e.Status).HasMaxLength(255);

            entity.HasOne(d => d.Employee).WithMany(p => p.Orders)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Orders_ClientID");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Services__3214EC2727C43EAC");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AverageDeviation).HasMaxLength(255);
            entity.Property(e => e.ExecutionTime).HasMaxLength(255);
            entity.Property(e => e.Price).HasMaxLength(255);
            entity.Property(e => e.RusCosmeticsPrice).HasMaxLength(255);
            entity.Property(e => e.ServiceCode).HasMaxLength(255);
            entity.Property(e => e.ServiceName).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
