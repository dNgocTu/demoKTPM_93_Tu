using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver_93_Tu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnOpenBrowser_93_Tu_Click(object sender, EventArgs e)
        {
            //1.d
            ChromeDriverService chrome_93_Tu = ChromeDriverService.CreateDefaultService();
            chrome_93_Tu.HideCommandPromptWindow = true;

            //1.a
            IWebDriver driver_93_Tu = new ChromeDriver(chrome_93_Tu);
            driver_93_Tu.Navigate().GoToUrl("https://www.google.com/");
            //1.c
            driver_93_Tu.Close(); //Đóng trình duyệt khi chạy thành công
            //1.f
            String link_hientai = driver_93_Tu.Url;
            Console.WriteLine(link_hientai);
            //1.e
            driver_93_Tu.Quit(); // Đóng mọi cửa sổ liên kết
          
        }

        private void btnOpenUrl_93_Tu_Click(object sender, EventArgs e)
        {
            //1.d
            //tat man hinh den
            ChromeDriverService chrome_93_Tu = ChromeDriverService.CreateDefaultService();
            chrome_93_Tu.HideCommandPromptWindow = true;
            
            //dieu huong trinh duyet
            IWebDriver driver_93_Tu = new ChromeDriver(chrome_93_Tu);
            //1.b
            driver_93_Tu.Url = textBox1.Text; // Lấy url từ ô nhập liệu
            driver_93_Tu.Navigate();
            //1.f
            String link_hientai = driver_93_Tu.Url;
            Console.WriteLine(link_hientai);
            //1.c
            driver_93_Tu.Close(); //Đóng trình duyệt khi chạy thành công
            //1.e
            driver_93_Tu.Quit(); // Đóng mọi cửa sổ liên kết
            
        }
    }
}
