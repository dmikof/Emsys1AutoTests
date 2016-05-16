using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsysAutoTests
{
   public  class LoginPage
    {
        public static void GoTo()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https//qa.emsys1.com");
        }

        public static LoginCommand LoginAs(string userName)
        {
            
        }
    }

    public class LoginCommand
    {

    }
}
