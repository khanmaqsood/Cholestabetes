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
    
    public partial class PatientAnswer
    {
        public PatientAnswer()
        {
            this.PatientQuestionAnswers = new HashSet<PatientQuestionAnswer>();
        }
    
        public int ID { get; set; }
        public Nullable<int> QID { get; set; }
        public string AnswerText { get; set; }
    
        public virtual PatientQuestion PatientQuestion { get; set; }
        public virtual ICollection<PatientQuestionAnswer> PatientQuestionAnswers { get; set; }
    }
}