
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SqlProject
{

using System;
    using System.Collections.Generic;
    
public partial class question
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public question()
    {

        this.choices = new HashSet<choice>();

        this.Students_exams_questions = new HashSet<Students_exams_questions>();

    }


    public int question_ID { get; set; }

    public string qusetion_desc { get; set; }

    public string question_type { get; set; }

    public int course_ID { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<choice> choices { get; set; }

    public virtual cours cours { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Students_exams_questions> Students_exams_questions { get; set; }

}

}
