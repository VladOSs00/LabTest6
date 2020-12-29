using LabTest6.Init;
using LabTest6.Pages;
using Xunit;

namespace LabTest6.Tests
{
    public class HomePageTests : IClassFixture<TestStartupInitializerDefault>
    {
        private readonly TestStartupInitializerDefault _initializer;
        private readonly HomePage _page;

        public HomePageTests(TestStartupInitializerDefault initializer)
        {
            _initializer = initializer;
            _page = new HomePage(initializer);
        }



        [Fact]
        public void LoginTest()
        {
            string testname = "TestingNickName";
            string testpass = "TestingPassword";

            _page.Navigate();
            Assert.Contains("Instagram", _page.Title);

            _page.LoginEdit(testname);
            _page.PasswordEdit(testpass);
            Assert.Equal(testname, _page.GetLoginText());
            Assert.Equal(testpass, _page.GetPasswordText());
            _page.LoginClick();
        }

        [Fact] 
        public void RegisterTest()
        {
            string wrongfieldValue = "Testirovanie";

            string phonemail = "88005553535";
            string fullname = "Pepega Petrovich";
            string username = "TestingUUSerName";
            string password = "TestingPassword";

            _page.Navigate();

            _page.SwitchClick();

            _page.RegPhoneMailEdit(phonemail);
            _page.RegFullNameEdit(fullname);
            _page.RegUsernameEdit(username);
            _page.RegPasswordEdit(password);
            Assert.Equal(phonemail, _page.GetRegPhoneMailText());
            Assert.Equal(fullname, _page.GetRegFullnameText());
            Assert.Equal(username, _page.GetRegUserNameText());
            Assert.Equal(password, _page.GetRegPasswordText());
            Assert.NotEqual(wrongfieldValue, _page.GetRegPhoneMailText());
            Assert.NotEqual(wrongfieldValue, _page.GetRegFullnameText());
            Assert.NotEqual(wrongfieldValue, _page.GetRegUserNameText());
            Assert.NotEqual(wrongfieldValue, _page.GetRegPasswordText());

            _page.RegisterClick();

        }

        [Fact]
        public void navigate()
        {
            string wrongTitle = "Pepega";

            _page.Navigate();
            _page.infoClick();
            Assert.Contains("About", _page.Title);
            Assert.DoesNotContain(wrongTitle, _page.Title);

            _initializer.EnsureServerRestart();
            _page.Navigate();
            _page.BlogClick();
            Assert.Contains("Blog", _page.Title);
            Assert.DoesNotContain(wrongTitle, _page.Title);

            _initializer.EnsureServerRestart();
            _page.Navigate();
            _page.JobsClick();
            Assert.Contains("Instagram", _page.Title);
            Assert.DoesNotContain(wrongTitle, _page.Title);

            _initializer.EnsureServerRestart();
            _page.Navigate();
            _page.HelpClick();
            Assert.Contains("Справочный центр", _page.Title);
            Assert.DoesNotContain(wrongTitle, _page.Title);

            _initializer.EnsureServerRestart();
            _page.Navigate();
            _page.ApiClick();
            Assert.Contains("Developer", _page.Title);
            Assert.DoesNotContain(wrongTitle, _page.Title);

            _initializer.EnsureServerRestart();
            _page.Navigate();
            _page.PrivacyClick();
            Assert.Contains("Политика", _page.Title);
            Assert.DoesNotContain(wrongTitle, _page.Title);

            _initializer.EnsureServerRestart();
            _page.Navigate();
            _page.TermsClick();
            Assert.Contains("Условия", _page.Title);
            Assert.DoesNotContain(wrongTitle, _page.Title);

            _initializer.EnsureServerRestart();
            _page.Navigate();
            _page.ProfilesClick();
            Assert.Contains("Профили", _page.Title);
            Assert.DoesNotContain(wrongTitle, _page.Title);

            _initializer.EnsureServerRestart();
            _page.Navigate();
            _page.HashTagsClick();
            Assert.Contains("Хэштеги", _page.Title);
            Assert.DoesNotContain(wrongTitle, _page.Title);

            _initializer.EnsureServerRestart();
            _page.Navigate();
            _page.LocationsClick();
            Assert.Contains("Места", _page.Title);
            Assert.DoesNotContain(wrongTitle, _page.Title);

            _initializer.EnsureServerRestart();
            _page.Navigate();
            _page.BeautyClick();
            Assert.Contains("Instagram", _page.Title);
            Assert.DoesNotContain(wrongTitle, _page.Title);
        }

       
    }
}
