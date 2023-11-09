using LaunchMod1Week5Assessment;

namespace UserTests
{
    public class UserTest
    {
        [Fact]
        public void IsCreated()
        {
            var user = new User("Ethan", "WomP@Gmail.com");
            Assert.Equal("Ethan", user.Name);
            Assert.Equal("WomP@Gmail.com", user.Email);
            Assert.Equal(false, user.IsLoggedIn);
        }
        [Fact]
        public void CanCreatePassword()
        {
            var user = new User("Ethan", "WomP@Gmail.com");
            user.CreatePassword("WomP@Gmail.com", "WOMP");
            Assert.Equal(user.IsPasswordCreated, true);
        }
        [Fact]
        public void IsSetUpComplete()
        {
            var user = new User("Ethan", "WomP@Gmail.com");
            Assert.Equal(false, user.IsSetupComplete());
            user.CreatePassword("WomP@Gmail.com", "WOMP");
            Assert.Equal(true, user.IsSetupComplete());
        }
        [Fact]
        public void CanUserLogIn()
        {
            var user = new User("Ethan", "WomP@Gmail.com");
            user.CreatePassword("WomP@Gmail.com","WOMP");
            Assert.Equal(false, user.IsLoggedIn);
            user.LogIn("WomP@Gmail.com","WOMP");
            var what = user.LogIn("WomP@Gmail.com", "WOMP");
            Assert.Equal(true,user.IsLoggedIn);
        }
        [Fact]
        public void CanUserLogOut()
        {
            var user = new User("Ethan", "WomP@Gmail.com");
            user.CreatePassword("WomP@Gmail.com", "WOMP");
            user.LogIn("WomP@Gmail.com", "WOMP");
            user.LogOut();
            Assert.Equal(false, user.IsLoggedIn);
        }

    }   
}