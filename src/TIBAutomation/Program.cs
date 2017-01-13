using TIBAutomation.InputParameter;

namespace TIBAutomation
{
    class Program
    {
        static void Main(string[] args)
        {

            var memberTests = new MemberTests();
            var signInResult = memberTests.SignInTest(new SignInInput { UserName = "eyurtseven@kariyer.net", Password = "123456" });

            var signUpResult = memberTests.SignUpTest(new SignUpInput { });

        }
    }
}
