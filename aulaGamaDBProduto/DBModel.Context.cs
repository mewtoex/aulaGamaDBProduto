﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aulaGamaDBProduto
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gamaProdutoEntities : DbContext
    {
        public gamaProdutoEntities()
            : base("name=gamaProdutoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alimento> alimentoes { get; set; }
        public virtual DbSet<eletrodomestico> eletrodomesticoes { get; set; }
        public virtual DbSet<produto> produtoes { get; set; }
    }
}
