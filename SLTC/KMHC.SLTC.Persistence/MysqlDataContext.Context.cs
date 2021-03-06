﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class SltcDbContext : DbContext
    {
        public SltcDbContext()
            : base("name=SltcDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DC_ActivityNew> DC_ActivityNew { get; set; }
        public virtual DbSet<DC_Armarium> DC_Armarium { get; set; }
        public virtual DbSet<DC_Bill> DC_Bill { get; set; }
        public virtual DbSet<DC_CallInfo> DC_CallInfo { get; set; }
        public virtual DbSet<DC_ChargeItem> DC_ChargeItem { get; set; }
        public virtual DbSet<DC_CheckRoom> DC_CheckRoom { get; set; }
        public virtual DbSet<DC_CheckRoomQueue> DC_CheckRoomQueue { get; set; }
        public virtual DbSet<DC_CheckRoomQueueRec> DC_CheckRoomQueueRec { get; set; }
        public virtual DbSet<DC_CheckRoomSch> DC_CheckRoomSch { get; set; }
        public virtual DbSet<DC_CommodityItem> DC_CommodityItem { get; set; }
        public virtual DbSet<DC_CommodityType> DC_CommodityType { get; set; }
        public virtual DbSet<DC_Contract> DC_Contract { get; set; }
        public virtual DbSet<DC_Deposit> DC_Deposit { get; set; }
        public virtual DbSet<DC_Device> DC_Device { get; set; }
        public virtual DbSet<DC_DispathTaskRecord> DC_DispathTaskRecord { get; set; }
        public virtual DbSet<DC_Evaluation> DC_Evaluation { get; set; }
        public virtual DbSet<DC_Family> DC_Family { get; set; }
        public virtual DbSet<DC_FeedBack> DC_FeedBack { get; set; }
        public virtual DbSet<DC_FeeDetail> DC_FeeDetail { get; set; }
        public virtual DbSet<DC_GroupActivityCategory> DC_GroupActivityCategory { get; set; }
        public virtual DbSet<DC_GroupActivityItem> DC_GroupActivityItem { get; set; }
        public virtual DbSet<DC_GroupActivityRecord> DC_GroupActivityRecord { get; set; }
        public virtual DbSet<DC_Habit> DC_Habit { get; set; }
        public virtual DbSet<DC_MonitorItem> DC_MonitorItem { get; set; }
        public virtual DbSet<DC_MonitorResult> DC_MonitorResult { get; set; }
        public virtual DbSet<DC_MonitorTemplate> DC_MonitorTemplate { get; set; }
        public virtual DbSet<DC_OrderCItem> DC_OrderCItem { get; set; }
        public virtual DbSet<DC_Payment> DC_Payment { get; set; }
        public virtual DbSet<DC_Person> DC_Person { get; set; }
        public virtual DbSet<DC_PNC> DC_PNC { get; set; }
        public virtual DbSet<DC_PriorityRemark> DC_PriorityRemark { get; set; }
        public virtual DbSet<DC_RefundRecord> DC_RefundRecord { get; set; }
        public virtual DbSet<DC_Resident> DC_Resident { get; set; }
        public virtual DbSet<DC_ResidentAddress> DC_ResidentAddress { get; set; }
        public virtual DbSet<DC_ResidentServicePlan> DC_ResidentServicePlan { get; set; }
        public virtual DbSet<DC_ResidentServicePlanItem> DC_ResidentServicePlanItem { get; set; }
        public virtual DbSet<DC_SerAppSerIt> DC_SerAppSerIt { get; set; }
        public virtual DbSet<DC_SerGrpSerIt> DC_SerGrpSerIt { get; set; }
        public virtual DbSet<DC_SerOrdSerIt> DC_SerOrdSerIt { get; set; }
        public virtual DbSet<DC_ServiceAppointment> DC_ServiceAppointment { get; set; }
        public virtual DbSet<DC_ServiceGroup> DC_ServiceGroup { get; set; }
        public virtual DbSet<DC_ServiceItem> DC_ServiceItem { get; set; }
        public virtual DbSet<DC_ServiceItemCategory> DC_ServiceItemCategory { get; set; }
        public virtual DbSet<DC_ServiceOrder> DC_ServiceOrder { get; set; }
        public virtual DbSet<DC_ServiceOrderCharge> DC_ServiceOrderCharge { get; set; }
        public virtual DbSet<DC_ServiceOrderChargeDtl> DC_ServiceOrderChargeDtl { get; set; }
        public virtual DbSet<DC_SOSData> DC_SOSData { get; set; }
        public virtual DbSet<DC_Task> DC_Task { get; set; }
        public virtual DbSet<DC_TaskChangeRecord> DC_TaskChangeRecord { get; set; }
        public virtual DbSet<DC_WatchRecord> DC_WatchRecord { get; set; }
        public virtual DbSet<ORG_Area> ORG_Area { get; set; }
        public virtual DbSet<ORG_BaiDuAudioToken> ORG_BaiDuAudioToken { get; set; }
        public virtual DbSet<ORG_Bed> ORG_Bed { get; set; }
        public virtual DbSet<ORG_Dept> ORG_Dept { get; set; }
        public virtual DbSet<ORG_Employee> ORG_Employee { get; set; }
        public virtual DbSet<ORG_Floor> ORG_Floor { get; set; }
        public virtual DbSet<ORG_Group> ORG_Group { get; set; }
        public virtual DbSet<ORG_Organization> ORG_Organization { get; set; }
        public virtual DbSet<ORG_Room> ORG_Room { get; set; }
        public virtual DbSet<SYS_CodeRule> SYS_CodeRule { get; set; }
        public virtual DbSet<SYS_Dictionary> SYS_Dictionary { get; set; }
        public virtual DbSet<SYS_DictionaryItem> SYS_DictionaryItem { get; set; }
        public virtual DbSet<SYS_Function> SYS_Function { get; set; }
        public virtual DbSet<SYS_Menu> SYS_Menu { get; set; }
        public virtual DbSet<SYS_MenuFunction> SYS_MenuFunction { get; set; }
        public virtual DbSet<SYS_Role> SYS_Role { get; set; }
        public virtual DbSet<SYS_User> SYS_User { get; set; }
        public virtual DbSet<SYS_UserRelation> SYS_UserRelation { get; set; }
    }
}
