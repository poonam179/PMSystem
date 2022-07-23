using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlacementManagmentSystem.Models
{
    public class baseModel
    {
        public Guid Id { get; set; }
        public Guid CreatedAt { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifyAt { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
