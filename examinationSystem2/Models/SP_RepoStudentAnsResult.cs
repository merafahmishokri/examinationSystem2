﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace examinationSystem2.Models
{
    public partial class SP_RepoStudentAnsResult
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        [Column("Std Answer")]
        public string StdAnswer { get; set; }
        public int QuesID { get; set; }
    }
}
