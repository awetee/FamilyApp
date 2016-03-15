using Tee.FamilyApp.DAL.Enums;

namespace Tee.FamilyApp.DAL.Entities
{
    public class Link : BaseEntity
    {
        public int LinkID { get; set; }
        public int BranchID { get; set; }
        public LinkType LinkType { get; set; }
        public int LinkBranchID { get; set; }
    }
}