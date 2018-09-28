using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxAndPartialView.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public decimal Grade { get; set; }
        public DateTime Date { get; set; }
    }
}
