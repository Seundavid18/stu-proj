using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace donet_tut_projects.Models
{
    public class AddStudentViewModel
    {

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool Subscribed { get; set; }
    }
}