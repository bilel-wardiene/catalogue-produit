﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCatalogueProduit.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CATALOGUE_Entities : DbContext
    {
        public CATALOGUE_Entities()
            : base("name=CATALOGUE_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CAT_CATEGORIE> CAT_CATEGORIE { get; set; }
        public virtual DbSet<CAT_PRODUIT> CAT_PRODUIT { get; set; }
        public virtual DbSet<user> user { get; set; }
    }
}