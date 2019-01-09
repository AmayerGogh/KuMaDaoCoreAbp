using Abp.Domain.Services;
using KuMaDaoCoreAbp.Web;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Articles
{
   public interface IArticleManager : IDomainService
    {
        void TestManager(Article article);

        List<Expression<Func<Article, bool>>> GetListAsync(BsTableRequestModel param);
    }
}
