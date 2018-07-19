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
        //Variables begin

        private string hostsPath; // Path of the hosts files (probably will change if exported to another OS)
        private string stagingIp; // IP of the staging URL
        private string filePath;  // Path of the file to be loaded
        private string documentationUrl; //Url of the app's documentation
        
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

        public string FilePath
        {
            set { this.filePath = value; }
            get { return this.filePath; }
        }

        public string DocumentationUrl
        {
            set { this.documentationUrl = value; }
            get { return this.documentationUrl; }
        }
        //Setters and getters end

        //Constructors begin

        public Configurations() //Default constructor
        {
            this.ReadConfigFile();

        }

        public Configurations(string hostsPath, string stagingIp) //Parametrized constructor
        {
            this.hostsPath = hostsPath;
            this.stagingIp = stagingIp;
        }

        //Constructors end

        // Methods begin

        public void ReadConfigFile() //Reads config file from config flie
        {
            string path = ".\\config.cfg";
            try
            {   
                string[] lines = File.ReadAllLines(path); //Reads the file and create an array
                this.hostsPath = lines[0];
                this.stagingIp = lines[1];
                this.documentationUrl = lines[2];
            }
            catch (System.Exception)
            {
                this.hostsPath = "Check config file";
                this.stagingIp = "Error";
            }
        }

        // Methods end 

    }
}
