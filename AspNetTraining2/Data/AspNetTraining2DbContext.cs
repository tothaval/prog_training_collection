using System;
using System.Collections.Generic;
using AspNetTraining2.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetTraining2.Data;

public class AspNetTraining2DbContext : DbContext
{

    public AspNetTraining2DbContext(DbContextOptions<AspNetTraining2DbContext> options)
        : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<SerialNumber> SerialNumbers { get; set; }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<ItemClient> ItemClients { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Data Source=AvalonDystopia;Initial Catalog=AspNetTraining2DB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemClient>().HasKey(ic => new
        {
            ic.ItemId,
            ic.ClientId
        });

        modelBuilder.Entity<ItemClient>().HasOne(i => i.Item).WithMany(ic => ic.ItemClients).HasForeignKey(i => i.ItemId);
        modelBuilder.Entity<ItemClient>().HasOne(i => i.Client).WithMany(ic => ic.ItemClients).HasForeignKey(i => i.ClientId);

        modelBuilder.Entity<Item>().HasData(
            new Item { Id = 13, Name = "microphone", Price = 40, SerialNumberId = 10 }
            );

        modelBuilder.Entity<SerialNumber>().HasData(
    new SerialNumber { Id = 10, Name = "MIC150", ItemId = 13 }
    );

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Pizza" },
            new Category { Id = 3, Name = "Books" }
            );

        base.OnModelCreating(modelBuilder);
    }

}
