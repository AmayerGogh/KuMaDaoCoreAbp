using Abp.Domain.Repositories;
using Abp.Domain.Services;
using KuMaDaoCoreAbp.Web;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Articles
{
   public  class ArticleManager: IArticleManager
    {

        private readonly IRepository<Article, long> _articleRepository;

        public ArticleManager(IRepository<Article, long> articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void TestManager(Article article)
        {
            throw new NotImplementedException();
        }

        //领域代码


        public async Task<Expression<Func<Article,bool>>> GetListAsync(BsTableRequestModel param)
        {
            var expressionList = new List<Expression<Func<Article, bool>>>();
            if (!string.IsNullOrWhiteSpace(param.search))
            {
                expressionList.Add(m => m.Title == param.search);
            }
           return await Amayer.Express.Express.BulidExpressionAsync(expressionList);
        }
    }
}
