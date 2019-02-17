using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp_1.Pages
{
    public class TaGHelpPlayModel : PageModel
    {
        [BindProperty]
        public int Number1 { get; set; }
        public string Message { get; set; }
        [BindProperty]
        public int Number2 { get; set; }
        [BindProperty]
        public int? Number3 { get; set; }
        [BindProperty]
        public double Number4 { get; set; }
        [BindProperty]
        public double? Number5 { get; set; }
        [BindProperty]
        public decimal Number6 { get; set; }
        [BindProperty]
        public decimal? Number7 { get; set; }
        [BindProperty]
        public float Number8 { get; set; }
        [BindProperty]
        public float? Number9 { get; set; }
        [BindProperty]
        public string TestString { get; set; }
        public string PostMessage { get; set; }
        [BindProperty]
        public DateTime Date1 { get; set; }
        [BindProperty]
        public bool IsContactAllowed { get; set; }
        [BindProperty]
        public string Season { get; set; }
        public string SeasonMessage { get; set; }

        public void OnGet()
        {
            Message = string.Format($"Hello World from the Get Method");
        }
        public void OnPost()
        {
            PostMessage = string.Format($"The number entered is {0}", Number1);
            SeasonMessage = string.Format($"The Season you selected is {0}", Season);
        }
    }
}