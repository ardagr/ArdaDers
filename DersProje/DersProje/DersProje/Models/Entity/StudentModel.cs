﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersProje.Models.Entity
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public int No { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public int Period { get; set; }
        public int DepartmentId { get; set; }
        public Bolum Department { get; set; }
        public List<Ders> SelectedCourses { get; set; }
    }
}
