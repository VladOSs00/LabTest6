using LabTest6.Init;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabTest6.Pages
{
    class HomePage : TestPageBase
    {
        public override Uri Uri => new Uri(Initializer.RootUri, "");

        #region Login
        public IWebElement LoginField => Initializer.Driver.FindElement(By.XPath("//input[@name='username']"));
        public IWebElement PasswordField => Initializer.Driver.FindElement(By.XPath("//input[@name='password']"));

        public IWebElement ErrorField => Initializer.Driver.FindElement(By.XPath("//p[@id='slfErrorAlert']"));

        public IWebElement LoginBtn => Initializer.Driver.FindElement(By.XPath("//form[@id='loginForm']/div/div[3]/button/div"));


        public void LoginEdit(string text)
        {
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@name='username']")));
            LoginField.SendKeys(text);
        }

        public void PasswordEdit(string text)
        {
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@name='password']")));
            PasswordField.SendKeys(text);
        }

        public string GetLoginText()
        {
            return LoginField.GetAttribute("value");
        }

        public string GetPasswordText()
        {
            return PasswordField.GetAttribute("value");
        }


        public void LoginClick()
        {
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//form[@id='loginForm']/div/div[3]/button/div")));

            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", LoginBtn);
        }

        #endregion

        #region register

        public IWebElement RegSwitchBtn => Initializer.Driver.FindElement(By.XPath("//div[@id='react-root']/section/main/article/div[2]/div[2]/div/p/a/span"));
        public IWebElement RegPhoneMailField => Initializer.Driver.FindElement(By.XPath("//input[@name='emailOrPhone']"));
        public IWebElement RegFullnameField => Initializer.Driver.FindElement(By.XPath("//input[@name='fullName']"));
        public IWebElement RegUsernameField => Initializer.Driver.FindElement(By.XPath("//input[@name='username']"));
        public IWebElement RegPasswordField => Initializer.Driver.FindElement(By.XPath("//input[@name='password']"));
        public IWebElement RegisterBtn => Initializer.Driver.FindElement(By.XPath("//button[@type='submit']"));


        public void SwitchClick()
        {
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='react-root']/section/main/article/div[2]/div[2]/div/p/a/span")));
            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", RegSwitchBtn);

        }

        public void RegisterClick()
        {
            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", RegisterBtn);
        }

        public void RegPhoneMailEdit(string text)
        {
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@name='emailOrPhone']")));
            RegPhoneMailField.SendKeys(text);
        }

        public void RegFullNameEdit(string text)
        {
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@name='fullName']")));
            RegFullnameField.SendKeys(text);
        }

        public void RegUsernameEdit(string text)
        {
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@name='username']")));
            RegUsernameField.SendKeys(text);
        }
        public void RegPasswordEdit(string text)
        {
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@name='password']")));
            RegPasswordField.SendKeys(text);
        }

        public string GetRegPhoneMailText()
        {
            return RegPhoneMailField.GetAttribute("value");
        }

        public string GetRegFullnameText()
        {
            return RegFullnameField.GetAttribute("value");
        }

        public string GetRegUserNameText()
        {
            return RegUsernameField.GetAttribute("value");
        }

        public string GetRegPasswordText()
        {
            return RegPasswordField.GetAttribute("value");
        }

        #endregion


        #region navigation 
        public IWebElement InformationRef => Initializer.Driver.FindElement(By.XPath("//div[@id='react-root']/section/footer/div/div/div/div/a/div"));
        public IWebElement BlogRef => Initializer.Driver.FindElement(By.XPath("//div[@id='react-root']/section/footer/div/div/div/div[2]/a/div"));
        public IWebElement JobsRef => Initializer.Driver.FindElement(By.XPath("//div[@id='react-root']/section/footer/div/div/div/div[3]/a/div"));
        public IWebElement HelpRef => Initializer.Driver.FindElement(By.XPath("//div[@id='react-root']/section/footer/div/div/div/div[4]/a/div"));
        public IWebElement APIRef => Initializer.Driver.FindElement(By.XPath("//div[@id='react-root']/section/footer/div/div/div/div[5]/a/div"));
        public IWebElement PrivacyRef => Initializer.Driver.FindElement(By.XPath("//div[@id='react-root']/section/footer/div/div/div/div[6]/a/div"));
        public IWebElement TermsRef => Initializer.Driver.FindElement(By.XPath("//div[@id='react-root']/section/footer/div/div/div/div[7]/a/div"));
        public IWebElement ProfilesRef => Initializer.Driver.FindElement(By.XPath("//div[@id='react-root']/section/footer/div/div/div/div[8]/a/div"));
        public IWebElement HashTagsRef => Initializer.Driver.FindElement(By.XPath("//div[@id='react-root']/section/footer/div/div/div/div[9]/a/div"));
        public IWebElement LocationsRef => Initializer.Driver.FindElement(By.XPath("//div[@id='react-root']/section/footer/div/div/div/div[10]/a/div"));
        public IWebElement BeautyRef => Initializer.Driver.FindElement(By.XPath("//div[@id='react-root']/section/footer/div/div/div[2]/div/a/div"));

        public void infoClick()
        {


            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", InformationRef);
            string currentTab = Initializer.Driver.CurrentWindowHandle;
            foreach (string tab in Initializer.Driver.WindowHandles)
            {
                if (!tab.Equals(currentTab))
                {
                    Initializer.Driver.SwitchTo().Window(tab);
                }
            }
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("igAboutPageRoot")));



        }

        public void BlogClick()
        {


            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", BlogRef);
            string currentTab = Initializer.Driver.CurrentWindowHandle;
            foreach (string tab in Initializer.Driver.WindowHandles)
            {
                if (!tab.Equals(currentTab))
                {
                    Initializer.Driver.SwitchTo().Window(tab);
                }
            }
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.UrlToBe("https://about.instagram.com/en_US/blog"));



        }

        public void JobsClick()
        {
            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", JobsRef);
            string currentTab = Initializer.Driver.CurrentWindowHandle;
            foreach (string tab in Initializer.Driver.WindowHandles)
            {
                if (!tab.Equals(currentTab))
                {
                    Initializer.Driver.SwitchTo().Window(tab);
                }
            }
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.UrlToBe("https://www.instagram.com/about/jobs/"));
        }

        public void HelpClick()
        {
            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", HelpRef);
            string currentTab = Initializer.Driver.CurrentWindowHandle;
            foreach (string tab in Initializer.Driver.WindowHandles)
            {
                if (!tab.Equals(currentTab))
                {
                    Initializer.Driver.SwitchTo().Window(tab);
                }
            }
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.TitleContains("Справочный центр"));
        }

        public void ApiClick()
        {
            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", APIRef);
            string currentTab = Initializer.Driver.CurrentWindowHandle;
            foreach (string tab in Initializer.Driver.WindowHandles)
            {
                if (!tab.Equals(currentTab))
                {
                    Initializer.Driver.SwitchTo().Window(tab);
                }
            }
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.TitleContains("Developer"));
        }

        public void PrivacyClick()
        {
            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", PrivacyRef);
            string currentTab = Initializer.Driver.CurrentWindowHandle;
            foreach (string tab in Initializer.Driver.WindowHandles)
            {
                if (!tab.Equals(currentTab))
                {
                    Initializer.Driver.SwitchTo().Window(tab);
                }
            }
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.TitleContains("Политика"));
        }

        public void TermsClick()
        {
            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", TermsRef);
            string currentTab = Initializer.Driver.CurrentWindowHandle;
            foreach (string tab in Initializer.Driver.WindowHandles)
            {
                if (!tab.Equals(currentTab))
                {
                    Initializer.Driver.SwitchTo().Window(tab);
                }
            }
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.TitleContains("Условия"));
        }

        public void ProfilesClick()
        {
            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", ProfilesRef);
            string currentTab = Initializer.Driver.CurrentWindowHandle;
            foreach (string tab in Initializer.Driver.WindowHandles)
            {
                if (!tab.Equals(currentTab))
                {
                    Initializer.Driver.SwitchTo().Window(tab);
                }
            }
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TitleContains("Профили"));
        }

        public void HashTagsClick()
        {
            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", HashTagsRef);
            string currentTab = Initializer.Driver.CurrentWindowHandle;
            foreach (string tab in Initializer.Driver.WindowHandles)
            {
                if (!tab.Equals(currentTab))
                {
                    Initializer.Driver.SwitchTo().Window(tab);
                }
            }
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.TitleContains("Хэштеги"));
        }

        public void LocationsClick()
        {
            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", LocationsRef);
            string currentTab = Initializer.Driver.CurrentWindowHandle;
            foreach (string tab in Initializer.Driver.WindowHandles)
            {
                if (!tab.Equals(currentTab))
                {
                    Initializer.Driver.SwitchTo().Window(tab);
                }
            }
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.TitleContains("Места"));
        }

        public void BeautyClick()
        {
            Initializer.Driver.Scripts().ExecuteScript("arguments[0].click();", BeautyRef);
            string currentTab = Initializer.Driver.CurrentWindowHandle;
            foreach (string tab in Initializer.Driver.WindowHandles)
            {
                if (!tab.Equals(currentTab))
                {
                    Initializer.Driver.SwitchTo().Window(tab);
                }
            }
            WebDriverWait wait = new WebDriverWait(Initializer.Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.UrlToBe("https://www.instagram.com/topics/beauty/"));
        }
        #endregion









        public HomePage(ITestStartupInitializer initializer) : base(initializer)
        {
        }
    }
}
