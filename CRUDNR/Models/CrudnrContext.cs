﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUDNR.Models;

public partial class CrudnrContext : DbContext
{
    public CrudnrContext()
    {
    }

    public CrudnrContext(DbContextOptions<CrudnrContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
 //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
 //      => optionsBuilder.UseSqlServer("server=DESKTOP-JGGJ636\\SQLEXPRESS; database=CRUDNR; Trusted_Connection=SSPI; Encrypt=false; TrustServerCertificate=true");

        }
     
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuarios__3214EC0743570B1B");

            entity.ToTable("usuarios");

            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
