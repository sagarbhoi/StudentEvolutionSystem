﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentEvolutionSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentEvolutionSystemEntities : DbContext
    {
        public StudentEvolutionSystemEntities()
            : base("name=StudentEvolutionSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<assign_fac_sub> assign_fac_sub { get; set; }
        public virtual DbSet<assign_fac_sub_batch> assign_fac_sub_batch { get; set; }
        public virtual DbSet<assign_task> assign_task { get; set; }
        public virtual DbSet<faculty_login> faculty_login { get; set; }
        public virtual DbSet<mentor_login> mentor_login { get; set; }
        public virtual DbSet<sa_login> sa_login { get; set; }
        public virtual DbSet<sem_sub> sem_sub { get; set; }
        public virtual DbSet<student_login> student_login { get; set; }
        public virtual DbSet<task_cheched> task_cheched { get; set; }
        public virtual DbSet<task_checked_set> task_checked_set { get; set; }
        public virtual DbSet<student_batch> student_batch { get; set; }
    }
}
