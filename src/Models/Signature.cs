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
        public string Logo { get; set; } = "/images/igroove.png";

    }
}
