﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class SummaryModel
    {
        public string Phone { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        public string Email { set; get; }
        public string Experience { set; get; }
        public string Education { set; get; }
        public string Skills { set; get; }

        public SummaryModel(string name, int age, string email, string phone, string education, string experience, string skills)
        {
            Skills = skills;
            Phone = phone;
            Education = education;
            Email = email;
            Experience = experience;
            Name = name;
            Age = age;
        
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }

}
