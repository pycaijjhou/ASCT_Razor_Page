﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ASCT_Razor_Page.Pages
{
    public class AdminUIModel : PageModel
    {
        private readonly ILogger<AdminUIModel> _logger;

        public AdminUIModel(ILogger<AdminUIModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        // property to record the user's input in the AdminUI
        [BindProperty]
        public Aircraft Unit { get; set; }

        // when the post request is sent (submit is clicked)
        public IActionResult OnPost() {
            if (ModelState.Invalid == false) {
                return Page;
            }

            return RedirectToPage("/AdminUI");
        }
    }
}
