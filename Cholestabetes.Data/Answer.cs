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
    
    public partial class Answer
    {
        public Answer()
        {
            this.UserAnswers = new HashSet<UserAnswer>();
        }
    
        public int ID { get; set; }
        public Nullable<int> QID { get; set; }
        public string Text { get; set; }
    
        public virtual ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
