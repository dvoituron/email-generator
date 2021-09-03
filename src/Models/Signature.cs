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
        public string Citation { get; set; } = "As a kid, I wanted to be a fighter pilot";

        [Parameter]
        public string Legal { get; set; } = "The content of this email is confidential and intended for the recipient specified in message only. It is strictly forbidden to share any part of this message with any third party, without a written consent of the sender. If you received this message by mistake, please reply to this message and follow with its deletion, so that we can ensure such a mistake does not occur in the future.";

        [Parameter]
        public string CompanyFolder { get; set; } = "igroove";

        [Parameter]
        public string UrlCompany { get; set; } = "www.igroove.be";

        [Parameter]
        public string UrlLinkedin { get; set; } = "linkedin.com";

        [Parameter]
        public string UrlFacebook { get; set; } = "facebook.com";

        [Parameter]
        public string UrlInstagram { get; set; } = "instagram.com";

        public void SetCompany(string value)
        {
            CompanyFolder = value;
        }

        public string GetImageUrl(string value)
        {
#if DEBUG
            return $"https://localhost:5001/images/{CompanyFolder}/{value}";
#else
            return $"https://signaturegenerator.z6.web.core.windows.net/images/{CompanyFolder}/{value}";
#endif
        }
    }
}
