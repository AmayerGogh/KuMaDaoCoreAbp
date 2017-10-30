using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Articles.Authorization
{
    /// <summary>
    /// 定义系统的权限名称的字符串常量。
    /// <see cref="ArticleAppAuthorizationProvider"/>中对权限的定义.
    /// </summary>
   public static class ArticleAppPermissions
    {

        /// <summary>
        /// 文章管理权限
        /// </summary>
        public const string Article = "Pages.Article";
        /// <summary>
        /// 文章创建权限
        /// </summary>
        public const string Article_CreateArticle = "Pages.Article.CreateArticle";
        /// <summary>
        /// 文章修改权限
        /// </summary>
        public const string Article_EditArticle = "Pages.Article.EditArticle";
        /// <summary>
        /// 文章删除权限
        /// </summary>
        public const string Article_DeleteArticle = "Pages.Article.DeleteArticle";
    }
}
