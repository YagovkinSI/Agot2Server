﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GamePortal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GamePortalEntities : DbContext
    {
        public GamePortalEntities()
            : base("name=GamePortalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ApiUser> ApiUsers { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<SpecialUser> SpecialUsers { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGame> UserGames { get; set; }
        public virtual DbSet<UserLike> UserLikes { get; set; }
        public virtual DbSet<OnlineCounter> OnlineCounters { get; set; }
    }
}
