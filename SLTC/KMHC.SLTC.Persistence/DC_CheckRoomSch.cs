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
    
    public partial class DC_CheckRoomSch
    {
        public int CheckSchID { get; set; }
        public int CheckRoomID { get; set; }
        public int PNCID { get; set; }
        public int ServiceItemID { get; set; }
        public string ServiceSchAdd { get; set; }
        public string BeginTime { get; set; }
        public int Limit { get; set; }
        public int SameTimeExecQty { get; set; }
        public int OrganizationID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual DC_CheckRoom DC_CheckRoom { get; set; }
        public virtual DC_PNC DC_PNC { get; set; }
        public virtual DC_ServiceItem DC_ServiceItem { get; set; }
    }
}