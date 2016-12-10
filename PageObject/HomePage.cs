using MyDriver;
using OpenQA.Selenium;


namespace PageObject
{
    public class HomePage
    {
        private readonly WebDriver _driver;
        // 构造 函数 , 再类中传递参数
        public HomePage(WebDriver driver)
        {
            _driver = driver;
        }

        public WebElement MyAccount
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//ul[@id='main-nav']/li[5]"));
                return element;
            }
        }

        public WebElement PopUpClose
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//img[contains(@id,'popup-subcription-closes-icon')]"));
                 
                return  element;
            }
        }

        public WebElement AccountOverView
        {
            get
            {
                var element = _driver.FindElement(By.XPath("(//a[contains(text(),'Account Overview')])[2]"));
                return element;
            }
        }



        public WebElement LoginOrSingout
        {
            get
            {
                var element = _driver.FindElement(By.XPath("(//a[contains(text(),'Login / Sign Up')])[2]"));
                return element;
            }
        }


        public WebElement Singout
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//p[@class='text-center margin-bottom0']/a"));
                return element;
            }
        }


        

    }
}
