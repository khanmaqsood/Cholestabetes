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
    using System.Collections.Generic;
    
    public partial class UserRegistration
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public Nullable<bool> MOU { get; set; }
        public Nullable<System.DateTime> MOUDate { get; set; }
        public Nullable<bool> AssesmentSurvey { get; set; }
        public Nullable<bool> PayeeInformation { get; set; }
        public Nullable<System.DateTime> PayeeInformationDate { get; set; }
        public Nullable<System.DateTime> AssesmentSurveyDate { get; set; }
        public Nullable<int> AssesmentSurveyScreenID { get; set; }
    
        public virtual User User { get; set; }
    }
}
