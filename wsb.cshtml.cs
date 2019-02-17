using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp_1.Pages
{
    public class wsbModel : PageModel
    {
        [BindProperty]
        public int Number1 { get; set; }
        [BindProperty]
        public int Number2 { get; set; }
        public string Message { get; set; }
        public int Total { get; set; }
        public string MyMessage { get; set; }
        [BindProperty]
        public string Result { get; set; }
        public void OnPost(int Number1, int Number2)
        {
            Message = string.Format($"The sum of {Number1} plus {Number2} is {Number1 + Number2}");

            if (Result == "add")
            {
                Total = Number1 + Number2;
            }
            else if (Result == "subtract")
            {
                Total = Number1 - Number2;
            }
            else if (Result == "multiply")
            {
                Total = Number1 * Number2;
            }
            else
            {
                Total = Number1 / Number2;
            }
            MyMessage = string.Format($"The total is {0}", Total);
        }
    }
}