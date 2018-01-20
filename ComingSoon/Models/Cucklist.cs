using System;

namespace ComingSoon.Models
{
    public class Cucklist
    {
        public string CompanyName { get; set; }
        public string PrivacyPage { get; set; } = "Privacy Policy Page";
        public string PrivacyBlurb { get; set; }
        public DateTime DateTime { get; set; }
        public string CompanyStreetAddress { get; set; } = "145 Caribe Court";
        public string CompanyCity { get; set; } = "GreenAcres";
        public string CompanyState { get; set; } = "Florida";
        public string ZipCode { get; set; } = "33413";
        public string CompanyType { get; set; } = "LLC";

        public string Address;
        public string careof;





        public string Blurb()
        {
            PrivacyBlurb =
                "Cucklist.com will not sell, trade,or otherwise disclose your private information to any third party. Cucklist.com will under certain circumstances provide your information to its agents (namely sendgrid.com) for the exclusive purpose of sending communications via email concerning the state of the website Cucklist.com or your content/posts within the same.";
            return (PrivacyBlurb);
        }

        public string Name()
        {
            CompanyName = "Cucklist.com,";
            return (CompanyName);
        }

        public string FullAddress()
        {
            careof = "Care of : Development Operations";
            Address = Name() + CompanyType + Environment.NewLine + careof + Environment.NewLine + CompanyStreetAddress + Environment.NewLine + CompanyCity + " " + "," + CompanyState + " " + ZipCode;


            return (Address);
        }




    }


}
