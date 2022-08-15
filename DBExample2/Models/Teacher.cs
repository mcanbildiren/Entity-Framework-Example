﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExample2.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
