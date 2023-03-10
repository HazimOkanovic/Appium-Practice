using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Appium_Practice.Pages;

public class SignUpPage : BasePage
{
    private readonly By FirstNameInput = MobileBy.Id("com.contextlogic.wish:id/name1Text");
    private readonly By LastNameInput = MobileBy.Id("com.contextlogic.wish:id/name2Text");
    private readonly By EmailInput = MobileBy.Id("com.contextlogic.wish:id/input");
    private readonly By PasswordInput = MobileBy.Id("com.contextlogic.wish:id/passwordText");
    private readonly By CreateAccountButton = MobileBy.Id("com.contextlogic.wish:id/createAccountButton");
    private readonly By SignInButton = MobileBy.Id("com.contextlogic.wish:id/signInButton");
    private readonly By VerifyEmailTitle = MobileBy.Id("com.contextlogic.wish:id/title");
    private readonly By BackButton = MobileBy.Id("com.contextlogic.wish:id/back_button");
    private readonly By Title = MobileBy.Id("com.contextlogic.wish:id/title");
    
    public SignUpPage(AndroidDriver<AndroidElement> driver) : base(driver)
    {
    }

    public SignUpPage EnterFirstName(string firstName)
    {
        WaitElementVisibleAndGet(FirstNameInput).SendKeys(firstName);
        return this;
    }
    
    public SignUpPage EnterLastName(string lastName)
    {
        WaitElementVisibleAndGet(LastNameInput).SendKeys(lastName);
        return this;
    }
    
    public SignUpPage EnterEmail(string email)
    {
        WaitElementVisibleAndGet(EmailInput).SendKeys(email);
        return this;
    }
    
    public SignUpPage EnterPassword(string password)
    {
        WaitElementVisibleAndGet(PasswordInput).SendKeys(password);
        return this;
    }
    
    public SignUpPage ClickCreateAccount()
    {
        WaitElementVisibleAndGet(CreateAccountButton).Click();
        return this;
    }

    public string GetButtonTitle()
    {
        return WaitElementVisibleAndGet(CreateAccountButton).Text;
    }
    
    public string GetVerifyEmailTitle()
    {
        return WaitElementVisibleAndGet(VerifyEmailTitle).Text;
    }
    
    public string GetTitle()
    {
        return WaitElementVisibleAndGet(Title).Text;
    }

    public SignUpPage ClickGetBack()
    {
        WaitElementVisibleAndGet(BackButton).Click();
        return this;
    }
    
    public SignInPage ClickSignInButton()
    {
        WaitElementVisibleAndGet(SignInButton).Click();
        return new SignInPage(driver);
    }
}