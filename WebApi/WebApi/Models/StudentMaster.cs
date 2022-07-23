using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlacementManagmentSystem.Models
{
    public class StudentMaster : baseModel
    {
        //public string fristName { get; set; }
        //public string lastName { get; set; }
        //public string middleName { get; set; }
        //public string Image { get; set; }
        public string EnrollmentNo { get; set; }
        public string RollNo { get; set; }
        public string EmailId { get; set; }
        public string mobileNo { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int pincode { get; set; }
        public DateTime DateOfBirth { get; set; }
        // resume for upload resume pdf file (store file location)
        public string resume { get; set; }

        //public Guid CreatedAt { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public Guid ModifyAt { get; set; }
        //public DateTime ModifyDate { get; set; }
    }
}
