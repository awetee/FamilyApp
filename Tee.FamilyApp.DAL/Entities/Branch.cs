namespace Tee.FamilyApp.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using Tee.FamilyApp.Common.Enums;

    public class Branch : BaseEntity
    {
        //public int Age
        //{
        //    get
        //    {
        //        return this.GetAge();
        //    }
        //}

        public BirthDetail BirthDetails { get; set; }
        public string CoountryOfOrigin { get; set; }
        public string FirstName { get; set; }
        public Gender Gender { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Link> Links { get; set; }

        //private int GetAge()
        //{
        //    var birthYear = this.BirthDetails.DateOfBirth.Year;
        //    var birthMonth = this.BirthDetails.DateOfBirth.Month;
        //    var today = DateTime.Today;

        //    var age = today.Year - birthYear;

        //    if (birthMonth > today.Month)
        //    {
        //        age--;
        //    }

        //    return age;
        //}
    }
}