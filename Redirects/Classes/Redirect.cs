/*
 * Created by Abraham Oviedo
 * April, 2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redirects
{
    class Redirect
    {
        private string origin = "";
        private string destiny = "";
        private string serverDestiny;
        private string result = "";
        private int response;
        private int passed = 0; //true only if redirect worked

        public string Origin
        {
            get { return this.origin; }
            set { this.origin = this.TrimUrl(value); }

        }
        public string Destiny
        {
            get { return this.destiny; }
            set { this.destiny = this.TrimUrl(value); }
        }
        public string ServerDestiny
        {
            get { return this.serverDestiny; }
            set { this.serverDestiny = this.TrimUrl(value); }  
        }


        public string Result
        {
            get { return this.result; }
            set { this.result = value; }
        }
        public int Response
        {
            get { return this.response; }
            set { this.response = value; }
        }
        public int Passed
        {
            get { return this.passed; }
            set { this.passed = value; }
        }
        public Redirect(string origin, string destiny)
        {
            this.origin = origin;
            this.destiny = destiny;
        }
        public Redirect()
        {

        }

        private string TrimUrl(string url)
        {
            char last = url[url.Length - 1];
            if (last == '/') //Verifies if the URL ends with a dash
            {
                url = url.Substring(0, url.Length-1);
            }

            Console.WriteLine(url);
            return url;
        }
    }



}
