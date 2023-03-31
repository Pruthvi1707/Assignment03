using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruthviraj_Chuahan_8780000_Assignment03
{
	//first commit

	[TestFixture]
	public class FirstthreetestsuitsTest
	{
		private IWebDriver driver;
		public IDictionary<string, object> Vars { get; private set; }
		private IJavaScriptExecutor js;
		[SetUp]
		public void SetUp()
		{
			driver = new ChromeDriver();
			js = (IJavaScriptExecutor)driver;
			Vars = new Dictionary<string, object>();
		}
		[TearDown]
		protected void TearDown()
		{
			driver.Quit();
		}
		[Test]


		public void Test01_All_Data_Valid_25_3_0()
		{
			driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
			driver.Manage().Window.Size = new System.Drawing.Size(1042, 1020);
			driver.FindElement(By.CssSelector(".btn")).Click();
			driver.FindElement(By.Id("firstName")).Click();
			driver.FindElement(By.Id("firstName")).SendKeys("pruthvi");
			driver.FindElement(By.Id("lastName")).SendKeys("chauhan");
			driver.FindElement(By.Id("address")).SendKeys("30fe htnkaf");
			driver.FindElement(By.Id("city")).Click();
			driver.FindElement(By.Id("city")).SendKeys("kitvhner");
			driver.FindElement(By.Id("postalCode")).SendKeys("N2a 0j7");
			driver.FindElement(By.Id("phone")).SendKeys("662-333-9999");
			driver.FindElement(By.Id("email")).Click();
			driver.FindElement(By.Id("email")).SendKeys("pruthvirajchauhan2801@gmail.com");
			driver.FindElement(By.Id("age")).Click();
			driver.FindElement(By.Id("age")).SendKeys("25");
			driver.FindElement(By.Id("experience")).SendKeys("03");
			driver.FindElement(By.Id("accidents")).SendKeys("0");
			driver.FindElement(By.Id("btnSubmit")).Click();
			{
				string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
				Assert.That(value, Is.EqualTo("$2500"));
			}
		}

		[Test]
		public void Test02_All_Data_Valid_25_3_4()
		{
			driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
			driver.Manage().Window.Size = new System.Drawing.Size(1042, 1020);
			driver.FindElement(By.CssSelector(".btn")).Click();
			driver.FindElement(By.Id("firstName")).Click();
			driver.FindElement(By.Id("firstName")).SendKeys("pruthvi");
			driver.FindElement(By.Id("lastName")).SendKeys("chauhan");
			driver.FindElement(By.Id("address")).SendKeys("23f eihhifw");
			driver.FindElement(By.Id("city")).SendKeys("kitvhener");
			driver.FindElement(By.Id("postalCode")).SendKeys("n2a 2j8");
			driver.FindElement(By.Id("phone")).SendKeys("666-666-6666");
			driver.FindElement(By.Id("email")).SendKeys("wejfo@gmail.com");
			driver.FindElement(By.Id("age")).Click();
			driver.FindElement(By.Id("age")).SendKeys("25");
			driver.FindElement(By.Id("experience")).SendKeys("3");
			driver.FindElement(By.Id("accidents")).SendKeys("4");
			driver.FindElement(By.Id("btnSubmit")).Click();
			{
				string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
				Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
			}
		}


		[Test]
		public void Test03_All_Data_Valid_35_10_2()
		{
			driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
			driver.Manage().Window.Size = new System.Drawing.Size(1042, 1020);
			driver.FindElement(By.CssSelector(".btn")).Click();
			driver.FindElement(By.Id("firstName")).Click();
			driver.FindElement(By.Id("firstName")).SendKeys("pruthvi");
			driver.FindElement(By.Id("lastName")).SendKeys("chauhan");
			driver.FindElement(By.Id("address")).SendKeys("232 hiuehfo");
			driver.FindElement(By.Id("city")).SendKeys("kitchener");
			driver.FindElement(By.Id("postalCode")).SendKeys("n2a 0j7");
			driver.FindElement(By.Id("phone")).SendKeys("555-666-9999");
			driver.FindElement(By.Id("email")).SendKeys("prtuthf@gmail.com");
			driver.FindElement(By.Id("age")).SendKeys("35");
			driver.FindElement(By.Id("experience")).SendKeys("10");
			driver.FindElement(By.Id("accidents")).SendKeys("2");
			driver.FindElement(By.Id("btnSubmit")).Click();
			{
				string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
				Assert.That(value, Is.EqualTo("$1350"));
			}
		}

		[Test]
		public void Test04_Invalid_Phone_Number_27_3_0()
		{
			driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
			driver.Manage().Window.Size = new System.Drawing.Size(1042, 1020);
			driver.FindElement(By.CssSelector(".btn")).Click();
			driver.FindElement(By.CssSelector(".card:nth-child(1) > div > .form-group:nth-child(1)")).Click();
			driver.FindElement(By.Id("firstName")).Click();
			driver.FindElement(By.Id("firstName")).SendKeys("pruthvi");
			driver.FindElement(By.Id("lastName")).SendKeys("chauhan");
			driver.FindElement(By.Id("address")).SendKeys("23ref  hiwef");
			driver.FindElement(By.Id("city")).SendKeys("kitchener");
			driver.FindElement(By.Id("phone")).SendKeys("~");
			driver.FindElement(By.Id("postalCode")).Click();
			driver.FindElement(By.Id("postalCode")).SendKeys("N2A 0J7");
			driver.FindElement(By.Id("email")).SendKeys("pruthvirajchauhan2801@gmail.com");
			driver.FindElement(By.Id("phone")).Click();
			driver.FindElement(By.Id("phone")).SendKeys("3333333333");
			driver.FindElement(By.Id("age")).Click();
			driver.FindElement(By.Id("age")).SendKeys("27");
			driver.FindElement(By.Id("experience")).SendKeys("3");
			driver.FindElement(By.Id("accidents")).SendKeys("0");
			driver.FindElement(By.Id("btnSubmit")).Click();
			Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
		}
	}
}
	
