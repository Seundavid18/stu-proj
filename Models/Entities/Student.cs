using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace donet_tut_projects.Models.Entities
{
    public class Student
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool Subscribed { get; set; }
    }
}