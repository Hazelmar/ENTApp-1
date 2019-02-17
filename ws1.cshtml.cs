using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp_1.Pages
{
    public class ws1Model : PageModel
    {

        public string Output { get; set; }
        public string[] MyTestArray { get; set; } = { "England", "Ireland", "Scotland", "Wales" };

        public void OnGet(string firstname)
        {
            Output = $"Hello {firstname}";
        }
    }
}