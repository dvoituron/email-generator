using Microsoft.AspNetCore.Components;
using System;

namespace EmailGenerator.Models
{
    public class Signature
    {
        [Parameter]
        public string FirstName { get; set; } = "John";

        [Parameter]
        public string LastName { get; set; } = "Smith";

        [Parameter]
        public string Title { get; set; } = "IT Consultant";

        [Parameter]
        public string Phone { get; set; } = "+32 (0)475 10 00 00";

        [Parameter]
        public string Citation { get; set; } = "";

        [Parameter]
        public string Legal { get; set; } = "";

        [Parameter]
        public string CompanyFolder { get; set; } = "";

        [Parameter]
        public string UrlRoot { get; set; } = "https://localhost";

        [Parameter]
        public string UrlCompany { get; set; } = "";

        [Parameter]
        public string UrlLinkedin { get; set; } = "linkedin.com";

        [Parameter]
        public string UrlFacebook { get; set; } = "facebook.com";

        [Parameter]
        public string UrlInstagram { get; set; } = "instagram.com";

        public void SetCompanyFolder(string company)
        {
            CompanyFolder = company;
        }

        public string GetImageUrl(string value)
        {
            return $"{UrlRoot}/images/{CompanyFolder}/{value}";
        }
    }
}
