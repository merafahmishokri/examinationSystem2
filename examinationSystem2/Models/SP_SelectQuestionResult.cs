﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace examinationSystem2.Models
{
    public partial class SP_SelectQuestionResult
    {
        public int Ques_ID { get; set; }
        public string Ques_Type { get; set; }
        public string Ques_Body { get; set; }
        public string Ques_Answer { get; set; }
        public int Ques_Grade { get; set; }
        public int? Crs_ID { get; set; }
    }
}
