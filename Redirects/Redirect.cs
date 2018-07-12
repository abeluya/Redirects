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
            set { this.origin = value; }

        }
        public string Destiny
        {
            get { return this.destiny; }
            set { this.destiny = value; }
        }
        public string ServerDestiny
        {
            get { return this.serverDestiny; }
            set { this.serverDestiny = value; }
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
    }



}
