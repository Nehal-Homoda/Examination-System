//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sqlProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class stud_exam
    {
        public int stud_id { get; set; }
        public int question_id { get; set; }
        public int exam_id { get; set; }
        public string answer { get; set; }
    
        public virtual Exam Exam { get; set; }
        public virtual Questions Questions { get; set; }
        public virtual student student { get; set; }
    }
}
