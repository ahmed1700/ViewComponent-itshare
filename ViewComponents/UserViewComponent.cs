using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewComponentSys.Services;

namespace ViewComponentSys.ViewComponents
{
    public class UserViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private IUserServices _userServices;
        public UserViewComponent(IUserServices userServices)
        {
            _userServices = userServices;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var user = await _userServices.GetUserAsync(id);
            return View(user);
        }
    }
}
