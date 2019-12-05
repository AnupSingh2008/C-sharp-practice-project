using NUnit.Framework;
using TestProject.Fundamentals;

namespace UnitTestProject
{
    [TestFixture]
    public class ReservationTest
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            Reservation reservation = new Reservation();
            //Act
            var result =reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //Assert
           // Assert.IsTrue(result);
            Assert.That(result,Is.True);
        }
        [Test]
        public void CanBeCanceeledBy_SameUserCancellingReservation_ReturnTrue()
        {
            User user = new User();
            Reservation reservation = new Reservation() { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);

           // Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            
            Reservation reservation = new Reservation() { MadeBy = new User() };
            var result = reservation.CanBeCancelledBy(new User());
           // Assert.IsFalse(result);
            Assert.That(result, Is.False);
        }
    }
}
