﻿using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using KuMaDaoCoreAbp.Authorization;
using KuMaDaoCoreAbp.Controllers;
using KuMaDaoCoreAbp.Users;
using KuMaDaoCoreAbp.Web.Areas.Admin.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace KuMaDaoCoreAbp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : KuMaDaoCoreAbpControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index(int count=10,int skip=0)
        {
            var users = (await _userAppService.GetAll(new PagedResultRequestDto {MaxResultCount = count,SkipCount =skip})).Items; //Paging not implemented yet
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