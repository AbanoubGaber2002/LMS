//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuizResult
    {
        public int QuizResultID { get; set; }
        public int QuizID { get; set; }
        public int UserID { get; set; }
        public decimal Score { get; set; }
        public Nullable<System.DateTime> TakenAt { get; set; }
    
        public virtual Quizze Quizze { get; set; }
        public virtual User User { get; set; }
    }
}
