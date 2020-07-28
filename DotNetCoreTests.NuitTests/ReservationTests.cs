using DotNetCoreTests.Fundamentals;
using NUnit.Framework;

namespace DotNetCoreTests.NunitTests
{
    [TestFixture]
    public class ReservationTests
    {
       
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            // Assert.IsTrue(result);
            Assert.That(result, Is.True);
            // Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_UserWhoMadeTheRevervation_ReturnsTrue()
        {
            // Arrage
            var reservation = new Reservation();
            var user = new User();
            reservation.MadeBy = user;

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUser_ReturnsFalse()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.IsFalse(result);
        }
    }
}
