/*
 * Created by Abraham Oviedo
 * April, 2018
 */
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Redirects
{
    class CDriver
    {
        private IWebDriver driver = new ChromeDriver();
        private List<Redirect> list = new List<Redirect>(); //Stores the list of URLs
        public CDriver()
        {
            this.List = null;
        }

        public CDriver(List<Redirect> list)
        {
            this.List = list;
        }

        public List<Redirect> CheckUrls()
        {
            this.Driver.Manage().Window.Maximize();
            for (int i = 0; i < this.List.Count; i++)
            {
                this.Driver.Navigate().GoToUrl(this.List[i].Origin);
                this.List[i].ServerDestiny = this.Driver.Url;
                Console.WriteLine("Origin: " + this.List[i].Origin);
                Console.WriteLine("Destiny: " + this.List[i].Destiny);
                Console.WriteLine("Server Destiny: " + this.List[i].ServerDestiny);
                Console.WriteLine("Response: " + this.List[i].Response);

            }


            this.Driver.Quit();
            return this.List;
        }


        public List<Redirect> List 
        {
            get { return this.list; }
            set { this.list = value; }
        }

        public IWebDriver Driver
        {
            get { return this.driver; }
            set { this.driver = value; }
        }
    }
}
