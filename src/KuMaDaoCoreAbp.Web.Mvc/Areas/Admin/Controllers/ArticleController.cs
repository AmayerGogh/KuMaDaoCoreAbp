using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KuMaDaoCoreAbp.Authorization;
using KuMaDaoCoreAbp.Controllers;
using Abp.AspNetCore.Mvc.Authorization;
using KuMaDaoCoreAbp.Users;
using KuMaDaoCoreAbp.Articles;
using Abp.Application.Services.Dto;
using KuMaDaoCoreAbp.Web.Areas.Admin.Models.Users;

namespace KuMaDaoCoreAbp.Web.Mvc.Areas.Admin.Controllers
{
   



    [Area("Admin")]
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class ArticleController : KuMaDaoCoreAbpControllerBase
    {
        private readonly IUserAppService _userAppService;
        private readonly IArticleAppService _articleAppService;
        public ArticleController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var users = (await _userAppService.GetAll(new PagedResultRequestDto { MaxResultCount = int.MaxValue })).Items; //Paging not implemented yet
            var roles = (await _userAppService.GetRoles()).Items;
            var model = new UserListViewModel
            {
                Users = users,
                Roles = roles
            };
            return View(model);
        }

        public async Task<ActionResult> EditUserModal(long userId)
        {
            var user = await _userAppService.Get(new EntityDto<long>(userId));
            var roles = (await _userAppService.GetRoles()).Items;
            var model = new EditUserModalViewModel
            {
                User = user,
                Roles = roles
            };
            return View("_EditUserModal", model);
        }
    }
}