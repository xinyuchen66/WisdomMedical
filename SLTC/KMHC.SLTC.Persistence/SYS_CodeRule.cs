//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KMHC.SLTC.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_CodeRule
    {
        public int CodeRuleID { get; set; }
        public Nullable<int> OrganizationID { get; set; }
        public string CodeKey { get; set; }
        public string FlagRule { get; set; }
        public string GenerateRule { get; set; }
        public string Flag { get; set; }
        public int SerialNumber { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}