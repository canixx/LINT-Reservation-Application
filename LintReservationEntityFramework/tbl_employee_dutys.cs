//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbl_employee_dutys
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_employee_dutys()
        {
            this.tbl_employees = new HashSet<tbl_employees>();
        }
    
        public int ID { get; set; }
        public string DUTY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_employees> tbl_employees { get; set; }
    }
}
