/*
 * Created by Abraham Oviedo
 * April, 2018
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Redirects
{
    class FDriver
    {
        FirefoxDriver driver = new FirefoxDriver();
        private List<Redirect> list = new List<Redirect>(); //Stores the list URLs
        private frmMain form;

        public FDriver()
        {
            this.List = null;
        }

        public FDriver(List<Redirect> list, frmMain form)
        {
            this.List = list;
            this.form = form;
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
                this.form.UpdatePgrBar();

            }


            this.Driver.Quit();
            return this.List;
        }

 

        public List<Redirect> List
        {
            get { return this.list; }
            set { this.list = value; }
        }

        public FirefoxDriver Driver
        {
            get { return this.driver; }
            set { this.driver = value; }
        }
    }
}
