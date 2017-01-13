using OpenQA.Selenium.Chrome;
using TIBAutomation.InputParameter;
using TIBAutomation.InputParameterValidator;
using TIBAutomation.OutputMessage;
using TIBAutomation.ResultOutput;

namespace TIBAutomation
{
    public class MemberTests
    {
        public TestResult SignInTest(SignInInput input)
        {

            var validator = new SignInInputValidator();
            var validateResult = validator.Validate(input);

            if (!validateResult.IsValid)
            {
                return new TestResult { IsPassed = false, ResultMessage = TestMessage.ParameterNotValid };
            }

            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.tumislerburada.com/Home/UyeOl");

                var userNameField = driver.FindElementById("loginmail");
                var userPasswordField = driver.FindElementById("loginsifre");
                var loginButton = driver.FindElementById("loginsubmit");

                userNameField.SendKeys(input.UserName);
                userPasswordField.SendKeys(input.Password);

                loginButton.Click();

                //login oldu mu kontrol yaz
                // true / false dönüş yap

                return new TestResult { IsPassed = true, ResultMessage = TestMessage.SignInSuccess };
            }
        }

        public TestResult SignUpTest(SignUpInput input)
        {
            // burası sende
            return null;
        }

    }
}
