using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starex.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public string Phone { get; set; }
        public string StartWorkOut { get; set; }
        public bool IsMain { get; set; }
        public string EndWorkOut { get; set; }
        public Branch Parent { get; set; }
        public virtual ICollection<Branch> Children { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
    }
}
