﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using React.Models;
using System.Threading.Tasks;

namespace React.Controllers
{
    [Route("manage")]
    public class ManageController : BaseController
    {
        public ManageController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
            :base(userManager, 
                 signInManager)
        {
        }

        public async Task<ActionResult> Index()
        {
            return View("js-{auto}", await BuildState());
        }

        [Route("changepassword")]
        public async Task<ActionResult> ChangePassword()
        {
            return View("js-{auto}", await BuildState());
        }
    }
}