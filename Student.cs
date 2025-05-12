using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
namespace StudentManagementApp.Models
{
    public class Student
	{
            [Key] // This tells EF that this is the primary key
            public int StudentId { get; set; }

            [Required(ErrorMessage = "Name is required")]
            public string Name { get; set; }

            [Range(18, 100, ErrorMessage = "Age must be between 18 and 100")]
            public int Age { get; set; }

            [EmailAddress(ErrorMessage = "Enter a valid email")]
            public string Email { get; set; }
        }
    }