
using Spinbet2.Pages;
using SpinbetCore;

namespace Spinbet
{
    public class SpinbetFramework : Core
    {
        RegistrationForm Registrationform = new RegistrationForm();
        SpinbetMainPage spinbetmainpage = new SpinbetMainPage();
        DashboardSearch dasboardsearch = new DashboardSearch();
        SignInpage signinPage = new SignInpage();

        [SetUp]
        public void Setup()
        {
            string url = "https://stage2.igamingallstars.com/";
            InitializeDriver(url);

        }

        [TearDown]
        public void DriverClose()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Close();
        }


        [Test]
        public void RegistrationTest()
        {
           
            spinbetmainpage.Signupbtn();
            Registrationform.Title();
            Registrationform.Registertab();
            Registrationform.UsernameTextbox("Test00001");
            Registrationform.EmailIdTextbox("Tester00001@gmail.com");
            Registrationform.PasswordTextbox("TestPassword@9619");
            Registrationform.CurrencyDropDownSelection("USD");
            Registrationform.DateYear("1990");
            Registrationform.DateDate("21");
            Registrationform.DateMonth("12");
           // Registrationform.PromotionCode("123134");
            Registrationform.TermsCheckboxSelect();// -- yeah check akrna hia ..

          
            Thread.Sleep(30000); //For manually Recaptcha selection by User
            Registrationform.RegisterSubmit();
            Thread.Sleep(5000);
            //Need to do Assertion. .
            //logged In with registered User //
            //Need to add USer log out //
        }


        [Test]
        public void SpinbetSearchList()
        {
            spinbetmainpage.Signupbtn();
            signinPage.Title();
            signinPage.SignIntab();
            signinPage.UsernameTextbox("Test091@gmail.com");
            signinPage.PasswordTextbox("Test@123");
            signinPage.SignInbtn();
            dasboardsearch.Title();
            dasboardsearch.SearchBarClick();
            dasboardsearch.Search("Casino");
            dasboardsearch.SearchBtnClick();
            dasboardsearch.SearchedGameList();
            
            //Need to add USer log out //
        }
    }
}