﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoanModule.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class masterEntities : DbContext
    {
        public masterEntities()
            : base("name=masterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Broker> Brokers { get; set; }
        public virtual DbSet<CountyList> CountyLists { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<LeadNote> LeadNotes { get; set; }
        public virtual DbSet<LoanTypeList> LoanTypeLists { get; set; }
        public virtual DbSet<MWFUser> MWFUsers { get; set; }
        public virtual DbSet<NewLead> NewLeads { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Realtor> Realtors { get; set; }
        public virtual DbSet<ReferFriend> ReferFriends { get; set; }
        public virtual DbSet<ReferralSource> ReferralSources { get; set; }
        public virtual DbSet<WebLead> WebLeads { get; set; }
    }
}