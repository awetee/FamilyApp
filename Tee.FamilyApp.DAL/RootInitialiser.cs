using System.Collections.Generic;
using Tee.FamilyApp.Common.Enums;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.DAL
{
    internal class RootInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<RootContext>
    {
        protected override void Seed(RootContext context)
        {
            var branches = new List<Branch>
            {
                new Branch {FirstName = "Oluwatobi", LastName = "Adebiyi", Gender = Gender.Male  }
            };

            base.Seed(context);
        }
    }
}