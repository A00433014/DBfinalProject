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
    
    public partial class p_expense_cat
    {
        public int C_id { get; set; }
        public string category_name { get; set; }
    
        public virtual p_other_expense p_other_expense { get; set; }
    }
}