using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentSys.Services;

namespace ViewComponentSys.ViewComponents
{
    public class UsersViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private IUserServices _userServices;

        public UsersViewComponent(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var users = await _userServices.GetUsersAsync();
            return View(users);
        }
    }
}
