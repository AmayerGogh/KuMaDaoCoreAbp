﻿using System;
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
using KuMaDaoCoreAbp.Web.Areas.Admin.Models.Article;
using KuMaDaoCoreAbp.Categories;

namespace KuMaDaoCoreAbp.Web.Mvc.Areas.Admin.Controllers
{




    [Area("Admin")]
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class ArticleController : KuMaDaoCoreAbpControllerBase
    {
        //   private readonly IUserAppService _userAppService;
        readonly IArticleAppService _articleAppService;
        readonly ICategoryAppService _categoryAppService;
        public ArticleController(IArticleAppService articleAppService, ICategoryAppService categoryAppService)
        {
            _articleAppService = articleAppService;
            _categoryAppService = categoryAppService;
        }

        public async Task<ActionResult> Index()
        {
            //  var users = (await _articleAppService.GetAll(new PagedResultRequestDto { MaxResultCount = int.MaxValue })).Items; //Paging not implemented yet
            // var articles = (await _articleAppService.GetPagedArticlesAsync(new Article.Dto.GetArticleInput { })).Items;
            var articleCategoryList = await _categoryAppService.GetCategoryByType2KVAsync(EnumCategoryType.文章);
            var model = new ArticleIndexViewModel
            {
                ArticleTypeList =articleCategoryList
            };
            return View(model);
        }

        public async Task<ActionResult> EditArticleModal(long? id)
        {
            if (!id.HasValue)
            {
                return View("_editArticleModal", new EditArticleModal { GetArticleForEditOutput = new Articles.Dto.ArticleEditDto() });
            }
            var article = await _articleAppService.GetArticleForEditAsync(new NullableIdDto<long>(id));
            
            //  var roles = (await _userAppService.GetRoles()).Items;
            var modal = new EditArticleModal
            {
                GetArticleForEditOutput = article,               
            };
            return View("_editArticleModal", modal);

        }

        public async Task<ActionResult> EditContentModal(long id)
        {
            EditArticleDetailModal modal = new EditArticleDetailModal()
            {
                ArticleDetailDto = await _articleAppService.GetArticleDetailByArticleIdAsync(new EntityDto<long>(id))
            };
            return View("_editArticleDetailModal", modal);
        }


        public async Task<ActionResult> EditDetailSingle(long id)
        {
            EditArticleDetailModal modal = new EditArticleDetailModal()
            {
                ArticleDetailDto = await _articleAppService.GetArticleDetailByArticleIdAsync(new EntityDto<long>(id))
            };
            return View("_editArticleDetailSingle", modal);
        }

    }
}