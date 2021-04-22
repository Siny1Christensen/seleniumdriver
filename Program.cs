using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Launch the browser
            var driver = new ChromeDriver();

            //Navigate to the url you will be testing in this case for practice finvi.com/fuzionservice.com
            driver.Url = "http://fuzionservice.jcmglobal.com/Account/Login?ReturnUrl=%2F";

            //variable to search GooGl with + key
            var SearchElement = driver.FindElementByCssSelector("#LoginFields > div.row.wrapperA.alignTextCenter.addPadding > div.row.addPadding > div > a:nth-child(1)");
            SearchElement.SendKeys("GOOGL" + Keys.Enter);

            //Get values 
        
           
        }
    }
}
