using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var CustomerList = new CustomerList();
            CustomerList.LoadWebsitesFromFile("websites.json");

            Console.WriteLine("[1] Add Website");
            Console.WriteLine("[2] Search for a given Website");
            Console.WriteLine("[3] List all records");
            Console.WriteLine("[x] To save and exit");

            var userInput = Console.ReadLine();

            while(true){
                switch(userInput){
                    case "1":
                        Console.WriteLine("Domain:");
                        var Domain = Console.ReadLine();

                        Console.WriteLine("User name:");
                        var UserName = Console.ReadLine();

                        Console.WriteLine("Password:");
                        var Password = Console.ReadLine();

                        Console.WriteLine("HostingPackage:");
                        var HostingPackage = Console.ReadLine();

                        Console.WriteLine("Server IP:");
                        var ServerIP = Console.ReadLine();

                        Console.WriteLine("Name Server 1:");
                        var NameServer1 = Console.ReadLine();

                        Console.WriteLine("Name Server 2:");
                        var NameServer2 = Console.ReadLine();

                        Console.WriteLine("FTP Host Name:");
                        var FTPHostName = Console.ReadLine();

                        Console.WriteLine("Web Page URL:");
                        var WebPageURL = Console.ReadLine();
            
                        Console.WriteLine("Control Panel:");
                        var ControlPanel = Console.ReadLine();

                        var newWebsite = new Website(Domain, UserName, Password, HostingPackage, ServerIP, NameServer1, NameServer2, FTPHostName, WebPageURL, ControlPanel);
                        CustomerList.AddWebsite(newWebsite);

                        break;
                    case "2":
                        Console.WriteLine("Search Website by Domain");
                        var query = Console.ReadLine();
                        CustomerList.DisplayMatchingWebsites(query);
                        break;
                    case "3":
                        Console.Clear();
                        CustomerList.DisplayAllWebsites();
                        break;
                    case "x":
                        CustomerList.SaveWebsiteToFile("websites.json");
                        return;
                    case "clear":
                        Console.Clear();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("[1] Add Website");
                Console.WriteLine("[2] Search for a given Website");
                Console.WriteLine("[3] List all records");
                Console.WriteLine("[x] To exit");
                userInput = Console.ReadLine();
            }

        }
    }
}