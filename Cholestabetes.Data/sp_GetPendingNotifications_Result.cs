//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cholestabetes.Data
{
    using System;
    
    public partial class sp_GetPendingNotifications_Result
    {
        public int ID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public Nullable<int> PhysicianID { get; set; }
        public Nullable<int> VisitID { get; set; }
        public string Email { get; set; }
        public string Salutation { get; set; }
        public string PhysicianFirstName { get; set; }
        public string PhysicianLastName { get; set; }
        public string Email1 { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
    }
}
