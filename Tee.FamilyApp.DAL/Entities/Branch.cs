using System.Collections.Generic;
using Tee.FamilyApp.DAL.Enums;

namespace Tee.FamilyApp.DAL.Entities
{
    public class Branch : BaseEntity
    {
        public int BranchID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CoountryOfOrigin { get; set; }
        public BirthDetails BirthDetails { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public virtual ICollection<Link> Links { get; set; }
    }
}