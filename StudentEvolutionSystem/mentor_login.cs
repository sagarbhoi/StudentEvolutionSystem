//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class mentor_login
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mentor_login()
        {
            this.assign_fac_sub = new HashSet<assign_fac_sub>();
            this.assign_fac_sub_batch = new HashSet<assign_fac_sub_batch>();
            this.assign_task = new HashSet<assign_task>();
            this.student_login = new HashSet<student_login>();
        }
    
        public int m_id { get; set; }
        public int c_id { get; set; }
        public int f_id { get; set; }
        public int sem { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assign_fac_sub> assign_fac_sub { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assign_fac_sub_batch> assign_fac_sub_batch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assign_task> assign_task { get; set; }
        public virtual faculty_login faculty_login { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student_login> student_login { get; set; }
    }
}
