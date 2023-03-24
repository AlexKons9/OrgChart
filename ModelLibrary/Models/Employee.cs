using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }    
        public string LastName { get; set; }
        public string PrefferedName { get; set; }
        public string JobTitle { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string department { get; set; }
        public string Location { get; set; }
        public string Division { get; set; }
        public string Pronouns { get; set; }
        public string WorkPhoneExtension { get; set; }
        public string Supervisor { get; set; }
        public bool PhotoUploader { get; set; }
        public string PhotoUrl { get; set;}
        public bool CanUploadPhoto { get; set; }  
    }
}
