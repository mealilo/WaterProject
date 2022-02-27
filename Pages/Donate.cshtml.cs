using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WaterProject.Infrastructure;
using WaterProject.Models;

namespace WaterProject.Pages
{
    public class DonateModel : PageModel
    {

        private IWaterProjectRepository repo { get; set; }


        public DonateModel (IWaterProjectRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        public Basket basket { get; set;}
        public string ReturnURl { get; set; }
        public void OnGet(string returnURl)
        {
            ReturnURl = returnURl ?? "/";

        }

        public IActionResult OnPost(int projectID, string returnUrl)
        {

            Project p = repo.Projects.FirstOrDefault(x => x.ProjectId == projectID);
            basket.AddItem(p, 1);
            return RedirectToPage(new { ReturnURl = returnUrl });

        }

        public IActionResult OnPostRemove(int projectId, string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.Project.ProjectId == projectId).Project);

            return RedirectToPage(new { ReturnURl = returnUrl });
        }
    }
}
