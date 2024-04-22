using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace STT_Tu_N2_B4_03
{
    public partial class form_93_Tu : Form
    {
        public form_93_Tu()
        {
            InitializeComponent();
        }

        private void btnOpenUrl_93_Tu_Click(object sender, EventArgs e)
        {

            //Bai1
            //IWebDriver driver_93_Tu = new ChromeDriver();
            //driver_93_Tu.Navigate().GoToUrl("https://www.facebook.com/");
            //*[@id="email"]

            //IWebElement e_email_93_Tu = driver_93_Tu.FindElement(By.XPath("//*[@id=\"email\"]"));
            //e_email_93_Tu.SendKeys("93_Tu_testXpath@gmail.com");

            //IWebElement e_email_93_Tu = driver_93_Tu.FindElement(By.CssSelector("input[type='text']"));
            //e_email_93_Tu.SendKeys("93_Tu_testCssSelector@gmail.com");

            //IWebElement e_pass_93_Tu = driver_93_Tu.FindElement(By.CssSelector("input[type='password']"));
            //e_pass_93_Tu.SendKeys("testpass_93_Tu");

            //IWebElement e_email_93_Tu = driver_93_Tu.FindElement(By.Name("email"));
            //e_email_93_Tu.SendKeys("93_Tu@gmail.com");

            //IWebElement e_email_93_Tu = driver_93_Tu.FindElement(By.ClassName("inputtext"));
            //e_email_93_Tu.SendKeys("93_Tu@gmail.com");


            //IWebElement e_pass_93_Tu = driver_93_Tu.FindElement(By.Name("pass"));
            //e_pass_93_Tu.SendKeys("pass_93_Tu");

            //IWebElement e_login_93_Tu = driver_93_Tu.FindElement(By.Name("login"));
            //e_login_93_Tu.Click();

            //IWebElement e_linktext_93_Tu = driver_93_Tu.FindElement(By.LinkText("Forgotten password?"));
            //e_linktext_93_Tu.Click();



            //Bai 2
            //IWebDriver driver_93_Tu = new ChromeDriver();
            //driver_93_Tu.Navigate().GoToUrl("https://en.wikipedia.org/wiki/I_Want_to_Love_You");
            //IReadOnlyCollection<IWebElement> ee_93_Tu = driver_93_Tu.FindElements(By.TagName("h2"));
            //foreach (var element in ee_93_Tu)
            //{
            //    Console.WriteLine(element.Text);
            //}



            //Bai 3
            //IWebDriver driver_93_Tu = new ChromeDriver();
            //driver_93_Tu.Navigate().GoToUrl("https://demo.guru99.com/test/upload/");

            //IWebElement e_btnChooseFile_93_Tu = driver_93_Tu.FindElement(By.Name("uploadfile_0"));
            //e_btnChooseFile_93_Tu.SendKeys(@"D:\logoOU.png");

            //IWebElement e_btnAccept_93_Tu = driver_93_Tu.FindElement(By.Name("terms"));
            //e_btnAccept_93_Tu.Click();

            //IWebElement e_submit_93_Tu = driver_93_Tu.FindElement(By.Name("send"));
            //e_submit_93_Tu.Click();



            //Bai 4
            IWebDriver driver_93_Tu = new ChromeDriver();
            driver_93_Tu.Navigate().GoToUrl("https://demo.guru99.com/test/delete_customer.php");

            IWebElement e_inputBox_93_Tu = driver_93_Tu.FindElement(By.Name("cusid"));
            e_inputBox_93_Tu.SendKeys("53920");

            //IWebElement e_submit_93_Tu = driver_93_Tu.FindElement(By.Name("submit"));
            //e_submit_93_Tu.Click();

            //driver_93_Tu.SwitchTo().Alert().Accept();
            //driver_93_Tu.SwitchTo().Alert().Dismiss();

            IWebElement e_reset_93_Tu = driver_93_Tu.FindElement(By.Name("res"));
            e_reset_93_Tu.Click();
        }
    }
}
