

using EF_CORE_Query_Homework.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EF_CORE_Query_Homework.Contexts;

public class DebtorDBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-QCDM367\SQLEXPRESS;Initial Catalog=QueryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False");
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Debtor> Debtors { get; set; }

 }
