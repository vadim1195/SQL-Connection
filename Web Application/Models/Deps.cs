//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Application.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Deps
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Deps()
        {
            this.Emps = new HashSet<Emps>();
        }
    
        public int DepartamentID { get; set; }
        public string DepartamentName { get; set; }
        public int EmployeesCount { get; set; }
        public int OfID { get; set; }
    
        public virtual Offices Offices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emps> Emps { get; set; }
    }
}
