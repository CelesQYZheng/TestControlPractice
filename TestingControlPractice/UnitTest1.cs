using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;


namespace TestingControlPractice
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestDragAndDropControl()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);
            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            
            // drag the square and drop it to the target box
            actions.DragAndDrop(driver.FindElement(By.Id("draggable")),driver.FindElement(By.Id("droppable"))).Build().Perform();
            Thread.Sleep(3000);

            driver.Quit();
        }

        [TestMethod]
        public void TestButtonDoubleClick()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);

            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // double click on button
            IWebElement btn = driver.FindElement(By.Name("dblClick"));
            actions.DoubleClick(btn).Build().Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void TestIFrame()
        {
            IWebDriver driver = new ChromeDriver();
            //Actions actions = new Actions(driver);

            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            //give input to the textfield
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,500);");
            //driver.FindElement(By.Id("name")).SendKeys("Feranda");
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("Feranda");
            Thread.Sleep(3000);

            // click on the link
            driver.FindElement(By.PartialLinkText("uitestpractice.com")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void TestOpenLinkInNewTab()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);

            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // maximize the window 
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[6]/button/a")).Click();
            driver.Quit();
        }

        [TestMethod]
        public void TestOpenLinkInNewWindow()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);

            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='Button']/a")).Click();
            Thread.Sleep(2000);

            driver.Quit();
        }

        [TestMethod]
        public void TestAccordianControl()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);

            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // Scroll down
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript("window.scrollBy(0,1060);");
            Thread.Sleep(2000);

            // click on button
            driver.FindElement(By.XPath("//*[@id='toggle']/span")).Click();
            driver.Quit();

            // click on dropdown icon 
            // ****can changed by findXpath by text
            driver.FindElement(By.XPath("//*[@id='ui-id-1']/span")).Click();

        }

        [TestMethod]
        public void TestSelectableControl()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);

            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // Scroll down
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript("window.scrollBy(0,1060);");
            Thread.Sleep(2000);
          
            //******** use find by the table
            driver.FindElement(By.XPath("//*[@id='selectable']/li[1]")).Click();
            driver.Quit();
        }

        [TestMethod]
        public void TestSortableControl()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);

            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void TestDialogControl()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);

            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // click on button
            driver.FindElement(By.XPath("//*[@id='create-user']/span")).Click();
            Thread.Sleep(2000);

            // give inputs to the textfields
            IWebElement name = driver.FindElement(By.XPath("//*[@id='name']"));
            name.Clear();
            name.SendKeys("Alice Perez");
            IWebElement email = driver.FindElement(By.XPath("//*[@id='email']"));
            email.Clear();
            email.SendKeys("aliceperez@gmail.com");
            IWebElement pswd = driver.FindElement(By.XPath("//*[@id='password']"));
            pswd.Clear();
            pswd.SendKeys("12345zxc");

            driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/button[1]/span")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void TestMenuControl()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);

            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // hover on Delphi
            IWebElement delpi = driver.FindElement(By.XPath("//*[@id='ui-id-10']"));
            actions.MoveToElement(delpi).Perform();
            Thread.Sleep(2000);

            // hover on salzburg 
            IWebElement salzburg = driver.FindElement(By.XPath("//*[@id='ui-id-15']"));
            actions.MoveToElement(salzburg).Perform();
            Thread.Sleep(2000);

            // hover on another delphi 
            IWebElement anotherdelphi = driver.FindElement(By.XPath("//*[@id='ui-id-16']']"));
            actions.MoveToElement(salzburg).Perform();
            Thread.Sleep(2000);
            // hover on ada 
            IWebElement ada = driver.FindElement(By.XPath("//*[@id='ui-id-17']"));
            actions.MoveToElement(ada).Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void TestProgressbarControl()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);

            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // Scroll down
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript("window.scrollBy(0,1800);");
            Thread.Sleep(000);

            // maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // click on the download butotn
            driver.FindElement(By.XPath("//*[@id='downloadButton']/span")).Click();
            driver.Quit();
        }

        [TestMethod]
        public void TestSliderControl()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);

            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // Scroll down
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript("window.scrollBy(0,3300);");
            Thread.Sleep(2000);

            // slide the bar 
            IWebElement sliderbar = driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[12]/div/div[2]/div/div/span"));
            actions.MoveToElement(sliderbar).MoveByOffset(10,0).Build().Perform();
        }

        [TestMethod]
        public void TestTabsControl()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);

            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // click on button
            driver.FindElement(By.XPath("//*[@id='add_tab']/span")).Click();
            IWebElement title = driver.FindElement(By.XPath("//*[@id='tab_title']"));
            title.Clear();
            title.SendKeys("new_title");

            driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/button[1]/span")).Click();
            driver.Close();
        }

        [TestMethod]
        public void TestClassDemo()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);

            // navigate to the page
            driver.Url = "http://uitestpractice.com";

            // maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // click on selection
            driver.FindElement(By.XPath("//*[@id='effectTypes']")).Click();
            driver.FindElement(By.XPath("//*[@id='effectTypes']/option[2]")).Click();

            // run the demo
            driver.FindElement(By.XPath("//*[@id='button']")).Click();
            Thread.Sleep(2000);
            driver.Quit();
        }

    }
}
