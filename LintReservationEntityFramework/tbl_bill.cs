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
    
    public partial class tbl_bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_bill()
        {
            this.tbl_bill_payment = new HashSet<tbl_bill_payment>();
            this.tbl_sales = new HashSet<tbl_sales>();
        }
    
        public int ID { get; set; }
        public Nullable<int> EMPLOYEE_ID { get; set; }
        public Nullable<int> TABLE_ID { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public Nullable<bool> STATUS { get; set; }
    
        public virtual tbl_tables tbl_tables { get; set; }
        public virtual tbl_employees tbl_employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_bill_payment> tbl_bill_payment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_sales> tbl_sales { get; set; }
    }
}
