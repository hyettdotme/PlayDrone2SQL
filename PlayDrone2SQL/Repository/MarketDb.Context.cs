﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlayDrone2SQL.Repository
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class MarketDbContainer : DbContext
    {
        public MarketDbContainer()
            : base("name=MarketDbContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<App> Apps { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
