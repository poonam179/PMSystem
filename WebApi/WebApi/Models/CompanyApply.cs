using PlacementManagmentSystem.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlacementManagmentSystem.Models
{
    public class CompanyApply
    {
        
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public virtual CompanyMaster Company { get; set; }
        public Guid StudentId { get; set; }
        public virtual ApplicationUser Student { get; set; }
        public String Status { get; set; }
        public string Role { get; set; }
        public String Technology { get; set; }
        public String Desgination { get; set; }

        public Guid CreatedAt { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifyAt { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
