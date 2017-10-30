using Abp.Authorization;
using Abp.Localization;
using KuMaDaoCoreAbp.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KuMaDaoCoreAbp.Articles.Authorization
{
 public    class ArticleAppAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            var pages = context.GetPermissionOrNull(PermissionNames.Pages) ?? context.CreatePermission(PermissionNames.Pages, L("Pages"));

            var entityNameModel = pages.Children.FirstOrDefault(p => p.Name == PermissionNames.Pages_Administration)
              ?? pages.CreateChildPermission(PermissionNames.Pages_Administration, L("Administration"));
            var article = entityNameModel.CreateChildPermission(ArticleAppPermissions.Article, L("Article"));
            article.CreateChildPermission(ArticleAppPermissions.Article_CreateArticle, L("CreateArticle"));
            article.CreateChildPermission(ArticleAppPermissions.Article_EditArticle, L("EditArticle"));
            article.CreateChildPermission(ArticleAppPermissions.Article_DeleteArticle, L("DeleteArticle"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, KuMaDaoCoreAbpConsts.LocalizationSourceName);
        }
    }
}
