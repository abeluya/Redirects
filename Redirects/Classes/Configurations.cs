using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redirects
{
    class Configurations
    {
        //Variables
        private string hostsPath; // Path of the hosts files (probably will change if exported to another OS)
        private string stagingIp; // IP of the staging URL
        //Variables end

        //Setters and getters
        public string HostsPath
        {
            set { this.hostsPath = value; }
            get { return this.hostsPath; }
        }

        public string StagingIp
        {
            set { this.stagingIp = value; }
            get { return this.stagingIp; }
        }

        //Setters and getters end

        //Constructors

        public Configurations() //Default constructor
        {
            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            this.hostsPath = Path.Combine(systemPath, @"drivers\etc\hosts");
            this.stagingIp = "http://www.solarwinds.com-v1.edgekey-staging.net";

        }

        public Configurations(string hostsPath, string stagingIp) //Parametrized constructor
        {
            this.hostsPath = hostsPath;
            this.stagingIp = stagingIp;
        }

        //Constructors end
    }
}
