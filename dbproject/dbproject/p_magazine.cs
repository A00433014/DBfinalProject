//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dbproject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class p_magazine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public p_magazine()
        {
            this.p_publication = new HashSet<p_publication>();
        }
        [DisplayName("Magazine ID")]
        public int magazine_id { get; set; }
        [DisplayName("Magazine Name")]
        public string magazine_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<p_publication> p_publication { get; set; }
    }
}
