﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace frmYeniHesapwEntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HayyamDB : DbContext
    {
        public HayyamDB()
            : base("name=HayyamDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_bill> tbl_bill { get; set; }
        public virtual DbSet<tbl_bill_payment> tbl_bill_payment { get; set; }
        public virtual DbSet<tbl_categories> tbl_categories { get; set; }
        public virtual DbSet<tbl_customers> tbl_customers { get; set; }
        public virtual DbSet<tbl_employee_actions> tbl_employee_actions { get; set; }
        public virtual DbSet<tbl_employee_dutys> tbl_employee_dutys { get; set; }
        public virtual DbSet<tbl_employees> tbl_employees { get; set; }
        public virtual DbSet<tbl_payment_type> tbl_payment_type { get; set; }
        public virtual DbSet<tbl_products> tbl_products { get; set; }
        public virtual DbSet<tbl_reservations> tbl_reservations { get; set; }
        public virtual DbSet<tbl_sales> tbl_sales { get; set; }
        public virtual DbSet<tbl_tables> tbl_tables { get; set; }
    }
}
