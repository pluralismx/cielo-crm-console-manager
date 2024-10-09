using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace MyConsoleApp
{
    class CustomerList
    {
        // Private backing field
        private List<Website> _websites;

        // Constructor to initialize the list
        public CustomerList()
        {
            _websites = new List<Website>();
        }

        // Method to load wesites from json file
        public void LoadWebsitesFromFile(string path){
            if(File.Exists(path)){
                string jsonString = File.ReadAllText(path);
                _websites = JsonConvert.DeserializeObject<List<Website>>(jsonString);
                Console.WriteLine("Data loaded");
            }else{
                Console.WriteLine("File not found");
            }
        }

        // Method to save websites to file
        public void SaveWebsiteToFile(string path){
            string outputJson = JsonConvert.SerializeObject(_websites, Formatting.Indented);
            File.WriteAllText(path, outputJson);
            Console.WriteLine("Data saved");
        }

        // Private method to display details of a single website
        private void DisplayWebsiteDetails(Website website)
        {
            const int col1Width = 20;
            const int col2Width = 40;

            Console.WriteLine("╔" + new string('═', col1Width) + "╦" + new string('═', col2Width) + "╗");
            Console.WriteLine($"║{"Domain".PadRight(col1Width)}║{website.Domain.PadRight(col2Width)}║");
            Console.WriteLine("╠" + new string('═', col1Width) + "╬" + new string('═', col2Width) + "╣");
            Console.WriteLine($"║{"Username".PadRight(col1Width)}║{website.Username.PadRight(col2Width)}║");
            Console.WriteLine("╠" + new string('═', col1Width) + "╬" + new string('═', col2Width) + "╣");
            Console.WriteLine($"║{"Password".PadRight(col1Width)}║{website.Password.PadRight(col2Width)}║");
            Console.WriteLine("╠" + new string('═', col1Width) + "╬" + new string('═', col2Width) + "╣");
            Console.WriteLine($"║{"Package".PadRight(col1Width)}║{website.HostingPackage.PadRight(col2Width)}║");
            Console.WriteLine("╠" + new string('═', col1Width) + "╬" + new string('═', col2Width) + "╣");
            Console.WriteLine($"║{"Server IP".PadRight(col1Width)}║{website.ServerIP.PadRight(col2Width)}║");
            Console.WriteLine("╠" + new string('═', col1Width) + "╬" + new string('═', col2Width) + "╣");
            Console.WriteLine($"║{"Name Server 1".PadRight(col1Width)}║{website.NameServer1.PadRight(col2Width)}║");
            Console.WriteLine("╠" + new string('═', col1Width) + "╬" + new string('═', col2Width) + "╣");
            Console.WriteLine($"║{"Name Server 2".PadRight(col1Width)}║{website.NameServer2.PadRight(col2Width)}║");
            Console.WriteLine("╠" + new string('═', col1Width) + "╬" + new string('═', col2Width) + "╣");
            Console.WriteLine($"║{"FTP Host name".PadRight(col1Width)}║{website.FTPHostName.PadRight(col2Width)}║");
            Console.WriteLine("╠" + new string('═', col1Width) + "╬" + new string('═', col2Width) + "╣");
            Console.WriteLine($"║{"Web Page URL".PadRight(col1Width)}║{website.WebPageURL.PadRight(col2Width)}║");
            Console.WriteLine("╠" + new string('═', col1Width) + "╬" + new string('═', col2Width) + "╣");
            Console.WriteLine($"║{"Control Panel".PadRight(col1Width)}║{website.ControlPanel.PadRight(col2Width)}║");
            Console.WriteLine("╚" + new string('═', col1Width) + "╩" + new string('═', col2Width) + "╝");
        }

        // Private method to display details of multiple websites
        private void DisplayWebsitesDetails(IEnumerable<Website> websites)
        {
            foreach (var website in websites)
            {
                DisplayWebsiteDetails(website);
            }
        }

        // Method to add a website to the list
        public void AddWebsite(Website website)
        {
            if (website == null)
            {
                throw new ArgumentNullException(nameof(website), "Website cannot be null");
            }
            _websites.Add(website);
        }

        // Method to display a single website by domain
        public void DisplayWebsite(string domain)
        {
            var website = _websites.FirstOrDefault(w => w.Domain == domain);
            if (website == null)
            {
                Console.WriteLine("No website found with the given domain.");
            }
            else
            {
                DisplayWebsiteDetails(website);
            }
        }

        // Method to display all websites
        public void DisplayAllWebsites()
        {
            DisplayWebsitesDetails(_websites);
        }

        // Method to display matching websites by search phrase
        public void DisplayMatchingWebsites(string searchPhrase)
        {
            var matchingWebsites = _websites.Where(w => w.Domain.IndexOf(searchPhrase, StringComparison.OrdinalIgnoreCase) >= 0);
            DisplayWebsitesDetails(matchingWebsites);
        }
    }
}

