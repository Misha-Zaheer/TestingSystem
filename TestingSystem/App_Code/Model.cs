﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class MCQOption
{
    public int id { get; set; }
    public int Qid { get; set; }
    public string MOption { get; set; }
    public Nullable<bool> correct { get; set; }

    public virtual Question Question { get; set; }
}

public partial class Program
{
    public int id { get; set; }
    public int Qid { get; set; }
    public string code { get; set; }

    public virtual Question Question { get; set; }
}

public partial class Question
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Question()
    {
        this.MCQOptions = new HashSet<MCQOption>();
        this.Programs = new HashSet<Program>();
    }

    public int id { get; set; }
    public int Tid { get; set; }
    public int point { get; set; }
    public string Qstate { get; set; }
    public int hardness { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<MCQOption> MCQOptions { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Program> Programs { get; set; }
    public virtual Topic Topic { get; set; }
}

public partial class Sub
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Sub()
    {
        this.Topics = new HashSet<Topic>();
    }

    public int id { get; set; }
    public string name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Topic> Topics { get; set; }
}

public partial class Topic
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Topic()
    {
        this.Questions = new HashSet<Question>();
    }

    public int id { get; set; }
    public int subId { get; set; }
    public string Tname { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Question> Questions { get; set; }
    public virtual Sub Sub { get; set; }
}
