using NUnit.Framework;
using TutoUnitTest.Classes;

namespace NUnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // tripple A convetion
            // arrange
            var reservation = new Reservation();
            //act
            var result = reservation.CanBeCAncelledBy(new User() { IsAdmin = true });
            //assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_MadeBy_User()
        {
            // tripple A convetion
            // arrange
            var reservation = new Reservation();
            reservation.MadeBy = new User();
            var copyOfUser = reservation.MadeBy;
            //act

            //assert
            Assert.AreEqual(copyOfUser, reservation.MadeBy);
        }

        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsFalse()
        {
            // tripple A convetion
            // arrange
            var reservation = new Reservation();
            //act
            var result = reservation.CanBeCAncelledBy(new User() { IsAdmin = false });
            //assert
            Assert.IsFalse(result);
        }
    }
}