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
    
    public partial class Visit
    {
        public Visit()
        {
            this.PatientQuestions = new HashSet<PatientQuestion>();
            this.PatientVisits = new HashSet<PatientVisit>();
            this.VisitReminders = new HashSet<VisitReminder>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Visit1 { get; set; }
    
        public virtual ICollection<PatientQuestion> PatientQuestions { get; set; }
        public virtual ICollection<PatientVisit> PatientVisits { get; set; }
        public virtual ICollection<VisitReminder> VisitReminders { get; set; }
    }
}
