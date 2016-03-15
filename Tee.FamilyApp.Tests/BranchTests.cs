using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tee.FamilyApp.Tests
{
    public interface INotificationService
    {
        bool SendNotification(Notification notification);
    }

    public interface IBranchService
    {
        IEnumerable<Branch> GetRelatedBranchs(int branchId);

        bool SendInviteNotification(int branchId);
    }

    [TestFixture]
    public class BranchTest
    {
        private IBranchService _branchService;
        private Branch _sut;

        [SetUp]
        public void Init()
        {
            _branchService = Substitute.For<IBranchService>();
            _sut = new Branch(_branchService);
        }

        [Test]
        public void ShouldSendAnInvite()
        {
            var email = new Email();
            _sut.SendFamilyInvite();

            _branchService.Received().SendInviteNotification(_sut.BranchId);
        }

        [Test]
        public void ShouldReturnAllFamilyMembers()
        {
            _sut.GetFamilyMembers();
            _branchService.Received().GetRelatedBranchs(_sut.BranchId);
        }
    }

    public class Branch
    {
        private readonly IBranchService _branchService;

        public Branch(IBranchService branchService)
        {
            _branchService = branchService;
        }

        public int BranchId { get; set; }

        public bool SendFamilyInvite()
        {
            return _branchService.SendInviteNotification(BranchId);
        }

        public IEnumerable<Branch> GetFamilyMembers()
        {
            return _branchService.GetRelatedBranchs(BranchId);
        }
    }

    public class Email
    {
    }

    public class Notification
    {
    }
}