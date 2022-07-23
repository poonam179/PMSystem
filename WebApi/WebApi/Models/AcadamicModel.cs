using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlacementManagmentSystem.Models
{
    public class AcadamicModel
    {
        [Key]
        public Guid id { get; set; }
        public string enrollmentNo { get; set; }
        // school/College name 
        public string plaseName { get; set; }
        public string certificate { get; set; }
        public string uploadCertificate { get; set; }
        public string gradeType { get; set; }
        public string grade { get; set; }
        public string Year { get; set; }
    }
}
