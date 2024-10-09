using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp
{
    class Website
    {
        // Define class properties (fields)
        public string Domain { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string HostingPackage { get; set; }
        public string ServerIP { get; set; }
        public string NameServer1 { get; set; }
        public string NameServer2 { get; set; }
        public string FTPHostName { get; set; }
        public string WebPageURL { get; set; }
        public string ControlPanel { get; set; }

        // Constructor
        public Website(string domain, string username, string password, string hostingPackage, string serverIP, string nameServer1, string nameServer2, string ftpHostName, string webPageURL, string controlPanel)
        {
            // Assign constructor parameters to the class properties
            Domain = domain;
            Username = username;
            Password = password;
            HostingPackage = hostingPackage;
            ServerIP = serverIP;
            NameServer1 = nameServer1;
            NameServer2 = nameServer2;
            FTPHostName = ftpHostName;
            WebPageURL = webPageURL;
            ControlPanel = controlPanel;
        }
    }
}
