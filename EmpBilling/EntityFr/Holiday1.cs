//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpBilling.EntityFr
{
    using System;
    using System.Collections.Generic;
    
    public partial class Holiday1
    {
        public long Holiday_ID { get; set; }
        public Nullable<long> H_year { get; set; }
        public string State { get; set; }
        public string H_month { get; set; }
        public Nullable<System.DateTime> H_datetime { get; set; }
        public string Holiday_Name { get; set; }
        public Nullable<long> User_Id { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
