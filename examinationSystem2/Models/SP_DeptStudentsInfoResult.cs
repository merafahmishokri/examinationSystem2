﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace examinationSystem2.Models
{
    public partial class SP_DeptStudentsInfoResult
    {
        public string Department { get; set; }
        [Column("Student Name")]
        public string StudentName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? age { get; set; }
    }
}
