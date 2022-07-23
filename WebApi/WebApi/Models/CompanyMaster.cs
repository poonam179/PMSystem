using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlacementManagmentSystem.Models
{
    public class CompanyMaster
    {
        public Guid Id { get; set; }
        public String CompanyName { get; set; }
        public String ComapanyProfile { get; set; }
        public String ComapanyWebSite { get; set; }
        public String RequiredPost { get; set; }
        public String Technologies { get; set; }
        public String EligibilityCriteria { get; set; }
        public String Package { get; set; }
        public String ComapanyAddress { get; set; }
        public String CompanyEmail { get; set; }
        public String HRName { get; set; }
        public String CompanyMobileNo { get; set; }
        public String ServiceAgrement { get; set; }
        public DateTime RegistrationStateDate { get; set; }
        public DateTime RegistrationEndDate { get; set; }
        public bool IsStipiend { get; set; }

        public Guid CreatedAt { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifyAt { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
