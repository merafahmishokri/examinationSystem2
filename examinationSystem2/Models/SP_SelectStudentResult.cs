﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace examinationSystem2.Models
{
    public partial class SP_SelectStudentResult
    {
        public int St_ID { get; set; }
        public string St_Fname { get; set; }
        public string St_Lname { get; set; }
        public string St_Phone { get; set; }
        public string St_Address { get; set; }
        public DateOnly? St_BD { get; set; }
        public int? Dept_ID { get; set; }
        public string St_SSN { get; set; }
    }
}
