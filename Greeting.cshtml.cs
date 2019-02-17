using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp_1.Pages
{
    public class GreetingModel : PageModel
    {
        public string Message { get; set; } = "Hello";
        public void OnGet()
        {
            if (DateTime.Now.Hour >= 12)
            {
                Message = "Good Afternoon";
            }
            else
            {
                Message = "Good Morning";
            }



        }

    }
}